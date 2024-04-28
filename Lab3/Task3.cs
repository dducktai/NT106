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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Task3_Server server = new Task3_Server();
            server.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task3_Client client = new Task3_Client();
            client.Show();
        }
    }
}
