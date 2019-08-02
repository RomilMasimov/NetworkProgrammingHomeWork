using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingScreenshotsReceiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var inputIpAddress = this.ipAddressTextBox.Text;
            if (IPAddress.TryParse(inputIpAddress, out var ipAddress))
            {
                ListenAsync(ipAddress);
                return;
            }
            MessageBox.Show("Enter a valid address.");
        }

        private async Task ListenAsync(IPAddress serverIpAddress)
        {
            var tcpReceiver = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var serverIpPoint = new IPEndPoint(serverIpAddress, 27001);
            tcpReceiver.Connect(serverIpPoint);
            var localIpPoint = tcpReceiver.LocalEndPoint;
            
            var data = Encoding.Unicode.GetBytes("start");
            tcpReceiver.Send(data);
            
            var udpReceiver = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpReceiver.Bind(localIpPoint);
            await Task.Run(() =>
            {
                while (true)
                {
                    Image image;
                    List<byte> imageData = new List<byte>();

                    byte[] numData = new byte[32];
                    udpReceiver.ReceiveFrom(numData, ref localIpPoint);
                    var parts = BitConverter.ToInt32(numData, 0);

                    for (int i = 1; i <= parts; i++)
                    {
                        byte[] countData = new byte[32];
                        udpReceiver.ReceiveFrom(countData, ref localIpPoint);
                        var count = BitConverter.ToInt32(countData, 0);

                        byte[] partsData = new byte[count];
                        udpReceiver.ReceiveFrom(partsData, ref localIpPoint);
                        imageData.AddRange(partsData);
                    }
                    using (var memoryStream = new MemoryStream(imageData.ToArray()))
                    {
                        image = Image.FromStream(memoryStream);
                    }
                    this.pictureBox1.Image = image;
                }
            });
        }
    }
}
