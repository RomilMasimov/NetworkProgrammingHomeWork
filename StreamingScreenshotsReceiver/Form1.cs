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
            var result = IPAddress.TryParse("127.0.0.1", out var ipAddress);
            if (result)
            {
                ListenAsync(ipAddress);
                return;
            }
            MessageBox.Show("Enter a valid address.");
        }

        private void ListenAsync(IPAddress serverIpAddress)
        {
            var tcpReceiver = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var serverIpPoint = new IPEndPoint(serverIpAddress, 27001);
            tcpReceiver.Connect(serverIpPoint);
            var localIpPoint = tcpReceiver.LocalEndPoint;
            
            var data = Encoding.Unicode.GetBytes("start");
            tcpReceiver.Send(data);
            
            var udpReceiver = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpReceiver.Bind(localIpPoint);
            while (true)
            {
                byte[] numData = new byte[32];
                udpReceiver.ReceiveFrom(numData, ref localIpPoint);
                var count = BitConverter.ToInt32(numData, 0);
                
                Image image;
                byte[] imageData = new byte[count];
                udpReceiver.ReceiveFrom(imageData, ref localIpPoint);
                using (var memoryStream = new MemoryStream(imageData))
                {
                    using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                    {
                        image = Image.FromStream(gZipStream);
                        //image.Save("test.png");
                    }
                }
                this.pictureBox1.Image = image;
            }

        }
    }
}
