using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.SafeFileName;
                string filePath = openFileDialog.FileName;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = reader.ReadToEnd();

                    // Tính số dòng
                    int lineCount = content.Split('\n').Length;

                    // Tính số từ
                    int wordCount = content.Split(new char[] { ' ', '\n', '\r' , '.', '?', '!', ':', ';', ','}, StringSplitOptions.RemoveEmptyEntries).Length;

                    // Tính số ký tự
                    int charCount = content.Length;


                    // Hiển thị thông tin
                    richTextBox1.Text = content;
                    txbTenFile.Text = fileName;
                    txbURL.Text = filePath;
                    txbSoDong.Text = lineCount.ToString();
                    txbSoTu.Text = wordCount.ToString();
                    txbSoKyTu.Text = charCount.ToString();
                }
            }
            else
                MessageBox.Show("Không thể mở File Explorer ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            txbTenFile.Clear();
            txbURL.Clear();
            txbSoDong.Clear();
            txbSoTu.Clear();
            txbSoKyTu.Clear();
        }
    }
}
