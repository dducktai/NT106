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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiem.Clear();
            flowLayoutPanel1.Controls.Clear();
            txtDTB.Clear();
            txtHocLuc.Clear();
            txtMax.Clear();
            txtMin.Clear();
            txtPass.Clear();
            txtFail.Clear();
        }

        private bool IsValidInput(string input)
        {
            // Tách chuỗi input thành các phần tử dựa trên khoảng trắng và dấu "-"
            string[] parts = input.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                // Kiểm tra xem phần tử có phải là số và có giá trị từ 0 đến 10 không
                if (!double.TryParse(part, out double number) || number < 0 || number > 10)
                {
                    return false;
                }

                // Kiểm tra xem phần tử có chứa dấu phẩy là "," không
                if (part.Contains(","))
                {
                    return false; // Trả về false nếu có dấu phẩy
                }
            }

            return true;

        }

        static string XoaKhoangTrang(string input)
        {
            // Chuỗi kết quả
            StringBuilder result = new StringBuilder();

            // Biến lưu trạng thái của ký tự trước đó
            bool previousIsSpace = false;

            // Duyệt qua từng ký tự trong chuỗi input
            foreach (char c in input)
            {
                // Nếu ký tự hiện tại không phải là khoảng trắng hoặc ký tự trước đó không phải là khoảng trắng
                if (c != ' ' || !previousIsSpace)
                {
                    // Thêm ký tự vào chuỗi kết quả
                    result.Append(c);
                }

                // Cập nhật trạng thái của ký tự trước đó
                previousIsSpace = (c == ' ');
            }

            // Trả về chuỗi kết quả
            return result.ToString();

        }

        private void xuly(string input)
        {

            // Tách và chuyển đổi chuỗi nhập vào thành mảng điểm
            double[] grades = input.Split(' ').Select(double.Parse).ToArray();

            // Xuất danh sách điểm
            for (int i = 0; i < grades.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(109, 109); // Thiết lập kích thước là 100x30
                btn.BackColor = Color.LightBlue; // Thiết lập màu sắc là light blue
                btn.Text = $"Môn {i + 1} {grades[i]}đ";
                flowLayoutPanel1.Controls.Add(btn);
            }


            // Tính điểm trung bình
            double averageGrade = grades.Average();
            string dtb = averageGrade.ToString();
            txtDTB.Text = dtb;

            // Tìm môn có điểm cao nhất và thấp nhất
            string maxGrade = grades.Max().ToString();
            string minGrade = grades.Min().ToString();
            txtMax.Text = maxGrade;
            txtMin.Text = minGrade;

            // Đếm số môn đậu và không đậu
            string passedSubjects = grades.Count(g => g >= 5).ToString();
            string failedSubjects = grades.Count(g => g < 5).ToString();
            txtPass.Text = passedSubjects;
            txtFail.Text = failedSubjects;

            // Xếp loại sinh viên
            string studentRank;
            if (averageGrade >= 8 && !grades.Any(g => g < 6.5))
            {
                studentRank = "Giỏi";
            }
            else if (averageGrade >= 6.5 && !grades.Any(g => g < 5))
            {
                studentRank = "Khá";
            }
            else if (averageGrade >= 5 && !grades.Any(g => g < 3.5))
            {
                studentRank = "Trung bình";
            }
            else
            {
                studentRank = "Yếu";
            }
            txtHocLuc.Text = studentRank;
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            string input = txtDiem.Text.Trim(); ;
            input = XoaKhoangTrang(input);
            //Kiểm tra tính hợp lệ của đầu vào
            if (!IsValidInput(input))
            {

                MessageBox.Show("Đầu vào không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            xuly(input);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Task5_Load(object sender, EventArgs e)
        {

        }
    }
}
