namespace HMee_UDP
{
    partial class Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_ip = new TextBox();
            tb_port = new TextBox();
            tb_main = new TextBox();
            tb_mess = new TextBox();
            bt_send = new Button();
            btExit = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(643, 172);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 0;
            label1.Text = "IP Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(643, 283);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 383);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 2;
            label3.Text = "Message";
            // 
            // tb_ip
            // 
            tb_ip.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_ip.Location = new Point(645, 218);
            tb_ip.Name = "tb_ip";
            tb_ip.Size = new Size(189, 35);
            tb_ip.TabIndex = 3;
            // 
            // tb_port
            // 
            tb_port.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_port.Location = new Point(645, 330);
            tb_port.Name = "tb_port";
            tb_port.Size = new Size(189, 35);
            tb_port.TabIndex = 4;
            // 
            // tb_main
            // 
            tb_main.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_main.Location = new Point(35, 65);
            tb_main.Multiline = true;
            tb_main.Name = "tb_main";
            tb_main.Size = new Size(514, 296);
            tb_main.TabIndex = 6;
            tb_main.KeyPress += tb_main_KeyPress;
            // 
            // tb_mess
            // 
            tb_mess.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_mess.Location = new Point(35, 432);
            tb_mess.Multiline = true;
            tb_mess.Name = "tb_mess";
            tb_mess.Size = new Size(514, 64);
            tb_mess.TabIndex = 7;
            // 
            // bt_send
            // 
            bt_send.BackColor = Color.PaleTurquoise;
            bt_send.FlatStyle = FlatStyle.Popup;
            bt_send.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_send.Location = new Point(450, 432);
            bt_send.Name = "bt_send";
            bt_send.Size = new Size(99, 64);
            bt_send.TabIndex = 8;
            bt_send.Text = "Send";
            bt_send.UseVisualStyleBackColor = false;
            bt_send.Click += bt_send_Click;
            // 
            // btExit
            // 
            btExit.BackColor = Color.MistyRose;
            btExit.FlatStyle = FlatStyle.Popup;
            btExit.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(657, 65);
            btExit.Name = "btExit";
            btExit.Size = new Size(151, 51);
            btExit.TabIndex = 9;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(301, 19);
            label4.Name = "label4";
            label4.Size = new Size(315, 32);
            label4.TabIndex = 10;
            label4.Text = "Đặng Đức Tài - 22521270";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(909, 534);
            Controls.Add(label4);
            Controls.Add(btExit);
            Controls.Add(bt_send);
            Controls.Add(tb_mess);
            Controls.Add(tb_main);
            Controls.Add(tb_port);
            Controls.Add(tb_ip);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Cross;
            Name = "Client";
            Text = "Client";
            Load += Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_ip;
        private TextBox tb_port;
        private TextBox tb_main;
        private TextBox tb_mess;
        private Button bt_send;
        private Button btExit;
        private Label label4;
    }
}
