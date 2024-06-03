using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Lab5
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
            InitializeListView();
        }

        public class EmailInfo
        {
            public string From { get; set; }
            public DateTimeOffset TimeReceive { get; set; }
            public string Subject { get; set; }
        }

        public static class Constants
        {
            public static string EMAIL { get; set; }
            public static string PASSWORD { get; set; }
            public const string FOLDER_READ = "Inbox";

            public static void SetCredentials(string email, string password)
            {
                EMAIL = email.Trim();
                PASSWORD = password.Trim();
            }
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("From", 150);
            listView1.Columns.Add("Time Received", 150);
            listView1.Columns.Add("Subject", 300);
        }
        private bool CheckRequiredFields()
        {
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Please enter the sender's email username.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please enter the sender's email password.");
                return false;
            }

 

            return true; // Tất cả các kiểm tra đều đã vượt qua
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc trước khi gửi
            if (!CheckRequiredFields())
            {
                return; // Nếu kiểm tra không vượt qua, ngăn chặn việc gửi email
            }
            Constants.SetCredentials(tbUsername.Text, tbPassword.Text);

            var listEmail = new List<EmailInfo>();
            var mailClient = new ImapClient();
            try
            {
                mailClient.Connect("127.0.0.1", 143, MailKit.Security.SecureSocketOptions.None);
                mailClient.Authenticate(Constants.EMAIL, Constants.PASSWORD);
                var folder = await mailClient.GetFolderAsync(Constants.FOLDER_READ);
                await folder.OpenAsync(FolderAccess.ReadWrite);

                IList<UniqueId> uids = folder.Search(SearchQuery.All);
                foreach (UniqueId uid in uids)
                {
                    MimeMessage message = folder.GetMessage(uid);
                    var emailInfo = new EmailInfo
                    {
                        From = message.From.ToString(),
                        TimeReceive = message.Date,
                        Subject = message.Subject
                    };

                    var fileAttactment = new List<string>();
                    foreach (MimeEntity attachment in message.Attachments)
                    {
                        var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;
                        fileAttactment.Add(fileName);

                        using (var stream = File.Create(fileName))
                        {
                            if (attachment is MessagePart rfc822)
                            {
                                rfc822.Message.WriteTo(stream);
                            }
                            else if (attachment is MimePart part)
                            {
                                part.Content.DecodeTo(stream);
                            }
                        }
                    }
                    listEmail.Add(emailInfo);
                }

                listView1.Items.Clear();
                foreach (var email in listEmail)
                {
                    var item = new ListViewItem(new[]
                    {
                        email.From,
                        email.TimeReceive.ToString(),
                        email.Subject
                    });
                    listView1.Items.Add(item);
                }

                lbTotal.Text = $"{listEmail.Count}";
                var recentEmails = listEmail.Count(email => email.TimeReceive.Date == DateTimeOffset.Now.Date);
                lbRecent.Text = $"{recentEmails}";

                mailClient.Disconnect(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
