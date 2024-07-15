using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebase_Project
{
    class MyUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Fullname { get; set; }
        public string PhoneNumber { get; set; }

        private static string error1 = "Tài khoản không tồn tại!";
        private static string error2 = "Cảnh báo";

        public static void ShowError()
        {

            System.Windows.Forms.MessageBox.Show(error1, error2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError_2()
        {
            System.Windows.Forms.MessageBox.Show("Tài khoản đã tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool IsEqual(MyUser user1, MyUser user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.Username != user2.Username)
            {
                error1 = "Tài khoản không tồn tại!";
                return false;
            }


            else if (user1.Password != user2.Password)
            {
                error1 = "Sai tài khoản hoặc mật khẩu!";
                return false;
            }

            else if (user2.Username != "22521385")
            {
                error1 = "Không phải tài khoản Admin!";
                return false;

            }

            return true;
        }


        public static bool Search(MyUser user1, MyUser user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.Username != user2.Username)
            {
                System.Windows.Forms.MessageBox.Show("Tài khoản không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
