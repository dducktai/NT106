namespace Lab1
{
    partial class Task5
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
            btnBack = new Button();
            btnClear = new Button();
            btnExcute = new Button();
            label1 = new Label();
            label2 = new Label();
            txtDiem = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label11 = new Label();
            label3 = new Label();
            txtDTB = new TextBox();
            panel1 = new Panel();
            txtFail = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtPass = new TextBox();
            label8 = new Label();
            txtMin = new TextBox();
            label7 = new Label();
            txtMax = new TextBox();
            label6 = new Label();
            txtHocLuc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientInactiveCaption;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnBack.Location = new Point(642, 149);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 32);
            btnBack.TabIndex = 30;
            btnBack.Text = "QUAY LẠI";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientInactiveCaption;
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnClear.Location = new Point(332, 149);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 32);
            btnClear.TabIndex = 29;
            btnClear.Text = "XÓA";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExcute
            // 
            btnExcute.BackColor = SystemColors.GradientInactiveCaption;
            btnExcute.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExcute.Location = new Point(492, 149);
            btnExcute.Name = "btnExcute";
            btnExcute.Size = new Size(104, 32);
            btnExcute.TabIndex = 28;
            btnExcute.Text = "NHẬP";
            btnExcute.UseVisualStyleBackColor = false;
            btnExcute.Click += btnExcute_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM Avo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(82, 22);
            label1.Name = "label1";
            label1.Size = new Size(627, 53);
            label1.TabIndex = 27;
            label1.Text = "TASK 5: QUẢN LÝ ĐIỂM SINH VIÊN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 89);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(292, 54);
            label2.TabIndex = 32;
            label2.Text = "Nhập điểm số (mỗi môn cách\r\nnhau ít nhất 1 khoảng trắng):\r\n";
            label2.Click += label2_Click;
            // 
            // txtDiem
            // 
            txtDiem.Font = new Font("Segoe UI Semilight", 9F);
            txtDiem.Location = new Point(332, 89);
            txtDiem.Multiline = true;
            txtDiem.Name = "txtDiem";
            txtDiem.PlaceholderText = "Ấn để nhập ";
            txtDiem.Size = new Size(414, 54);
            txtDiem.TabIndex = 31;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlLight;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(label11);
            flowLayoutPanel1.Location = new Point(35, 214);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(325, 381);
            flowLayoutPanel1.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(307, 25);
            label11.TabIndex = 13;
            label11.Text = "                                                           ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(151, 196);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 27);
            label3.TabIndex = 35;
            label3.Text = "Kết quả";
            // 
            // txtDTB
            // 
            txtDTB.BackColor = SystemColors.ButtonHighlight;
            txtDTB.Location = new Point(178, 24);
            txtDTB.Name = "txtDTB";
            txtDTB.ReadOnly = true;
            txtDTB.Size = new Size(132, 31);
            txtDTB.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtFail);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtMin);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtMax);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtHocLuc);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDTB);
            panel1.Location = new Point(424, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 381);
            panel1.TabIndex = 37;
            panel1.Paint += panel1_Paint;
            // 
            // txtFail
            // 
            txtFail.BackColor = SystemColors.ButtonHighlight;
            txtFail.Location = new Point(178, 300);
            txtFail.Name = "txtFail";
            txtFail.ReadOnly = true;
            txtFail.Size = new Size(132, 31);
            txtFail.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 303);
            label10.Name = "label10";
            label10.Size = new Size(170, 25);
            label10.TabIndex = 11;
            label10.Text = "Số môn không đậu:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 249);
            label9.Name = "label9";
            label9.Size = new Size(114, 25);
            label9.TabIndex = 9;
            label9.Text = "Số môn đậu:";
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.ButtonHighlight;
            txtPass.Location = new Point(178, 246);
            txtPass.Name = "txtPass";
            txtPass.ReadOnly = true;
            txtPass.Size = new Size(132, 31);
            txtPass.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 192);
            label8.Name = "label8";
            label8.Size = new Size(139, 25);
            label8.TabIndex = 7;
            label8.Text = "Điểm thấp nhất:";
            // 
            // txtMin
            // 
            txtMin.BackColor = SystemColors.ButtonHighlight;
            txtMin.Location = new Point(178, 189);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(132, 31);
            txtMin.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 137);
            label7.Name = "label7";
            label7.Size = new Size(131, 25);
            label7.TabIndex = 5;
            label7.Text = "Điểm cao nhất:";
            // 
            // txtMax
            // 
            txtMax.BackColor = SystemColors.ButtonHighlight;
            txtMax.Location = new Point(178, 134);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(132, 31);
            txtMax.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 83);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 3;
            label6.Text = "Học lực:";
            // 
            // txtHocLuc
            // 
            txtHocLuc.BackColor = SystemColors.ButtonHighlight;
            txtHocLuc.Location = new Point(178, 80);
            txtHocLuc.Name = "txtHocLuc";
            txtHocLuc.ReadOnly = true;
            txtHocLuc.Size = new Size(132, 31);
            txtHocLuc.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 27);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 1;
            label5.Text = "Điểm trung bình:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(536, 196);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 27);
            label4.TabIndex = 40;
            label4.Text = "Đánh giá";
            // 
            // Task5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 626);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(txtDiem);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnExcute);
            Controls.Add(label1);
            Name = "Task5";
            Text = "Task5";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnClear;
        private Button btnExcute;
        private Label label1;
        private Label label2;
        private TextBox txtDiem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private TextBox txtDTB;
        private Panel panel1;
        private Label label7;
        private TextBox txtMax;
        private Label label6;
        private TextBox txtHocLuc;
        private Label label5;
        private Label label10;
        private Label label9;
        private TextBox txtPass;
        private Label label8;
        private TextBox txtMin;
        private TextBox txtFail;
        private Label label4;
        private Label label11;
    }
}