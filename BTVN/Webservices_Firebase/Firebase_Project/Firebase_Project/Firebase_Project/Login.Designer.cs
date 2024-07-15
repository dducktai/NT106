namespace Firebase_Project
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            lbUsername = new Label();
            lbPassword = new Label();
            txbUsername = new TextBox();
            txbPassword = new TextBox();
            btnResgitration = new Button();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(38, 217);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(128, 32);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(38, 326);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(122, 32);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(38, 252);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(698, 39);
            txbUsername.TabIndex = 2;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(38, 361);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(698, 39);
            txbPassword.TabIndex = 3;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // btnResgitration
            // 
            btnResgitration.BackColor = Color.SteelBlue;
            btnResgitration.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResgitration.ForeColor = Color.White;
            btnResgitration.Location = new Point(167, 441);
            btnResgitration.Name = "btnResgitration";
            btnResgitration.Size = new Size(194, 55);
            btnResgitration.TabIndex = 4;
            btnResgitration.Text = "Resgistration";
            btnResgitration.UseVisualStyleBackColor = false;
            btnResgitration.Click += btnResgitration_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(398, 441);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(194, 55);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(115, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(525, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 536);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(btnResgitration);
            Controls.Add(txbPassword);
            Controls.Add(txbUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += formLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private Label lbPassword;
        private TextBox txbUsername;
        private TextBox txbPassword;
        private Button btnResgitration;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}
