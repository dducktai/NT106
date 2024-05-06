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
            Thread serverThread = new Thread(new ThreadStart(StartThread));
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        Socket listenerSocket;
        private void StartThread()
        {
            listViewCommand.Items.Add(new ListViewItem("Server bắt đầu lắng nghe!"));
            /*MessageBox.Show("Server bắt đầu lắng nghe!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            listViewCommand.Items.Add(new ListViewItem("Waiting for connection"));
            int bytesRecv = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;

            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepSV = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepSV);
            listenerSocket.Listen(-1);

            while (true)
            {
                clientSocket = listenerSocket.Accept();
                listViewCommand.Items.Add(new ListViewItem("New client connected"));

                while (clientSocket.Connected)
                {
                    string text = "";
                    do
                    {
                        bytesRecv = clientSocket.Receive(recv);
                        text += Encoding.ASCII.GetString(recv);
                    }
                    while (text[text.Length - 1] != '\n');

                    if (bytesRecv == 0) // Kiểm tra nếu kết nối đã đóng
                    {
                        listViewCommand.Items.Add(new ListViewItem("Client disconnected"));
                        break; // Dừng vòng lặp khi kết nối đã đóng
                    }

                    listViewCommand.Items.Add(new ListViewItem("You said: " + text));
                }
                clientSocket.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listViewCommand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Task2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listenerSocket != null && listenerSocket.Connected)
            {
                listenerSocket.Shutdown(SocketShutdown.Both);
                listenerSocket.Close();
            }
        }
    }
}
