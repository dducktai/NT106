using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace HMee_UDP
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }


        private void tb_main_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {

        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            UdpClient udpclient = new UdpClient();
            IPAddress ipadd = IPAddress.Parse(tb_ip.Text);
            int port = Convert.ToInt32(tb_port.Text);
            IPEndPoint ipe = new IPEndPoint(ipadd, port);
            Byte[] sendbyte = Encoding.UTF8.GetBytes(tb_mess.Text);
            udpclient.Send(sendbyte, sendbyte.Length, ipe);
            tb_mess.Text = "";


            IPEndPoint ipend = new IPEndPoint(IPAddress.Any, 0);
            Byte[] rcvData = udpclient.Receive(ref ipend);
            string messmain = Encoding.UTF8.GetString(rcvData);

            tb_main.Text = "Server: " + messmain + "\n";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
    }
}
