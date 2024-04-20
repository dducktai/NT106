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
            Thread severthread = new Thread(new ThreadStart(StartUnsafeThread));
            severthread.Start();
        }
        private void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;
            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();
            listViewCommand.Items.Add(new ListViewItem("New client connected"));
            while (clientSocket.Connected) 
            {
                string text = "";
                do
                {
                    bytesReceived += clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                listViewCommand.Items.Add(new ListViewItem(text));
            }
        listenerSocket.Close();
        }
    }
}
