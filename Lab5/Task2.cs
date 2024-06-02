using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;

namespace Lab5
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }


        public class EmailInfo
        {
            public string Id { get; set; }
            public string From { get; set; }
            public DateTimeOffset TimeReceive { get; set; }
            public string Subject { get; set; }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            var listEmail = new List<EmailInfo>();
            var mailClient = new ImapClient();
            try
            {
                mailClient.Connect("imap.ducktai.mail", 993, true);
                mailClient.Authenticate(tbUsername.Text, tbPassword.Text);

                var inbox = mailClient.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                IList<UniqueId> uids = inbox.Search(SearchQuery.All);
                foreach (UniqueId uid in uids)
                {
                    var message = inbox.GetMessage(uid);
                    var emailInfo = new EmailInfo
                    {
                        Id = uid.ToString(),
                        From = message.From.ToString(),
                        TimeReceive = message.Date,
                        Subject = message.Subject
                    };
                    listEmail.Add(emailInfo);
                }

                listMail.Items.Clear();
                foreach (var email in listEmail)
                {
                    var item = new ListViewItem(new[] {
                        email.TimeReceive.ToString(),
                        email.Subject,
                        email.From.ToString()
                    });
                    listMail.Items.Add(item);
                }

                mailClient.Disconnect(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
