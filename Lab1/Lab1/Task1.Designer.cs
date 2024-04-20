namespace Lab1
{
    partial class Task1
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
            button2 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(342, 303);
            button2.Name = "button2";
            button2.Size = new Size(116, 40);
            button2.TabIndex = 23;
            button2.Text = "TÍNH";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 105);
            label2.Name = "label2";
            label2.Size = new Size(121, 27);
            label2.TabIndex = 22;
            label2.Text = "Số thứ nhất:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semilight", 9F);
            textBox1.Location = new Point(248, 101);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ấn để nhập ";
            textBox1.Size = new Size(409, 31);
            textBox1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM Avo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(63, 23);
            label1.Name = "label1";
            label1.Size = new Size(674, 53);
            label1.TabIndex = 20;
            label1.Text = "TASK 1: TÍNH TỔNG HAI SỐ NGUYÊN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(130, 166);
            label3.Name = "label3";
            label3.Size = new Size(109, 27);
            label3.TabIndex = 25;
            label3.Text = "Số thứ hai:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semilight", 9F);
            textBox2.Location = new Point(248, 162);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ấn để nhập ";
            textBox2.Size = new Size(409, 31);
            textBox2.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(130, 225);
            label4.Name = "label4";
            label4.Size = new Size(77, 27);
            label4.TabIndex = 27;
            label4.Text = "TỔNG: ";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semilight", 9F);
            textBox3.Location = new Point(248, 221);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(409, 31);
            textBox3.TabIndex = 26;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(519, 303);
            button3.Name = "button3";
            button3.Size = new Size(116, 40);
            button3.TabIndex = 29;
            button3.Text = "QUAY LẠI";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(164, 303);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 28;
            button1.Text = "XÓA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Task1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button3;
        private Button button1;
    }
}