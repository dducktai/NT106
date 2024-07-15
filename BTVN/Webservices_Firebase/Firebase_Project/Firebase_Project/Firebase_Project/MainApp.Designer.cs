namespace Firebase_Project
{
    partial class formMainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainApp));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            btnView = new Button();
            btnInsert = new Button();
            btnDelete = new Button();
            cbGender = new ComboBox();
            txbPhone = new TextBox();
            txbFullname = new TextBox();
            txbPass = new TextBox();
            txbUsrname = new TextBox();
            lbPhonenumber = new Label();
            lbFullname = new Label();
            lbGender = new Label();
            lbPassword = new Label();
            lbUsername = new Label();
            txbSearch = new TextBox();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnClearData = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 141);
            label1.Name = "label1";
            label1.Size = new Size(287, 50);
            label1.TabIndex = 0;
            label1.Text = "Wellcome back";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(778, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(947, 872);
            dataGridView1.TabIndex = 8;
            // 
            // btnView
            // 
            btnView.BackColor = Color.SteelBlue;
            btnView.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(28, 305);
            btnView.Name = "btnView";
            btnView.Size = new Size(238, 55);
            btnView.TabIndex = 9;
            btnView.Text = "Refesh Data";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.SteelBlue;
            btnInsert.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(18, 909);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(194, 55);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert Data";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(532, 909);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(194, 55);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete Data";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FlatStyle = FlatStyle.Popup;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(28, 735);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(692, 40);
            cbGender.TabIndex = 31;
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(28, 836);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(698, 39);
            txbPhone.TabIndex = 30;
            // 
            // txbFullname
            // 
            txbFullname.Location = new Point(28, 627);
            txbFullname.Name = "txbFullname";
            txbFullname.Size = new Size(698, 39);
            txbFullname.TabIndex = 29;
            // 
            // txbPass
            // 
            txbPass.Location = new Point(28, 523);
            txbPass.Name = "txbPass";
            txbPass.Size = new Size(698, 39);
            txbPass.TabIndex = 28;
            // 
            // txbUsrname
            // 
            txbUsrname.Location = new Point(28, 424);
            txbUsrname.Name = "txbUsrname";
            txbUsrname.Size = new Size(698, 39);
            txbUsrname.TabIndex = 27;
            // 
            // lbPhonenumber
            // 
            lbPhonenumber.AutoSize = true;
            lbPhonenumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhonenumber.Location = new Point(28, 801);
            lbPhonenumber.Name = "lbPhonenumber";
            lbPhonenumber.Size = new Size(195, 32);
            lbPhonenumber.TabIndex = 26;
            lbPhonenumber.Text = "Phone Number:";
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFullname.Location = new Point(28, 592);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(125, 32);
            lbFullname.TabIndex = 25;
            lbFullname.Text = "Fullname:";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGender.Location = new Point(28, 700);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(105, 32);
            lbGender.TabIndex = 24;
            lbGender.Text = "Gender:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(28, 488);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(129, 32);
            lbPassword.TabIndex = 23;
            lbPassword.Text = "Password:";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(28, 389);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(135, 32);
            lbUsername.TabIndex = 22;
            lbUsername.Text = "Username:";
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(27, 217);
            txbSearch.Multiline = true;
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "Username";
            txbSearch.Size = new Size(522, 55);
            txbSearch.TabIndex = 32;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(567, 217);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 55);
            btnSearch.TabIndex = 33;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(280, 909);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(194, 55);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "Update Data";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClearData
            // 
            btnClearData.BackColor = Color.SteelBlue;
            btnClearData.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearData.ForeColor = Color.White;
            btnClearData.Location = new Point(311, 305);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(238, 55);
            btnClearData.TabIndex = 35;
            btnClearData.Text = "Clear";
            btnClearData.UseVisualStyleBackColor = false;
            btnClearData.Click += btnClearData_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1587, 22);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(138, 55);
            btnLogout.TabIndex = 36;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // formMainApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1766, 1017);
            Controls.Add(btnLogout);
            Controls.Add(btnClearData);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Controls.Add(cbGender);
            Controls.Add(txbPhone);
            Controls.Add(txbFullname);
            Controls.Add(txbPass);
            Controls.Add(txbUsrname);
            Controls.Add(lbPhonenumber);
            Controls.Add(lbFullname);
            Controls.Add(lbGender);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(btnView);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "formMainApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosing += formMainApp_FormClosing;
            Load += formMainApp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button btnView;
        private Button btnInsert;
        private Button btnDelete;
        private ComboBox cbGender;
        private TextBox txbPhone;
        private TextBox txbFullname;
        private TextBox txbPass;
        private TextBox txbUsrname;
        private Label lbPhonenumber;
        private Label lbFullname;
        private Label lbGender;
        private Label lbPassword;
        private Label lbUsername;
        private TextBox txbSearch;
        private Button btnSearch;
        private Button btnUpdate;
        private Button btnClearData;
        private Button btnLogout;
    }
}