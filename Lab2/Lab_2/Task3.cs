using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System;
using System.IO;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Task3 : Form
    {
        public Task3()
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


        private void btnWrite_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Không có nội dung để ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string output = saveFileDialog.FileName;

                // Đọc nội dung từ file input.txt
                string[] lines = richTextBox1.Lines;

                try
                {
                    using (StreamWriter sw = new StreamWriter(output))
                    {
                        foreach (string line in lines)
                        {
                            // Thực hiện phép tính trên mỗi dòng và ghi vào file
                            string result = Calculate(line);
                            sw.WriteLine(result);
                        }
                    }

                    MessageBox.Show($"Đã xử lý và ghi kết quả vào file {output}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể xử lý và ghi kết quả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string Calculate(string expression)
        {
            // Loại bỏ tất cả các ký tự không phải là số hoặc phép tính
            string sanitizedExpression = new string(expression.Where(c => char.IsDigit(c) || "+-*/".Contains(c)).ToArray());

            // Tách toán hạng và phép tính
            string[] parts = sanitizedExpression.Split(new[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);

            // Kiểm tra nếu không có đúng 2 toán hạng và 1 phép tính
            if (parts.Length != 2)
            {
                return $"{expression} => Lỗi: Chuỗi đầu vào không hợp lệ!";
            }

            double operand1, operand2;
            if (!double.TryParse(parts[0], out operand1) || !double.TryParse(parts[1], out operand2))
            {
                return $"{expression} => Lỗi: Chuỗi đầu vào không hợp lệ!";
            }

            char operation = sanitizedExpression[parts[0].Length];

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                case '*':
                    result = operand1 * operand2;
                    break;
                case '/':
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                    }
                    else
                    {
                        return $"{expression} => Lỗi: Phép chia cho 0!";
                    }
                    break;
                default:
                    return $" {expression} => Lỗi: Phép toán không hợp lệ!";
            }

            // Format kết quả và trả về
            string calculationResult = $"{operand1} {operation} {operand2} = {result}";

            return calculationResult;
        }




    }
}
