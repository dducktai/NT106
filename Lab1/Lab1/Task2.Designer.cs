namespace Lab1
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
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 132);
            label2.Name = "label2";
            label2.Size = new Size(121, 27);
            label2.TabIndex = 8;
            label2.Text = "Số thứ nhất:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semilight", 9F);
            textBox1.Location = new Point(151, 128);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ấn để nhập ";
            textBox1.Size = new Size(120, 31);
            textBox1.TabIndex = 7;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM Avo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(772, 53);
            label1.TabIndex = 6;
            label1.Text = "TASK 2: TÌM SỐ LỚN NHẤT, SỐ NHỎ NHẤT";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(295, 132);
            label3.Name = "label3";
            label3.Size = new Size(109, 27);
            label3.TabIndex = 10;
            label3.Text = "Số thứ hai:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semilight", 9F);
            textBox2.Location = new Point(400, 128);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ấn để nhập ";
            textBox2.Size = new Size(120, 31);
            textBox2.TabIndex = 9;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(547, 132);
            label4.Name = "label4";
            label4.Size = new Size(105, 27);
            label4.TabIndex = 12;
            label4.Text = "Số thứ ba:";
            label4.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semilight", 9F);
            textBox3.Location = new Point(648, 128);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Ấn để nhập ";
            textBox3.Size = new Size(120, 31);
            textBox3.TabIndex = 11;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(106, 208);
            label5.Name = "label5";
            label5.Size = new Size(121, 27);
            label5.TabIndex = 14;
            label5.Text = "Số lớn nhất:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Semilight", 9F);
            textBox4.Location = new Point(224, 204);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(120, 31);
            textBox4.TabIndex = 13;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(423, 208);
            label6.Name = "label6";
            label6.Size = new Size(127, 27);
            label6.TabIndex = 16;
            label6.Text = "Số nhỏ nhất:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Semilight", 9F);
            textBox5.Location = new Point(547, 204);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(120, 31);
            textBox5.TabIndex = 17;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(340, 296);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 18;
            button1.Text = "TÍNH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(163, 296);
            button2.Name = "button2";
            button2.Size = new Size(116, 40);
            button2.TabIndex = 19;
            button2.Text = "XÓA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(518, 296);
            button3.Name = "button3";
            button3.Size = new Size(116, 40);
            button3.TabIndex = 20;
            button3.Text = "QUAY LẠI";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Task2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}