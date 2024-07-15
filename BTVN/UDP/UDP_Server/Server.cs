using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace UDP_Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        private UdpClient udpserver;
        private Thread thread;
        void receiverData()
        {
            try
            {
                while (true)
                {
                    IPEndPoint ipend = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] rcvbyte = udpserver.Receive(ref ipend);
                    string data = Encoding.UTF8.GetString(rcvbyte);

                    Invoke(new Action(() =>
                    {
                        rtb_main.Text = ipend.Address.ToString() + " (port: " + ipend.Port.ToString() + "): " + data.ToString() + "\n";
                    }));

                    string mess = "Đã nhận";
                    Byte[] rspdata = Encoding.UTF8.GetBytes(mess);
                    udpserver.Send(rspdata, rspdata.Length, ipend);

                }
            }
            catch
            {
                MessageBox.Show("Nhập đầy đủ IPAddress và Port");
            }
        }
        private void rbt_send_Click(object sender, EventArgs e)
        {
            IPAddress serverIP = IPAddress.Parse("127.0.10.1");
            int port = 8080;
            IPEndPoint localend = new IPEndPoint(serverIP, port);

            try
            {
                udpserver = new UdpClient(localend);
                thread = new Thread(new ThreadStart(receiverData));
                thread.Start();
                MessageBox.Show("Đang hoạt động");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server đang hoạt động");
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void rtb_main_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }
    }
}
