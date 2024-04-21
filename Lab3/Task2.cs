using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread severthread = new Thread(new ThreadStart(StartThread));
            severthread.Start();
        }

        private void StartThread()
        {
            MessageBox.Show("Server bắt đầu lắng nghe!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            listViewCommand.Items.Add(new ListViewItem("Waiting for connetion"));
            int bytesRecv = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;

            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepSV = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepSV);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();

            listViewCommand.Items.Add(new ListViewItem("New client conneted"));

            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesRecv = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                }
                while (text[text.Length - 1] != '\n');
                listViewCommand.Items.Add(new ListViewItem("You said: " + text));
            }
            listenerSocket.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
