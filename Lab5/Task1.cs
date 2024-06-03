using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }
        private bool CheckRequiredFields()
        {
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(tbFrom.Text))
            {
                MessageBox.Show("Please enter the sender's email address.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please enter the sender's email password.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbTo.Text))
            {
                MessageBox.Show("Please enter the recipient's email address.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbSubject.Text))
            {
                MessageBox.Show("Please enter the email subject.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbBody.Text))
            {
                MessageBox.Show("Please enter the email body.");
                return false;
            }

            return true; // Tất cả các kiểm tra đều đã vượt qua
        }
        private void btnSend_Click(object sender, EventArgs e)
        {

            // Kiểm tra các trường bắt buộc trước khi gửi
            if (!CheckRequiredFields())
            {
                return; // Nếu kiểm tra không vượt qua, ngăn chặn việc gửi email
            }
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = tbFrom.Text.ToString().Trim();
                string mailto = tbTo.Text.ToString().Trim();
                string password = tbPassword.Text.ToString().Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = tbSubject.Text.ToString().Trim();
                    // Set IsBodyHtml to true means you can send HTML email.
                    message.IsBodyHtml = true;
                    message.Body = tbBody.Text.ToString();
                    message.To.Add(mailto);
                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Đã gửi mail thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
