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
            byte[] recv = new byte[1024];

            try
            {
                listenerSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080));
                listenerSocket.Listen(1); // Chỉ chấp nhận một kết nối

                clientSocket = listenerSocket.Accept();
                listViewCommand.Items.Add("New client connected!");

                NetworkStream ns = new NetworkStream(clientSocket);
                byte[] data = Encoding.ASCII.GetBytes("Hello client\n");
                ns.Write(data, 0, data.Length);

                while (clientSocket.Connected)
                {
                    int bytesReceived = ns.Read(recv, 0, recv.Length);
                    string receivedText = Encoding.ASCII.GetString(recv, 0, bytesReceived);
                    listViewCommand.Items.Add(receivedText);

                    if (receivedText.Trim().ToLower() == "quit")
                    {
                        listViewCommand.Items.Add("Client requested to close connection.");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                listViewCommand.Items.Add("Error: " + ex.Message);
            }
            finally
            {
                if (clientSocket != null && clientSocket.Connected)
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
                listenerSocket.Close();
            }
        }

        private void Task3_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listenerSocket.Connected)
            {
                listenerSocket.Shutdown(SocketShutdown.Both);
            }
            if (listenerSocket != null)
            {
                listenerSocket.Close();
            }
        }
    }
}
