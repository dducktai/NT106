namespace Lab06
{
    partial class indexForm
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
            this.joinPort = new System.Windows.Forms.TextBox();
            this.joinIP = new System.Windows.Forms.TextBox();
            this.hostPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnServer = new Guna.UI2.WinForms.Guna2Button();
            this.joinUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // joinPort
            // 
            this.joinPort.BackColor = System.Drawing.SystemColors.Control;
            this.joinPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.joinPort.ForeColor = System.Drawing.Color.Black;
            this.joinPort.Location = new System.Drawing.Point(185, 449);
            this.joinPort.Margin = new System.Windows.Forms.Padding(4);
            this.joinPort.MaxLength = 5;
            this.joinPort.Name = "joinPort";
            this.joinPort.Size = new System.Drawing.Size(208, 32);
            this.joinPort.TabIndex = 2;
            this.joinPort.Text = "65536";
            this.joinPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // joinIP
            // 
            this.joinIP.BackColor = System.Drawing.SystemColors.Control;
            this.joinIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.joinIP.ForeColor = System.Drawing.Color.Black;
            this.joinIP.Location = new System.Drawing.Point(346, 393);
            this.joinIP.Margin = new System.Windows.Forms.Padding(4);
            this.joinIP.Name = "joinIP";
            this.joinIP.Size = new System.Drawing.Size(208, 32);
            this.joinIP.TabIndex = 1;
            this.joinIP.Text = "localhost";
            this.joinIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hostPort
            // 
            this.hostPort.BackColor = System.Drawing.SystemColors.Control;
            this.hostPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.hostPort.ForeColor = System.Drawing.Color.Black;
            this.hostPort.Location = new System.Drawing.Point(553, 446);
            this.hostPort.Margin = new System.Windows.Forms.Padding(4);
            this.hostPort.MaxLength = 5;
            this.hostPort.Name = "hostPort";
            this.hostPort.Size = new System.Drawing.Size(254, 32);
            this.hostPort.TabIndex = 4;
            this.hostPort.Text = "65536";
            this.hostPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(241, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(34, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "User port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(447, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Host port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UTM Avo", 25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(99, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(610, 73);
            this.label5.TabIndex = 11;
            this.label5.Text = "NUMBER MAGIC GAME";
            // 
            // btnClient
            // 
            this.btnClient.BorderRadius = 25;
            this.btnClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClient.FillColor = System.Drawing.Color.LimeGreen;
            this.btnClient.Font = new System.Drawing.Font("UTM Avo", 11F, System.Drawing.FontStyle.Bold);
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Location = new System.Drawing.Point(39, 234);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(355, 47);
            this.btnClient.TabIndex = 12;
            this.btnClient.Text = "Join a game ";
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnServer
            // 
            this.btnServer.BorderRadius = 25;
            this.btnServer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServer.FillColor = System.Drawing.Color.LimeGreen;
            this.btnServer.Font = new System.Drawing.Font("UTM Avo", 11F, System.Drawing.FontStyle.Bold);
            this.btnServer.ForeColor = System.Drawing.Color.White;
            this.btnServer.Location = new System.Drawing.Point(427, 234);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(355, 47);
            this.btnServer.TabIndex = 13;
            this.btnServer.Text = "Host a new game";
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // joinUsername
            // 
            this.joinUsername.BorderColor = System.Drawing.Color.Green;
            this.joinUsername.BorderRadius = 23;
            this.joinUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.joinUsername.DefaultText = "";
            this.joinUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.joinUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.joinUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.joinUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.joinUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.joinUsername.Font = new System.Drawing.Font("UTM Avo", 11F);
            this.joinUsername.ForeColor = System.Drawing.Color.Green;
            this.joinUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.joinUsername.Location = new System.Drawing.Point(215, 132);
            this.joinUsername.Margin = new System.Windows.Forms.Padding(6);
            this.joinUsername.Name = "joinUsername";
            this.joinUsername.PasswordChar = '\0';
            this.joinUsername.PlaceholderForeColor = System.Drawing.Color.Green;
            this.joinUsername.PlaceholderText = "Enter your username";
            this.joinUsername.SelectedText = "";
            this.joinUsername.Size = new System.Drawing.Size(375, 49);
            this.joinUsername.TabIndex = 14;
            this.joinUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // indexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(820, 322);
            this.Controls.Add(this.joinUsername);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hostPort);
            this.Controls.Add(this.joinIP);
            this.Controls.Add(this.joinPort);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "indexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox joinPort;
        private System.Windows.Forms.TextBox joinIP;
        private System.Windows.Forms.TextBox hostPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnClient;
        private Guna.UI2.WinForms.Guna2Button btnServer;
        private Guna.UI2.WinForms.Guna2TextBox joinUsername;
    }
}