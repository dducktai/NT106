namespace Firebase_Project
{
    partial class formRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistration));
            lbUsername = new Label();
            pictureBox1 = new PictureBox();
            lbPassword = new Label();
            lbGender = new Label();
            lbFullname = new Label();
            lbPhonenumber = new Label();
            txbUsrname = new TextBox();
            txbPass = new TextBox();
            txbFullname = new TextBox();
            txbPhone = new TextBox();
            btnReg = new Button();
            cbGender = new ComboBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(45, 252);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(135, 32);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(525, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(45, 351);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(129, 32);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Password:";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGender.Location = new Point(45, 451);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(105, 32);
            lbGender.TabIndex = 9;
            lbGender.Text = "Gender:";
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFullname.Location = new Point(45, 560);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(125, 32);
            lbFullname.TabIndex = 10;
            lbFullname.Text = "Fullname:";
            // 
            // lbPhonenumber
            // 
            lbPhonenumber.AutoSize = true;
            lbPhonenumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhonenumber.Location = new Point(45, 664);
            lbPhonenumber.Name = "lbPhonenumber";
            lbPhonenumber.Size = new Size(195, 32);
            lbPhonenumber.TabIndex = 11;
            lbPhonenumber.Text = "Phone Number:";
            // 
            // txbUsrname
            // 
            txbUsrname.Location = new Point(45, 287);
            txbUsrname.Name = "txbUsrname";
            txbUsrname.Size = new Size(698, 39);
            txbUsrname.TabIndex = 12;
            // 
            // txbPass
            // 
            txbPass.Location = new Point(45, 386);
            txbPass.Name = "txbPass";
            txbPass.Size = new Size(698, 39);
            txbPass.TabIndex = 13;
            txbPass.UseSystemPasswordChar = true;
            // 
            // txbFullname
            // 
            txbFullname.Location = new Point(45, 595);
            txbFullname.Name = "txbFullname";
            txbFullname.Size = new Size(698, 39);
            txbFullname.TabIndex = 15;
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(45, 699);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(698, 39);
            txbPhone.TabIndex = 16;
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.SteelBlue;
            btnReg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReg.ForeColor = Color.White;
            btnReg.Location = new Point(291, 773);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(194, 55);
            btnReg.TabIndex = 19;
            btnReg.Text = "Register";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FlatStyle = FlatStyle.Popup;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(51, 486);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(692, 40);
            cbGender.TabIndex = 21;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SteelBlue;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 55);
            btnBack.TabIndex = 22;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // formRegistration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 864);
            Controls.Add(btnBack);
            Controls.Add(cbGender);
            Controls.Add(btnReg);
            Controls.Add(txbPhone);
            Controls.Add(txbFullname);
            Controls.Add(txbPass);
            Controls.Add(txbUsrname);
            Controls.Add(lbPhonenumber);
            Controls.Add(lbFullname);
            Controls.Add(lbGender);
            Controls.Add(lbPassword);
            Controls.Add(pictureBox1);
            Controls.Add(lbUsername);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "formRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += formRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private PictureBox pictureBox1;
        private Label lbPassword;
        private Label lbGender;
        private Label lbFullname;
        private Label lbPhonenumber;
        private TextBox txbUsrname;
        private TextBox txbPass;
        private TextBox txbFullname;
        private TextBox txbPhone;
        private Button btnReg;
        private ComboBox cbGender;
        private Button btnBack;
    }
}