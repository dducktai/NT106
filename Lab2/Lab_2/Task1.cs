using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt; *.docx; *.csv; *.doc)|*.txt;*.docx;*.csv; *.doc|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    // Kiểm tra loại tệp đã chọn
                    string extension = Path.GetExtension(filePath).ToLower();
                    string[] NotAllow = { ".zip", ".jpg", ".png", ".pdf", ".rar", ".sln" }; // Thêm các phần mở rộng khác nếu cần
                    if (NotAllow.Contains(extension))
                    {
                        MessageBox.Show("Không phải là file văn bản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string content = File.ReadAllText(filePath);
                        richTextBox1.Text = content;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Không thể mở File Explorer ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnWrite_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Không có nội dung để ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        string content = richTextBox1.Text.ToUpper(); // Chuyển đổi thành chữ in hoa
                        sw.Write(content);
                    }
                    MessageBox.Show($"Đã xử lý và ghi kết quả vào file {sfd.FileName}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể xử lý và ghi kết quả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Không thể mở File Explorer ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
