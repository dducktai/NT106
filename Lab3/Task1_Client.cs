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

        private bool IsValidData()
        {
            if (string.IsNullOrEmpty(txtIP.Text) && string.IsNullOrEmpty(txtPort.Text))
            {
                MessageBox.Show("Vui lòng nhập IP và Port!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (string.IsNullOrEmpty(txtIP.Text))
                {
                    MessageBox.Show("Vui lòng nhập IP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(txtPort.Text))
                {
                    MessageBox.Show("Vui lòng nhập Port!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private UdpClient udpClient;
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                udpClient = new UdpClient();
                udpClient.Connect(txtIP.Text, int.Parse(txtPort.Text));
                Byte[] senddata = Encoding.UTF8.GetBytes(txtMessage.Text);
                udpClient.Send(senddata, senddata.Length);
                txtMessage.Text = "";
                udpClient.Close();
            }
        }

        private void Task1_Client_Load(object sender, EventArgs e)
        {

        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void Task1_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (udpClient != null)
            {
                udpClient.Close();
            }
        }
    }
}
