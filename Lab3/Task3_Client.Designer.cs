namespace Lab3
{
    partial class Task3_Client
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
            btnSend = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(102, 52);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(292, 44);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send Message";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Task3_Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 125);
            Controls.Add(btnSend);
            Name = "Task3_Client";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task3_Client";
            FormClosed += Task3_Client_FormClosed;
            Load += Task3_Client_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSend;
    }
}