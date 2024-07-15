using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Firebase_Project
{
    public partial class formMainApp : Form
    {
        public string Username;

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "LFIIbw14NnUfvIiDoY02P9fWpRQSxd8gONlnBPAd",
            BasePath = "https://fir-ltmcb-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public formMainApp(string username)
        {
            InitializeComponent();
            this.Username = username;
        }

        private void formMainApp_Load(object sender, EventArgs e)
        {
            label1.Text = $"Wellcome back {Username}!";
            client = new FireSharp.FirebaseClient(ifc);
            viewData();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;



        }

        void viewData()
        {
            // bonus get all data to gridview
            var data = client.Get(@"/Users");
            var mList = JsonConvert.DeserializeObject<IDictionary<string, MyUser>>(data.Body);
            var listNumber = mList.Values.ToList();
            dataGridView1.DataSource = listNumber;
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            viewData();
            MessageBox.Show("Đã cập nhật dữ liệu", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUsrname.Text) ||
               string.IsNullOrWhiteSpace(txbPass.Text) ||
               string.IsNullOrWhiteSpace(cbGender.Text) ||
               string.IsNullOrWhiteSpace(txbFullname.Text) ||
               string.IsNullOrWhiteSpace(txbPhone.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = client.Get(@"Users/" + txbUsrname.Text);

            MyUser ResUser = res.ResultAs<MyUser>();

            MyUser CurUser = new MyUser()
            {
                Username = txbUsrname.Text
            };

            if (MyUser.Search(ResUser, CurUser))
            {
                MyUser.ShowError_2();
                return;
            }


            MyUser user = new MyUser()
            {
                Username = txbUsrname.Text,
                Password = txbPass.Text,
                Gender = cbGender.Text,
                Fullname = txbFullname.Text,
                PhoneNumber = txbPhone.Text
            };

            SetResponse set = client.Set(@"Users/" + txbUsrname.Text, user);

            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Thêm thành công tài khoản {txbUsrname.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbUsrname.Clear();
                txbPass.Clear();
                cbGender.SelectedIndex = -1;
                txbFullname.Clear();
                txbPhone.Clear();
            }
            viewData();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUsrname.Text) &&
                 string.IsNullOrWhiteSpace(txbPass.Text) &&
                 string.IsNullOrWhiteSpace(cbGender.Text) &&
                 string.IsNullOrWhiteSpace(txbFullname.Text) &&
                 string.IsNullOrWhiteSpace(txbPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá tài khoản này?", "Xác nhận xoá", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

                MyUser user = new MyUser()
                {
                    Username = txbUsrname.Text,
                    Password = txbPass.Text,
                    Gender = cbGender.Text,
                    Fullname = txbFullname.Text,
                    PhoneNumber = txbPhone.Text
                };

                var delete = client.Delete(@"Users/" + txbSearch.Text);
                if (delete.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Xoá tài khoản {txbSearch.Text} thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbUsrname.Clear();
                    txbPass.Clear();
                    cbGender.SelectedIndex = -1;
                    txbFullname.Clear();
                    txbPhone.Clear();
                    txbSearch.Clear();
                    txbUsrname.ReadOnly = false;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnInsert.Enabled = true;
                }
            }
            else
            {
                return;
            }
            viewData();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbSearch.Text))
            {
                MessageBox.Show("Vui lòng điền tên tài khoản để tìm kiếm", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FirebaseResponse res = client.Get(@"Users/" + txbSearch.Text);

            MyUser ResUser = res.ResultAs<MyUser>();

            MyUser CurUser = new MyUser()
            {
                Username = txbSearch.Text
            };

            if (MyUser.Search(ResUser, CurUser))
            {
                txbUsrname.Text = txbSearch.Text;
                txbFullname.Text = ResUser.Fullname;
                txbPass.Text = ResUser.Password;
                txbPhone.Text = ResUser.PhoneNumber;
                cbGender.Text = ResUser.Gender;
                btnInsert.Enabled = false;
                txbUsrname.ReadOnly = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;


            }

            else
            {
                MyUser.ShowError();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUsrname.Text) &&
                 string.IsNullOrWhiteSpace(txbPass.Text) &&
                 string.IsNullOrWhiteSpace(cbGender.Text) &&
                 string.IsNullOrWhiteSpace(txbFullname.Text) &&
                 string.IsNullOrWhiteSpace(txbPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MyUser user = new MyUser()
            {
                Username = txbUsrname.Text,
                Password = txbPass.Text,
                Gender = cbGender.Text,
                Fullname = txbFullname.Text,
                PhoneNumber = txbPhone.Text
            };

            var update = client.Update(@"Users/" + txbUsrname.Text, user);

            if (update.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Cập nhật thông tin tài khoản {txbUsrname.Text} thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txbUsrname.Clear();
                //txbPass.Clear();
                //cbGender.SelectedIndex = -1;
                //txbFullname.Clear();
                //txbPhone.Clear();

            }
            viewData();
        }

        private void formMainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true; // Ngăn chặn sự kiện đóng form
            }
            else
            {
                // Thực hiện các thao tác xóa dữ liệu hoặc đóng các tài nguyên
                txbUsrname.Clear();
                txbPass.Clear();
                cbGender.SelectedIndex = -1;
                txbFullname.Clear();
                txbPhone.Clear();
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
            txbUsrname.Clear();
            txbPass.Clear();
            cbGender.SelectedIndex = -1;
            txbFullname.Clear();
            txbPhone.Clear();
            btnInsert.Enabled = true;
            txbUsrname.ReadOnly = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            txbSearch.Clear();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            Close();

        }
    }
}
