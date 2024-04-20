namespace Lab_2
{
    partial class formLab2
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
            btnBai1 = new Button();
            btnBai2 = new Button();
            btnBai3 = new Button();
            btnBai5 = new Button();
            btnBai4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBai1
            // 
            btnBai1.BackColor = Color.Coral;
            btnBai1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai1.ForeColor = Color.White;
            btnBai1.Location = new Point(390, 38);
            btnBai1.Margin = new Padding(2);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(145, 43);
            btnBai1.TabIndex = 0;
            btnBai1.Text = "Task 1";
            btnBai1.UseVisualStyleBackColor = false;
            btnBai1.Click += btnBai1_Click;
            // 
            // btnBai2
            // 
            btnBai2.BackColor = Color.Coral;
            btnBai2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai2.ForeColor = Color.White;
            btnBai2.Location = new Point(390, 97);
            btnBai2.Margin = new Padding(2);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(145, 43);
            btnBai2.TabIndex = 1;
            btnBai2.Text = "Task 2";
            btnBai2.UseVisualStyleBackColor = false;
            btnBai2.Click += btnBai2_Click;
            // 
            // btnBai3
            // 
            btnBai3.BackColor = Color.Coral;
            btnBai3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai3.ForeColor = Color.White;
            btnBai3.Location = new Point(390, 153);
            btnBai3.Margin = new Padding(2);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(145, 43);
            btnBai3.TabIndex = 2;
            btnBai3.Text = "Task 3";
            btnBai3.UseVisualStyleBackColor = false;
            btnBai3.Click += btnBai3_Click;
            // 
            // btnBai5
            // 
            btnBai5.BackColor = Color.Coral;
            btnBai5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai5.ForeColor = Color.White;
            btnBai5.Location = new Point(390, 272);
            btnBai5.Margin = new Padding(2);
            btnBai5.Name = "btnBai5";
            btnBai5.Size = new Size(145, 43);
            btnBai5.TabIndex = 4;
            btnBai5.Text = "Task 5";
            btnBai5.UseVisualStyleBackColor = false;
            btnBai5.Click += btnBai5_Click;
            // 
            // btnBai4
            // 
            btnBai4.BackColor = Color.Coral;
            btnBai4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai4.ForeColor = Color.White;
            btnBai4.Location = new Point(390, 212);
            btnBai4.Margin = new Padding(2);
            btnBai4.Name = "btnBai4";
            btnBai4.Size = new Size(145, 43);
            btnBai4.TabIndex = 3;
            btnBai4.Text = "Task 4";
            btnBai4.UseVisualStyleBackColor = false;
            btnBai4.Click += btnBai4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Black", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(46, 97);
            label1.Name = "label1";
            label1.Size = new Size(301, 132);
            label1.TabIndex = 5;
            label1.Text = "WELCOME\r\nTO LAB 3";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formLab2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(615, 352);
            Controls.Add(label1);
            Controls.Add(btnBai5);
            Controls.Add(btnBai4);
            Controls.Add(btnBai3);
            Controls.Add(btnBai2);
            Controls.Add(btnBai1);
            Margin = new Padding(2);
            Name = "formLab2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 2";
            FormClosing += formLab2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBai1;
        private Button btnBai2;
        private Button btnBai3;
        private Button btnBai5;
        private Button btnBai4;
        private Label label1;
    }
}
