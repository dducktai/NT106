namespace Lab3
{
    partial class Main
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
            btnTask1 = new Button();
            btnTask2 = new Button();
            btnTask3 = new Button();
            btnTask4 = new Button();
            SuspendLayout();
            // 
            // btnTask1
            // 
            btnTask1.Location = new Point(127, 40);
            btnTask1.Name = "btnTask1";
            btnTask1.Size = new Size(247, 44);
            btnTask1.TabIndex = 0;
            btnTask1.Text = "Task 1";
            btnTask1.UseVisualStyleBackColor = true;
            btnTask1.Click += btnTask1_Click;
            // 
            // btnTask2
            // 
            btnTask2.Location = new Point(127, 109);
            btnTask2.Name = "btnTask2";
            btnTask2.Size = new Size(247, 44);
            btnTask2.TabIndex = 1;
            btnTask2.Text = "Task 2";
            btnTask2.UseVisualStyleBackColor = true;
            btnTask2.Click += btnTask2_Click;
            // 
            // btnTask3
            // 
            btnTask3.Location = new Point(127, 180);
            btnTask3.Name = "btnTask3";
            btnTask3.Size = new Size(247, 44);
            btnTask3.TabIndex = 2;
            btnTask3.Text = "Task 3";
            btnTask3.UseVisualStyleBackColor = true;
            btnTask3.Click += btnTask3_Click;
            // 
            // btnTask4
            // 
            btnTask4.Location = new Point(127, 252);
            btnTask4.Name = "btnTask4";
            btnTask4.Size = new Size(247, 44);
            btnTask4.TabIndex = 3;
            btnTask4.Text = "Task 4";
            btnTask4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 333);
            Controls.Add(btnTask4);
            Controls.Add(btnTask3);
            Controls.Add(btnTask2);
            Controls.Add(btnTask1);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTask1;
        private Button btnTask2;
        private Button btnTask3;
        private Button btnTask4;
    }
}