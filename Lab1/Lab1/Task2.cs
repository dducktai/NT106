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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsValidData()
        {
            double num1, num2, num3;

            //Nếu để trống thì giá trị mặc định là 0 
            if (textBox1.Text == "")
                textBox1.Text = "0";
            if (textBox2.Text == "")
                textBox2.Text = "0";
            if (textBox3.Text == "")
                textBox3.Text = "0";

            //Nếu đầu vào nhập dấu phẩy sẽ thay thế thành dấu . để tính toán
            textBox1.Text = textBox1.Text.Replace(',', '.');
            textBox2.Text = textBox2.Text.Replace(',', '.');
            textBox3.Text = textBox3.Text.Replace(',', '.');

            //KIểm tra xem các input có phải là số thực hay không
            if ((double.TryParse(textBox1.Text, out num1))
                && (double.TryParse(textBox2.Text, out num2))
                && (double.TryParse(textBox3.Text, out num3)))
            {
                return true;
            }

            //Nếu đầu vào không hợp lệ thì thông báo lỗi 
            MessageBox.Show("Giá trị đầu vào phải là một số thực. Vui lòng nhập lại!", "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                double num1, num2, num3;
                double num_max, num_min;
                num1 = double.Parse(textBox1.Text.Trim());
                num2 = double.Parse(textBox2.Text.Trim());
                num3 = double.Parse(textBox3.Text.Trim());
                num_max = Math.Max(Math.Max(num1, num2), num3);
                num_min = Math.Min(Math.Min(num1, num2), num3);
                textBox4.Text = num_max.ToString();
                textBox5.Text = num_min.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
