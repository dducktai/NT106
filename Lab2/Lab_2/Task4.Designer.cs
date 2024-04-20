namespace Lab2
{
    partial class Task4
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
            btnAdd = new Button();
            btnReset = new Button();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtID = new TextBox();
            label5 = new Label();
            txtLiterature = new TextBox();
            label7 = new Label();
            txtMath = new TextBox();
            panel2 = new Panel();
            btnWrite = new Button();
            btnRead = new Button();
            txtAddress = new TextBox();
            label6 = new Label();
            lwShow = new ListView();
            colName = new ColumnHeader();
            colID = new ColumnHeader();
            colPhone = new ColumnHeader();
            colMath = new ColumnHeader();
            colLiterature = new ColumnHeader();
            colAverage = new ColumnHeader();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Coral;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(636, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnStart_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Coral;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReset.ForeColor = SystemColors.ControlLightLight;
            btnReset.Location = new Point(493, 40);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 15);
            txtName.Name = "txtName";
            txtName.Size = new Size(318, 31);
            txtName.TabIndex = 5;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(14, 21);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 6;
            label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(59, 58);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 8;
            label3.Text = "SĐT:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(113, 52);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(318, 31);
            txtPhone.TabIndex = 7;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(44, 92);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 10;
            label4.Text = "MSSV:";
            // 
            // txtID
            // 
            txtID.Location = new Point(113, 92);
            txtID.Name = "txtID";
            txtID.Size = new Size(318, 31);
            txtID.TabIndex = 9;
            txtID.TextChanged += txtMath_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(70, 129);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 12;
            label5.Text = "Văn:";
            // 
            // txtLiterature
            // 
            txtLiterature.Location = new Point(113, 129);
            txtLiterature.Name = "txtLiterature";
            txtLiterature.Size = new Size(120, 31);
            txtLiterature.TabIndex = 11;
            txtLiterature.TextChanged += txtLiterature_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Brown;
            label7.Location = new Point(267, 132);
            label7.Name = "label7";
            label7.Size = new Size(55, 25);
            label7.TabIndex = 14;
            label7.Text = "Toán:";
            label7.Click += label7_Click;
            // 
            // txtMath
            // 
            txtMath.Location = new Point(320, 126);
            txtMath.Name = "txtMath";
            txtMath.Size = new Size(111, 31);
            txtMath.TabIndex = 17;
            txtMath.TextChanged += txtMath_TextChanged_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnWrite);
            panel2.Controls.Add(txtMath);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnRead);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtLiterature);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtName);
            panel2.Location = new Point(12, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 165);
            panel2.TabIndex = 19;
            // 
            // btnWrite
            // 
            btnWrite.BackColor = Color.Coral;
            btnWrite.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnWrite.ForeColor = SystemColors.ControlLightLight;
            btnWrite.Location = new Point(636, 92);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(112, 34);
            btnWrite.TabIndex = 4;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = false;
            btnWrite.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.Coral;
            btnRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRead.ForeColor = SystemColors.ControlLightLight;
            btnRead.Location = new Point(493, 92);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(112, 34);
            btnRead.TabIndex = 22;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(255, 224, 192);
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Location = new Point(26, 520);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(746, 68);
            txtAddress.TabIndex = 24;
            txtAddress.TextChanged += txtAddressRead_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat ExtraBold", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label6.Location = new Point(279, 9);
            label6.Name = "label6";
            label6.Size = new Size(227, 77);
            label6.TabIndex = 28;
            label6.Text = "Task 4";
            // 
            // lwShow
            // 
            lwShow.Columns.AddRange(new ColumnHeader[] { colName, colID, colPhone, colMath, colLiterature, colAverage });
            lwShow.FullRowSelect = true;
            lwShow.Location = new Point(12, 328);
            lwShow.Name = "lwShow";
            lwShow.Size = new Size(776, 173);
            lwShow.TabIndex = 29;
            lwShow.UseCompatibleStateImageBehavior = false;
            lwShow.View = View.Details;
            // 
            // colName
            // 
            colName.DisplayIndex = 1;
            colName.Text = "Họ và tên";
            colName.TextAlign = HorizontalAlignment.Center;
            colName.Width = 200;
            // 
            // colID
            // 
            colID.DisplayIndex = 0;
            colID.Text = "MSSV";
            colID.Width = 100;
            // 
            // colPhone
            // 
            colPhone.Text = "Số điện thoại";
            colPhone.TextAlign = HorizontalAlignment.Center;
            colPhone.Width = 120;
            // 
            // colMath
            // 
            colMath.Text = "Điểm Toán";
            colMath.TextAlign = HorizontalAlignment.Center;
            colMath.Width = 100;
            // 
            // colLiterature
            // 
            colLiterature.Text = "Điểm Văn";
            colLiterature.TextAlign = HorizontalAlignment.Center;
            colLiterature.Width = 100;
            // 
            // colAverage
            // 
            colAverage.Text = "Điểm trung bình";
            colAverage.TextAlign = HorizontalAlignment.Center;
            colAverage.Width = 150;
            // 
            // Task4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 627);
            Controls.Add(lwShow);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(panel2);
            Name = "Task4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task4";
            Load += Task4_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnReset;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtID;
        private Label label5;
        private TextBox txtLiterature;
        private Label label7;
        private TextBox txtMath;
        private Panel panel2;
        private Button btnRead;
        private Button btnAdd;
        private TextBox txtAddress;
        private Label label6;
        private Button btnWrite;
        private ListView lwShow;
        private ColumnHeader colID;
        private ColumnHeader colName;
        private ColumnHeader colPhone;
        private ColumnHeader colMath;
        private ColumnHeader colLiterature;
        private ColumnHeader colAverage;
    }
}