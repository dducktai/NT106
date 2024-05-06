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
    public partial class Task3_Server : Form
    {
        public Task3_Server()
        {
            InitializeComponent();
        }

        private Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private Socket clientSocket;

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            btnListen.Enabled = false;
            Thread serverThread = new Thread(new ThreadStart(StartThread));
            serverThread.Start();

        }

        private void StartThread()
        {

            listViewCommand.Items.Add("Server running on 127.0.0.1:8080");
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(1); // Chỉ chấp nhận một kết nối

            clientSocket = listenerSocket.Accept();
            listViewCommand.Items.Add("New client connected!");

            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                }
                while (text[text.Length - 1] != '\n');
                listViewCommand.Items.Add(text);
            }

            listViewCommand.Items.Add("Client left");
            clientSocket.Close();
            listenerSocket.Close();
        }

        private void Task3_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listenerSocket != null && listenerSocket.Connected)
            {
                listenerSocket.Shutdown(SocketShutdown.Both);
                listenerSocket.Close();
            }
        }
    }
}
