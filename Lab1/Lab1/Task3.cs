using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private bool IsValidData()
        {
            //Nếu để trống thì giá trị mặc định là 0 
            if (textBox1.Text == "")
                textBox1.Text = "0";

            //Nếu nhập vào kí tự khác số, thông báo không hợp lệ 
            int num1;
            if (!int.TryParse(textBox1.Text, out num1))
            {
                MessageBox.Show("Giá trị cần đọc phải là một SỐ NGUYÊN DƯƠNG. Vui lòng nhập lại!",
                    "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
            //Nếu nhập vào số âm thông báo không hợp lệ 
            int num2 = int.Parse(textBox1.Text);
            if (num2 < 0)
            {
                MessageBox.Show("Giá trị cần đọc phải là một SỐ NGUYÊN DƯƠNG. Vui lòng nhập lại!",
                    "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            ////Nếu nhập vào lớn hơn khả năng thực thi chương trình 
            if (num2 > 9999)
            {
                MessageBox.Show("Chương trình chỉ đọc được từ 0 đến 9999. Vui lòng nhập lại!",
                    "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                int num = 0;
                int n = textBox1.Text.Length;
                int number = int.Parse(textBox1.Text.Trim());
                string[] So = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười" };
                string[] donvi = { "nghìn", "trăm" };
                string[] spec = { "mươi", "lăm", "lẻ", "mốt" };
                if (number <= 10)
                {
                    textBox2.Text = So[number];
                }
                else if (number > 10 && number < 20)
                {
                    int sodu = number % 10;
                    if (number == 15)
                        textBox2.Text = "mười " + spec[1];
                    else
                        textBox2.Text = "mười " + So[sodu];

                }
                else if (number >= 20 && number < 100)
                {
                    if (number % 10 == 0)
                    {
                        int a = number / 10;
                        textBox2.Text = So[a] + " " + spec[0];
                    }
                    else
                    {
                        int a1 = number / 10;
                        int a2 = number % 10;
                        if ((number % 10) == 5)
                            textBox2.Text = So[a1] + " " + spec[0] + " " + spec[1];
                        else
                            textBox2.Text = So[a1] + " " + spec[0] + " " + So[a2];
                    }

                }
                else if (number >= 100 && number < 1000)
                {
                    if (number % 100 == 0)
                    {
                        int m = number / 100;
                        textBox2.Text = So[m] + " " + donvi[1];
                    }
                    else
                    {

                        int[] arr = new int[3];
                        int number2 = number;
                        int i = 2;
                        while (i >= 0)
                        {
                            int a1 = number % 10;
                            arr[i] = a1;
                            number -= a1;
                            number /= 10;
                            i--;
                        }
                        int sodu = number2 % 10;
                        if (sodu > 0 && sodu <= 10 && arr[1] == 0)
                        {
                            textBox2.Text = So[arr[0]] + " " + donvi[1] + " " + spec[2] + " " + So[sodu];
                            return;
                        }
                        if (arr[1] == 1)
                        {
                            string text = So[arr[0]] + " " + donvi[1] + " " + So[10] + " ";
                            if (arr[2] == 5)
                                textBox2.Text = text + spec[1];
                            else if (arr[2] == 0)
                                textBox2.Text = text;
                            else
                                textBox2.Text = text + So[arr[2]];
                            return;
                        }
                        string t = So[arr[0]] + " " + donvi[1] + " " + So[arr[1]] + " " + spec[0];
                        if (arr[2] == 0)
                            textBox2.Text = t;
                        else if (arr[2] == 5)
                            textBox2.Text = t + " " + spec[1];
                        else
                            textBox2.Text = t + " " + So[arr[2]];
                    }

                }
                else if (number >= 1000 && number <= 10000)
                {
                    if (number % 1000 == 0)
                    {
                        int m = number / 1000;
                        textBox2.Text = So[m] + " " + donvi[0];
                    }
                    else
                    {
                        int sodu = number % 10;
                        int sodu2 = number % 100;
                        int[] arr = new int[4];
                        int i = 3;
                        while (i >= 0)
                        {
                            int a1 = number % 10;
                            arr[i] = a1;
                            number -= a1;
                            number /= 10;
                            i--;
                        }
                        if (arr[2] == 0 && arr[3] == 0)
                        {
                            string ch = So[arr[0]] + " " + donvi[0] + " " + So[arr[1]] + " " + donvi[1];
                            textBox2.Text = ch;
                            return;
                        }
                        if (arr[2] == 0)
                        {
                            string ch = So[arr[0]] + " " + donvi[0] + " " + So[arr[1]] + " " + donvi[1] + " " + "lẻ" + " " + So[sodu];
                            textBox2.Text = ch;
                            return;
                        }
                        string t;
                        if (sodu2 >= 10 && sodu2 < 20)
                            t = So[arr[0]] + " " + donvi[0] + " " + So[arr[1]] + " " + donvi[1] + " " + So[10];
                        else
                            t = So[arr[0]] + " " + donvi[0] + " " + So[arr[1]] + " " + donvi[1] + " " + So[arr[2]] + " " + spec[0];
                        if (arr[3] == 0)
                            textBox2.Text = t;
                        else if (arr[3] == 5)
                            textBox2.Text = t + " " + spec[1];
                        else
                            textBox2.Text = t + " " + So[arr[3]];
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Task3_Load(object sender, EventArgs e)
        {

        }
    }
}
