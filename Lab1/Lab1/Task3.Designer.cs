
namespace Lab1
{
    partial class Task3
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
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 117);
            label2.Name = "label2";
            label2.Size = new Size(175, 27);
            label2.TabIndex = 11;
            label2.Text = "Nhập số nguyên: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM Avo", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(222, 18);
            label1.Name = "label1";
            label1.Size = new Size(332, 53);
            label1.TabIndex = 9;
            label1.Text = "TASK 3: ĐỌC SỐ ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semilight", 9F);
            textBox2.Location = new Point(300, 176);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(361, 31);
            textBox2.TabIndex = 14;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UTM Avo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 176);
            label3.Name = "label3";
            label3.Size = new Size(92, 27);
            label3.TabIndex = 13;
            label3.Text = "Kết quả:";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(515, 268);
            button3.Name = "button3";
            button3.Size = new Size(116, 40);
            button3.TabIndex = 23;
            button3.Text = "QUAY LẠI";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(160, 268);
            button2.Name = "button2";
            button2.Size = new Size(116, 40);
            button2.TabIndex = 22;
            button2.Text = "XÓA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(337, 268);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 21;
            button1.Text = "ĐỌC";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semilight", 9F);
            textBox1.Location = new Point(300, 117);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ấn để nhập ";
            textBox1.Size = new Size(361, 31);
            textBox1.TabIndex = 24;
            // 
            // Task3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Task3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task3";
            Load += Task3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
    }
}