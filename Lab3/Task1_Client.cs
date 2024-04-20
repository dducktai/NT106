using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Task1_Client : Form
    {
        public Task1_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(txtIP.Text, int.Parse(txtPort.Text));
            Byte[] senddata = Encoding.ASCII.GetBytes(txtMessage.Text);
            udpClient.Send(senddata, senddata.Length);
            txtMessage.Text = "";
            udpClient.Close();
        }
    }
}
