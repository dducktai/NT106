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
<<<<<<< HEAD

        private bool isListening = false;
        private Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private bool stopListening = false;

=======
        private bool isListening = false;
        private Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private bool stopListening = false;
>>>>>>> a06e2a7c8cdb7a504eb0d285c78da76928cb522a
        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            btnListen.Enabled = false;
            Thread serverThread = new Thread(new ThreadStart(StartThread));
            serverThread.Start();
        }

        private Socket clientSocket;

        private void StartThread()
        {
            listViewCommand.Items.Add("Server running on 127.0.0.1:8080");
            int bytesReceived = 0;
            byte[] recv = new byte[1024]; // Tăng kích thước buffer để nhận dữ liệu từ client
            Socket clientSocket;
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            try
            {
                listenerSocket.Bind(ipepServer);
                listenerSocket.Listen(-1);
                isListening = true;
                while (!stopListening)
                {
                    clientSocket = listenerSocket.Accept();

                    listViewCommand.Items.Add(new ListViewItem("New client connected!"));

                    while (clientSocket.Connected)
                    {
                        string text = "";
                        do
                        {
                            bytesReceived = clientSocket.Receive(recv);
                            text += Encoding.ASCII.GetString(recv, 0, bytesReceived);
                        }
                        while (text[text.Length - 1] != '\n');

                        listViewCommand.Items.Add(new ListViewItem(text));

                        if (text.Trim() == "Quit")
                        {
                            clientSocket.Shutdown(SocketShutdown.Both);
                            clientSocket.Close();
                            break;
                        }
                    }
                }
            }
            catch (SocketException)
            {
                listViewCommand.Items.Add(new ListViewItem("Đã đóng kết nối!"));
            }
            finally
            {
                if (listenerSocket != null && listenerSocket.Connected)
                {
                    listenerSocket.Close();
                }
            }
        }

<<<<<<< HEAD
        private void listViewCommand_SelectedIndexChanged(object sender, EventArgs e)
=======


        private void Task3_Server_FormClosed(object sender, FormClosedEventArgs e)
>>>>>>> a06e2a7c8cdb7a504eb0d285c78da76928cb522a
        {

        }

<<<<<<< HEAD
        private void Task3_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopListening = true; // Dừng tiến trình lắng nghe
            if (listenerSocket != null && listenerSocket.Connected)
            {
                listenerSocket.Shutdown(SocketShutdown.Both);
                listenerSocket.Close();
=======
        private void btnEnchat_Click(object sender, EventArgs e)
        {


        }

        private void Task3_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
>>>>>>> a06e2a7c8cdb7a504eb0d285c78da76928cb522a
            }
            else
            {
                stopListening = true; // Dừng tiến trình lắng nghe
                if (listenerSocket != null && listenerSocket.Connected)
                {
                    listenerSocket.Shutdown(SocketShutdown.Both);
                    listenerSocket.Close();
                }
            }
        }


        private void Task3_Server_Load(object sender, EventArgs e)
        {
            btnListen.Enabled = true;
        }
    }
}
