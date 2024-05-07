namespace Lab3
{
    partial class Task4_Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxUserName = new TextBox();
            lbName = new Label();
            lbMessage = new Label();
            tbMes = new TextBox();
            btnConnect = new Button();
            btnDisconect = new Button();
            btnSend = new Button();
            lvMess = new ListView();
            columnHeader1 = new ColumnHeader();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(35, 466);
            textBoxUserName.Margin = new Padding(5);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(310, 39);
            textBoxUserName.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(35, 429);
            lbName.Name = "lbName";
            lbName.Size = new Size(121, 32);
            lbName.TabIndex = 4;
            lbName.Text = "Username";
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Location = new Point(35, 536);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(108, 32);
            lbMessage.TabIndex = 5;
            lbMessage.Text = "Message";
            // 
            // tbMes
            // 
            tbMes.Location = new Point(35, 573);
            tbMes.Margin = new Padding(5);
            tbMes.Multiline = true;
            tbMes.Name = "tbMes";
            tbMes.Size = new Size(980, 118);
            tbMes.TabIndex = 6;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(366, 462);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(150, 46);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconect
            // 
            btnDisconect.Location = new Point(522, 462);
            btnDisconect.Name = "btnDisconect";
            btnDisconect.Size = new Size(150, 46);
            btnDisconect.TabIndex = 8;
            btnDisconect.Text = "Disconnect";
            btnDisconect.UseVisualStyleBackColor = true;
            btnDisconect.Click += btnDisconect_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(1036, 577);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(110, 114);
            btnSend.TabIndex = 9;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lvMess
            // 
            lvMess.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvMess.HeaderStyle = ColumnHeaderStyle.None;
            lvMess.Location = new Point(35, 47);
            lvMess.Margin = new Padding(4);
            lvMess.Name = "lvMess";
            lvMess.Size = new Size(1111, 378);
            lvMess.TabIndex = 10;
            lvMess.UseCompatibleStateImageBehavior = false;
            lvMess.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 1000;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(678, 462);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 46);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Task4_Client
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 737);
            Controls.Add(btnRefresh);
            Controls.Add(lvMess);
            Controls.Add(btnSend);
            Controls.Add(btnDisconect);
            Controls.Add(btnConnect);
            Controls.Add(tbMes);
            Controls.Add(lbMessage);
            Controls.Add(lbName);
            Controls.Add(textBoxUserName);
            Name = "Task4_Client";
            Text = "Task4_Client";
            FormClosing += Task4_Client_FormClosing;
            Load += Task4_Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUserName;
        private Label lbName;
        private Label lbMessage;
        private TextBox tbMes;
        private Button btnConnect;
        private Button btnDisconect;
        private Button btnSend;
        private ListView lvMess;
        private Button btnRefresh;
        private ColumnHeader columnHeader1;
    }
}