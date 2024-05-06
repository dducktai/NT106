using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Task3_Client : Form
    {
        public Task3_Client()
        {
            InitializeComponent();
        }

        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private void btnSend_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);

            tcpClient.Connect(ipEndPoint);
            networkStream = tcpClient.GetStream();

            if (networkStream != null && networkStream.CanWrite)
            {
                Byte[] data = Encoding.UTF8.GetBytes("Hello Server \r\n");
                networkStream.Write(data, 0, data.Length);
            }
        }

        private void Task3_Client_Load(object sender, EventArgs e)
        {
            
        }

        private void Task3_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (networkStream != null)
            {
                Byte[] data = Encoding.ASCII.GetBytes("Quit\n");
                networkStream.Write(data, 0, data.Length);
                networkStream.Close();
            }

            if (tcpClient != null)
            {
                tcpClient.Close();
            }
        }
    }
}
