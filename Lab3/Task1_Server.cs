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
    public partial class Task1_Server : Form
    {
        public Task1_Server()
        {
            InitializeComponent();
        }

        private bool IsValidData()
        {
            if (string.IsNullOrEmpty(txtPort.Text))
            {
                MessageBox.Show("Vui lòng nhập Port!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private delegate void InfoMessageDel(String info);


        private UdpClient udpClient;
        private void serverThread()
        {
            if (IsValidData())
            {
                udpClient = new UdpClient(int.Parse(txtPort.Text));
                lwMessage.Items.Add(new ListViewItem("Server bắt đầu lắng nghe!"));
                /*MessageBox.Show("Server bắt đầu lắng nghe!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                while (true)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.UTF8.GetString(receiveBytes);
                    string mess = RemoteIpEndPoint.Address.ToString() + ": " + returnData.ToString();
                    InfoMessage(mess);
                }
                udpClient.Close();
            }
        }

        private void InfoMessage(String info)
        {
            if (lwMessage.InvokeRequired)
            {
                InfoMessageDel method = new InfoMessageDel(InfoMessage);
                lwMessage.Invoke(method, new object[] { info });
                return;
            }
            lwMessage.Items.Add(info);
        }

        private Thread thdUDPServer;
        private void btnListen_Click(object sender, EventArgs e)
        {
            thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        private void Task1_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (udpClient != null)
            {
                udpClient.Close();
            }*/
        }

        private void lwMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
