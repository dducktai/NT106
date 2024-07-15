namespace UDP_Server
{
    partial class Server
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
            rtb_main = new TextBox();
            rbt_send = new Button();
            bt_exit = new Button();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // rtb_main
            // 
            rtb_main.Location = new Point(25, 111);
            rtb_main.Margin = new Padding(3, 2, 3, 2);
            rtb_main.Multiline = true;
            rtb_main.Name = "rtb_main";
            rtb_main.Size = new Size(565, 238);
            rtb_main.TabIndex = 15;
            rtb_main.KeyPress += rtb_main_KeyPress;
            // 
            // rbt_send
            // 
            rbt_send.BackColor = Color.Aquamarine;
            rbt_send.FlatStyle = FlatStyle.Popup;
            rbt_send.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbt_send.Location = new Point(637, 150);
            rbt_send.Margin = new Padding(3, 2, 3, 2);
            rbt_send.Name = "rbt_send";
            rbt_send.Size = new Size(166, 41);
            rbt_send.TabIndex = 17;
            rbt_send.Text = "Listen";
            rbt_send.UseVisualStyleBackColor = false;
            rbt_send.Click += rbt_send_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.MistyRose;
            bt_exit.FlatStyle = FlatStyle.Popup;
            bt_exit.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_exit.Location = new Point(637, 246);
            bt_exit.Margin = new Padding(3, 2, 3, 2);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(166, 41);
            bt_exit.TabIndex = 18;
            bt_exit.Text = "Exit";
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 76);
            label1.Name = "label1";
            label1.Size = new Size(235, 26);
            label1.TabIndex = 19;
            label1.Text = "IP address: 127.0.10.1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(256, 9);
            label4.Name = "label4";
            label4.Size = new Size(315, 32);
            label4.TabIndex = 20;
            label4.Text = "Đặng Đức Tài - 22521270";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(336, 76);
            label2.Name = "label2";
            label2.Size = new Size(120, 26);
            label2.TabIndex = 21;
            label2.Text = "Port: 8080";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(832, 360);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(bt_exit);
            Controls.Add(rbt_send);
            Controls.Add(rtb_main);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Server";
            Text = "Server";
            Load += Server_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox rtb_main;
        private Button rbt_send;
        private Button bt_exit;
        private Label label1;
        private Label label4;
        private Label label2;
    }
}
