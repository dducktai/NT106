using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firebase_Project
{
    public partial class formRegistration : Form
    {
        public formRegistration()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "LFIIbw14NnUfvIiDoY02P9fWpRQSxd8gONlnBPAd",
            BasePath = "https://fir-ltmcb-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;


        private void formRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnReg_Click(object sender, EventArgs e)
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
                Fullname = txbFullname.Text,
                Gender = cbGender.Text,
                PhoneNumber = txbPhone.Text
            };

            SetResponse set = client.Set(@"Users/" + txbUsrname.Text, user);

            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Đăng ký thành công tài khoản {txbUsrname.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    MyUser user = new MyUser()
        //    {
        //        Username = txbUsrname.Text,
        //        Password = txbPass.Text,
        //        Gender = cbGender.Text,
        //        Fullname = txbFullname.Text,
        //        PhoneNumber = txbPhone.Text
        //    };

        //    var update = client.Update(@"Users/" + txbUsrname.Text, user);

        //    if (update.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        MessageBox.Show($"Cập nhật thông tin tài khoản {txbUsrname.Text} thành công!", "Chúc mừng!");
        //    }
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    MyUser user = new MyUser()
        //    {
        //        Username = txbUsrname.Text,
        //        Password = txbPass.Text,
        //        Gender = cbGender.Text,
        //        Fullname = txbFullname.Text,
        //        PhoneNumber = txbPhone.Text
        //    };

        //    var delete = client.Delete(@"Users/" + txbUsrname.Text);
        //    if (delete.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        MessageBox.Show($"Delete {txbUsrname.Text} successful!", "Information!");
        //    }
        //}




    }
}
