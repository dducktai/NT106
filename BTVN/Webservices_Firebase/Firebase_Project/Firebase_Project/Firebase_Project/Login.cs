using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace Firebase_Project
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "LFIIbw14NnUfvIiDoY02P9fWpRQSxd8gONlnBPAd",
            BasePath = "https://fir-ltmcb-default-rtdb.firebaseio.com/"
        };


        IFirebaseClient client;

        private void formLogin_Load(object sender, EventArgs e)
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUsername.Text) ||
               string.IsNullOrWhiteSpace(txbPassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FirebaseResponse res = client.Get(@"Users/" + txbUsername.Text);
            MyUser ResUser = res.ResultAs<MyUser>();

            MyUser CurUser = new MyUser()
            {
                Username = txbUsername.Text,
                Password = txbPassword.Text,
                
            };

            if (MyUser.IsEqual(ResUser, CurUser) == true)
            {
                formMainApp real = new formMainApp(ResUser.Fullname);
                this.Hide();
                real.ShowDialog();
                this.ShowDialog();

            }
            else
            {
                MyUser.ShowError();
            }


        }

        private void btnResgitration_Click(object sender, EventArgs e)
        {
            formRegistration reg = new formRegistration();
            this.Hide();
            reg.ShowDialog();
            this.ShowDialog();
        }



    }
}
