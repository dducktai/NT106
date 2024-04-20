namespace Lab_2
{
    partial class Task2
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
            btnDocFile = new Button();
            lbTenFile = new Label();
            lbURL = new Label();
            lbSoDong = new Label();
            lbSoTu = new Label();
            lbSoKyTu = new Label();
            txbTenFile = new TextBox();
            txbURL = new TextBox();
            txbSoDong = new TextBox();
            txbSoTu = new TextBox();
            txbSoKyTu = new TextBox();
            richTextBox1 = new RichTextBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnDocFile
            // 
            btnDocFile.BackColor = Color.Coral;
            btnDocFile.ForeColor = SystemColors.ControlLightLight;
            btnDocFile.Location = new Point(23, 455);
            btnDocFile.Margin = new Padding(2, 2, 2, 2);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(204, 41);
            btnDocFile.TabIndex = 0;
            btnDocFile.Text = "Đọc File";
            btnDocFile.UseVisualStyleBackColor = false;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // lbTenFile
            // 
            lbTenFile.AutoSize = true;
            lbTenFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTenFile.Location = new Point(23, 80);
            lbTenFile.Margin = new Padding(2, 0, 2, 0);
            lbTenFile.Name = "lbTenFile";
            lbTenFile.Size = new Size(74, 25);
            lbTenFile.TabIndex = 1;
            lbTenFile.Text = "Tên file";
            // 
            // lbURL
            // 
            lbURL.AutoSize = true;
            lbURL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbURL.Location = new Point(23, 153);
            lbURL.Margin = new Padding(2, 0, 2, 0);
            lbURL.Name = "lbURL";
            lbURL.Size = new Size(46, 25);
            lbURL.TabIndex = 2;
            lbURL.Text = "URL";
            // 
            // lbSoDong
            // 
            lbSoDong.AutoSize = true;
            lbSoDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoDong.Location = new Point(22, 220);
            lbSoDong.Margin = new Padding(2, 0, 2, 0);
            lbSoDong.Name = "lbSoDong";
            lbSoDong.Size = new Size(82, 25);
            lbSoDong.TabIndex = 4;
            lbSoDong.Text = "Số dòng";
            // 
            // lbSoTu
            // 
            lbSoTu.AutoSize = true;
            lbSoTu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoTu.Location = new Point(22, 286);
            lbSoTu.Margin = new Padding(2, 0, 2, 0);
            lbSoTu.Name = "lbSoTu";
            lbSoTu.Size = new Size(57, 25);
            lbSoTu.TabIndex = 3;
            lbSoTu.Text = "Số từ";
            // 
            // lbSoKyTu
            // 
            lbSoKyTu.AutoSize = true;
            lbSoKyTu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoKyTu.Location = new Point(23, 359);
            lbSoKyTu.Margin = new Padding(2, 0, 2, 0);
            lbSoKyTu.Name = "lbSoKyTu";
            lbSoKyTu.Size = new Size(82, 25);
            lbSoKyTu.TabIndex = 5;
            lbSoKyTu.Text = "Số ký tự";
            // 
            // txbTenFile
            // 
            txbTenFile.Location = new Point(134, 75);
            txbTenFile.Margin = new Padding(2, 2, 2, 2);
            txbTenFile.Name = "txbTenFile";
            txbTenFile.ReadOnly = true;
            txbTenFile.Size = new Size(310, 31);
            txbTenFile.TabIndex = 6;
            // 
            // txbURL
            // 
            txbURL.Location = new Point(134, 151);
            txbURL.Margin = new Padding(2, 2, 2, 2);
            txbURL.Name = "txbURL";
            txbURL.ReadOnly = true;
            txbURL.Size = new Size(310, 31);
            txbURL.TabIndex = 7;
            // 
            // txbSoDong
            // 
            txbSoDong.Location = new Point(133, 218);
            txbSoDong.Margin = new Padding(2, 2, 2, 2);
            txbSoDong.Name = "txbSoDong";
            txbSoDong.ReadOnly = true;
            txbSoDong.Size = new Size(311, 31);
            txbSoDong.TabIndex = 8;
            // 
            // txbSoTu
            // 
            txbSoTu.Location = new Point(133, 284);
            txbSoTu.Margin = new Padding(2, 2, 2, 2);
            txbSoTu.Name = "txbSoTu";
            txbSoTu.ReadOnly = true;
            txbSoTu.Size = new Size(311, 31);
            txbSoTu.TabIndex = 9;
            // 
            // txbSoKyTu
            // 
            txbSoKyTu.Location = new Point(134, 359);
            txbSoKyTu.Margin = new Padding(2, 2, 2, 2);
            txbSoKyTu.Name = "txbSoKyTu";
            txbSoKyTu.ReadOnly = true;
            txbSoKyTu.Size = new Size(310, 31);
            txbSoKyTu.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(478, 33);
            richTextBox1.Margin = new Padding(2, 2, 2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(545, 463);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Coral;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(241, 455);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(203, 41);
            btnClear.TabIndex = 12;
            btnClear.Text = "Xoá";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1051, 557);
            Controls.Add(btnClear);
            Controls.Add(richTextBox1);
            Controls.Add(txbSoKyTu);
            Controls.Add(txbSoTu);
            Controls.Add(txbSoDong);
            Controls.Add(txbURL);
            Controls.Add(txbTenFile);
            Controls.Add(lbSoKyTu);
            Controls.Add(lbSoDong);
            Controls.Add(lbSoTu);
            Controls.Add(lbURL);
            Controls.Add(lbTenFile);
            Controls.Add(btnDocFile);
            ForeColor = Color.SaddleBrown;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Task2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDocFile;
        private Label lbTenFile;
        private Label lbURL;
        private Label lbSoDong;
        private Label lbSoTu;
        private Label lbSoKyTu;
        private TextBox txbTenFile;
        private TextBox txbURL;
        private TextBox txbSoDong;
        private TextBox txbSoTu;
        private TextBox txbSoKyTu;
        private RichTextBox richTextBox1;
        private Button btnClear;
    }
}