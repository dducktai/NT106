using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Task4_Load(object sender, EventArgs e)
        {

        }
        private bool IsValid()
        {
            return float.TryParse(txtMath.Text, out _)
                && float.TryParse(txtLiterature.Text, out _)
                && int.TryParse(txtPhone.Text, out _)
                && int.TryParse(txtID.Text, out _)
                && txtPhone.Text != ""
                && txtName.Text != ""
                && txtID.Text != "";
        }

        private void ClearAll()
        {
            txtMath.Text = "";
            txtLiterature.Text = "";
            txtPhone.Text = "";
            txtName.Text = "";
            txtID.Text = "";
        }

        List<Student> dssv = new List<Student>();

        private void txtMath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Student sv = new Student();
                sv.ID = txtID.Text;
                sv.Name = txtName.Text;
                sv.Phone = txtPhone.Text;
                sv.Math = float.Parse(txtMath.Text);
                sv.Literature = float.Parse(txtLiterature.Text);
                sv.Average = (sv.Math + sv.Literature) / 2;
                if (sv.Phone[0] != '0' && sv.Phone.Length > 0)
                {
                    throw new Exception("Vui lòng nhập đúng định dạng của số điện thoại!");
                }
                if (sv.Phone.Length != 10 || !sv.Phone.All(char.IsDigit))
                {
                    throw new Exception("Vui lòng nhập số điện thoại có 10 chữ số.");
                }
                if (sv.Math > 10 || sv.Math < 0)
                {
                    throw new Exception("Điểm toán không hợp lệ. Vui lòng nhập điểm từ 0 đến 10.");
                }
                if (sv.Literature > 10 || sv.Literature < 0)
                {
                    throw new Exception("Điểm văn không hợp lệ. Vui lòng nhập điểm từ 0 đến 10.");
                }
                dssv.Add(sv);
                txtID.Clear();
                txtName.Clear();
                txtPhone.Clear();
                txtLiterature.Clear();
                txtMath.Clear();
                ShowStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ShowStudents()
        {
            lwShow.Items.Clear();
            foreach (Student sv in dssv)
            {
                ListViewItem item = new ListViewItem(sv.ID);
                item.SubItems.Add(sv.Name);
                item.SubItems.Add(sv.Phone);
                item.SubItems.Add(sv.Math.ToString());
                item.SubItems.Add(sv.Literature.ToString());
                item.SubItems.Add(sv.Average.ToString());
                lwShow.Items.Add(item);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lwShow.Items.Clear();
            ClearAll();
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtID.Enabled = false;
            txtMath.Enabled = false;
            txtLiterature.Enabled = false;
            btnRead.Enabled = false;
            btnAdd.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            dssv = FileFactory.docFile(ofd.FileName);
            ShowStudents();
            txtAddress.Text = ofd.FileName;
            MessageBox.Show("Đọc file thành công!");
        }

        private void txtAddressRead_TextChanged(object sender, EventArgs e)
        {

        }

        private bool MustBeNum(char num)
        {
            return char.IsDigit(num) || num == '.';
        }
        private bool MustBeLetter(char letter)
        {
            return char.IsLetter(letter) || char.IsWhiteSpace(letter);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in txtName.Text)
            {
                if (!MustBeLetter(item))
                {
                    MessageBox.Show("Sai định dạng, vui lòng nhập lại",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = "";
                    return;
                }
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = txtPhone.Text;

            // Kiểm tra xem ô nhập liệu có rỗng không
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return; // Không làm gì nếu ô nhập liệu rỗng
            }



            // Kiểm tra xem tất cả các ký tự có phải là chữ số không
            if (!phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa các chữ số từ 0 đến 9!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem chuỗi có bắt đầu bằng số 0 không
            if (phoneNumber[0] != '0')
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtLiterature_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in txtLiterature.Text)
            {
                float num = float.Parse(txtLiterature.Text);
                if (!MustBeNum(item) || num < 0 || num > 10)
                {
                    MessageBox.Show("Giá trị không hợp lệ, vui lòng nhập lại",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLiterature.Text = "";
                    return;
                }
            }
        }

        private void txtMath_TextChanged_1(object sender, EventArgs e)
        {
            foreach (char item in txtMath.Text)
            {
                float num = float.Parse(txtMath.Text);
                if (!MustBeNum(item) || num < 0 || num > 10)
                {
                    MessageBox.Show("Giá trị không hợp lệ, vui lòng nhập lại",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMath.Text = "";
                    return;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                bool check = FileFactory.luuFile(dssv, path);
                if (check == true)
                {
                    lwShow.Items.Clear();
                    MessageBox.Show("Lưu file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
