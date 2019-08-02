using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingScreenshotsSender
{
    class Program
    {
        static void Main(string[] args)
        {
            var tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var serverIpPoint = new IPEndPoint(IPAddress.Any, 27001);

            tcpServer.Bind(serverIpPoint);
            tcpServer.Listen(10);

            while (true)
            {
                var client = tcpServer.Accept();
                var data = new byte[10];
                var bytes = client.Receive(data);
                var command = Encoding.Unicode.GetString(data, 0, bytes);


                if (command == "start")
                {
                    Console.WriteLine(client.RemoteEndPoint.ToString());
                    SendScreenshotsAsync(client.RemoteEndPoint);
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }
            }
        }

        static async Task SendScreenshotsAsync(EndPoint ipPoint)
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            await Task.Run(() =>
            {
                while (true)
                {
                    List<byte> imageData;
                    using (var screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
                    {
                        using (var graphics = Graphics.FromImage(screenshot))
                        {
                            graphics.CopyFromScreen(0, 0, 0, 0, screenshot.Size);
                        }

                        using (var memoryStream = new MemoryStream())
                        {
                            screenshot.Save(memoryStream, ImageFormat.Png);
                            imageData = memoryStream.ToArray().ToList();
                        }
                    }
                    Console.WriteLine(imageData.Count());
                    var parts = imageData.Count() / 65000 + (imageData.Count() % 65000 > 0 ? 1 : 0);
                    var partsData = BitConverter.GetBytes(parts);
                    socket.SendTo(partsData, ipPoint);

                    for (int i = 0; i < parts; i++)
                    {
                        var currentIndex = i * 65000;
                        int currentCount;
                        if (i + 1 == parts) currentCount = imageData.Count - currentIndex;
                        else currentCount = 65000;
                        
                        var numData = BitConverter.GetBytes(currentCount);
                        socket.SendTo(numData, ipPoint);
                        Thread.Sleep(40);
                        socket.SendTo(imageData.GetRange(currentIndex, currentCount).ToArray(), ipPoint);
                    }
                }
            });
            socket.Shutdown(SocketShutdown.Both);
        }
    }
}
