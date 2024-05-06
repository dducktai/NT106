using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Task4_Server server = new Task4_Server();
            server.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Task4_Client client = new Task4_Client();
            client.Show();
        }
    }
}
