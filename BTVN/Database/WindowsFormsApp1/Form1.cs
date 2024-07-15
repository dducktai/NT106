using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        string connectstring = @"Data Source=LAPTOP-E3M19UFS\SQLEXPRESS;Initial Catalog=DangDucTai_22521270;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dt.Clear();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand(textBox1.Text.Trim(), con);
                    adt = new SqlDataAdapter(cmd);
                    dt.Clear();
                    adt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


