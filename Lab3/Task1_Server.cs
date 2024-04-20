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

        private delegate void InfoMessageDel(String info);

        public void serverThread()
        {
            UdpClient udpClient = null;
            try
            {
                udpClient = new UdpClient(int.Parse(txtPort.Text));
                while (true)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    string mess = RemoteIpEndPoint.Address.ToString() + ": " +
                        returnData.ToString();
                    InfoMessage(mess);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                    udpClient.Close(); // Đóng UdpClient sau khi không còn cần thiết
            }
        }

        public void InfoMessage(String info)
        {
            if (lwMessage.InvokeRequired)
            {
                InfoMessageDel method = new InfoMessageDel(InfoMessage);
                lwMessage.Invoke(method, new object[] { info });
                return;
            }
            lwMessage.Items.Add(info);
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }
    }
}
