namespace Lab3
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
            btnServer = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnServer
            // 
            btnServer.Location = new Point(108, 116);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(318, 43);
            btnServer.TabIndex = 0;
            btnServer.Text = "Open TCP server";
            btnServer.UseVisualStyleBackColor = true;
            btnServer.Click += btnServer_Click;
            // 
            // button1
            // 
            button1.Location = new Point(108, 175);
            button1.Name = "button1";
            button1.Size = new Size(318, 43);
            button1.TabIndex = 1;
            button1.Text = "Open new TCP client";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 26);
            label1.Name = "label1";
            label1.Size = new Size(148, 54);
            label1.TabIndex = 2;
            label1.Text = "Task 3";
            // 
            // Task3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 245);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnServer);
            Name = "Task3";
            Text = "Task3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnServer;
        private Button button1;
        private Label label1;
    }
}