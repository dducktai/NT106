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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5
{
    public partial class Task3 : Form
    {
        public Task3()
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

        private bool CheckAttachments(string[] filePaths)
        {
            // Kiểm tra sự tồn tại của tất cả các tệp đính kèm
            foreach (string filePath in filePaths)
            {
                if (!System.IO.File.Exists(filePath))
                {
                    MessageBox.Show("File not found: " + filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Nếu bất kỳ tệp nào không tồn tại, trả về false
                }
            }
            return true; // Tất cả các tệp đều tồn tại
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc trước khi gửi
            if (!CheckRequiredFields())
            {
                return; // Nếu kiểm tra không vượt qua, ngăn chặn việc gửi email
            }

            // Kiểm tra sự tồn tại của tệp đính kèm
            string[] filePaths = rtbFile.Text.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (!CheckAttachments(filePaths))
            {
                return; // Nếu bất kỳ tệp nào không tồn tại, ngăn chặn việc gửi email
            }

            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)) // Gmail SMTP server address and port
            {
                string mailfrom = tbFrom.Text.ToString().Trim();
                string mailto = tbTo.Text.ToString().Trim();
                string password = tbPassword.Text.ToString().Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.EnableSsl = true; // Enable SSL for secure connection
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = tbSubject.Text.ToString().Trim();

                    // Set IsBodyHtml to true means you can send HTML email.
                    message.IsBodyHtml = true;
                    message.Body = tbBody.Text.ToString();
                    message.To.Add(mailto);

                    // Add attachments (this step is now safe because all files are checked)
                    foreach (string filePath in filePaths)
                    {
                        Attachment attachment = new Attachment(filePath);
                        message.Attachments.Add(attachment);
                    }

                    try
                    {
                        await smtpClient.SendMailAsync(message); // Sử dụng SendMailAsync để gửi email không đồng bộ
                        if (message.Attachments.Count > 0)
                        {
                            MessageBox.Show("Email sent successfully with attachments!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Email sent successfully!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to send email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnIMG_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true; // Allow multiple file selection
                openFileDialog.Filter = "All Files|*.*"; // You can customize the filter if needed

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {


                    // Display selected file paths in richTextBox2
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        rtbFile.AppendText(filePath + Environment.NewLine);

                    }
                }
            }
        }

        private void tbFrom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
