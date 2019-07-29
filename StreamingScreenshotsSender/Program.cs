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
                    SendScreenshots(client.RemoteEndPoint);
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                    break;
                }
            }
        }

        static void SendScreenshots(EndPoint ipPoint)
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            while (true)
            {
                byte[] data;
                //using (var screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
                using (var screenshot = new Bitmap(640, 360))
                {
                    using (var graphics = Graphics.FromImage(screenshot))
                    {
                        graphics.CopyFromScreen(0, 0, 0, 0, screenshot.Size);
                    }

                    using (var memoryStream = new MemoryStream())
                    {
                        using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                        {
                            screenshot.Save(gZipStream, ImageFormat.Png);
                            data = memoryStream.ToArray();
                        }
                    }                }

                var numData = BitConverter.GetBytes(data.Length);
                socket.SendTo(numData, ipPoint);
                socket.SendTo(data, ipPoint);
                Thread.Sleep(300);
            }
        }
    }
}
