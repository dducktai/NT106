namespace Lab_2
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
            btnClear = new Button();
            richTextBox1 = new RichTextBox();
            btnWrite = new Button();
            btnRead = new Button();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Coral;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(471, 287);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 36);
            btnClear.TabIndex = 7;
            btnClear.Text = "Xoá";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(32, 24);
            richTextBox1.Margin = new Padding(2, 2, 2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(401, 299);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // btnWrite
            // 
            btnWrite.BackColor = Color.Coral;
            btnWrite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWrite.ForeColor = Color.White;
            btnWrite.Location = new Point(471, 234);
            btnWrite.Margin = new Padding(2, 2, 2, 2);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(115, 36);
            btnWrite.TabIndex = 5;
            btnWrite.Text = "Ghi File";
            btnWrite.UseVisualStyleBackColor = false;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.Coral;
            btnRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.ForeColor = Color.White;
            btnRead.Location = new Point(471, 182);
            btnRead.Margin = new Padding(2, 2, 2, 2);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(115, 36);
            btnRead.TabIndex = 4;
            btnRead.Text = "Đọc File";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // Task3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(615, 352);
            Controls.Add(btnClear);
            Controls.Add(richTextBox1);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Task3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClear;
        private RichTextBox richTextBox1;
        private Button btnWrite;
        private Button btnRead;
    }
}