using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private bool IsValidData()
        {
            int num1, num2;

            //Nếu để trống thì giá trị mặc định là 0
            if (textBox1.Text == "")
                textBox1.Text = "0";
            if (textBox2.Text == "")
                textBox2.Text = "0";

            //KIểm tra xem các input có phải là số nguyên hay không
            if (!int.TryParse(textBox1.Text, out num1) || !int.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("Vui lòng nhập vào hai số nguyên hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                int num1, num2;
                long sum = 0;
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                if (textBox1.Text == null)
                {
                    num1 = 0;
                }
                if (textBox2.Text == null)
                {
                    num2 = 0;
                }
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
