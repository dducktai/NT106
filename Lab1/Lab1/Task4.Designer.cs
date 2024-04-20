namespace Lab1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNum = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            txtResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ScrollBar;
            dataGridView1.Location = new Point(82, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(654, 298);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM Avo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(168, 19);
            label1.Name = "label1";
            label1.Size = new Size(443, 53);
            label1.TabIndex = 13;
            label1.Text = "TASK 4:  ĐỔI HỆ CƠ SỐ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(115, 91);
            label2.Name = "label2";
            label2.Size = new Size(155, 27);
            label2.TabIndex = 16;
            label2.Text = "Nhập thông tin:";
            label2.Click += label2_Click;
            // 
            // txtNum
            // 
            txtNum.Font = new Font("Segoe UI Semilight", 9F);
            txtNum.Location = new Point(215, 153);
            txtNum.Name = "txtNum";
            txtNum.PlaceholderText = "Ấn để nhập ";
            txtNum.RightToLeft = RightToLeft.No;
            txtNum.Size = new Size(464, 31);
            txtNum.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 157);
            label3.Name = "label3";
            label3.Size = new Size(75, 27);
            label3.TabIndex = 17;
            label3.Text = "Nhập: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(115, 213);
            label4.Name = "label4";
            label4.Size = new Size(88, 27);
            label4.TabIndex = 20;
            label4.Text = "Chuyển:";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            comboBox1.Location = new Point(215, 212);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 33);
            comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            comboBox2.Location = new Point(509, 213);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 33);
            comboBox2.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(439, 214);
            label5.Name = "label5";
            label5.Size = new Size(64, 27);
            label5.TabIndex = 22;
            label5.Text = "Sang:";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(530, 348);
            button3.Name = "button3";
            button3.Size = new Size(116, 40);
            button3.TabIndex = 26;
            button3.Text = "QUAY LẠI";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(175, 348);
            button2.Name = "button2";
            button2.Size = new Size(116, 40);
            button2.TabIndex = 25;
            button2.Text = "XÓA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(352, 348);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 24;
            button1.Text = "TÍNH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(111, 271);
            label6.Name = "label6";
            label6.Size = new Size(92, 27);
            label6.TabIndex = 28;
            label6.Text = "Kết quả:";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI Semilight", 9F);
            txtResult.Location = new Point(215, 270);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(464, 31);
            txtResult.TabIndex = 27;
            // 
            // Task4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtResult);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(txtNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Task4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task4";
            Load += Task4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtNum;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label5;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label6;
        private TextBox txtResult;
    }
}