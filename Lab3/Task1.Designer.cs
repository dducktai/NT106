namespace Lab3
{
    partial class Task1
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
            btnClient = new Button();
            btnServer = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClient
            // 
            btnClient.Location = new Point(43, 99);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(210, 51);
            btnClient.TabIndex = 0;
            btnClient.Text = "Client";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // btnServer
            // 
            btnServer.Location = new Point(315, 99);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(210, 51);
            btnServer.TabIndex = 1;
            btnServer.Text = "Server";
            btnServer.UseVisualStyleBackColor = true;
            btnServer.Click += btnServer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 16);
            label1.Name = "label1";
            label1.Size = new Size(143, 54);
            label1.TabIndex = 3;
            label1.Text = "Task 1";
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 181);
            Controls.Add(label1);
            Controls.Add(btnServer);
            Controls.Add(btnClient);
            Name = "Task1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task1";
            FormClosed += Task1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClient;
        private Button btnServer;
        private Label label1;
    }
}
