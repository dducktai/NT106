namespace Lab4
{
    partial class Main
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM Avo", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 41);
            label1.Name = "label1";
            label1.Size = new Size(297, 41);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO LAB 4";
            // 
            // button1
            // 
            button1.Location = new Point(154, 117);
            button1.Name = "button1";
            button1.Size = new Size(358, 42);
            button1.TabIndex = 1;
            button1.Text = "Task 1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(154, 174);
            button2.Name = "button2";
            button2.Size = new Size(358, 42);
            button2.TabIndex = 2;
            button2.Text = "Task 2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(154, 233);
            button3.Name = "button3";
            button3.Size = new Size(358, 42);
            button3.TabIndex = 3;
            button3.Text = "Task 3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(154, 294);
            button4.Name = "button4";
            button4.Size = new Size(358, 42);
            button4.TabIndex = 4;
            button4.Text = "Task 4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 412);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
