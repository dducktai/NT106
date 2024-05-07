namespace Lab3
{
    partial class Task1_Client
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
            txtIP = new TextBox();
            txtPort = new TextBox();
            txtMessage = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(661, 379);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 34);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(137, 67);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(244, 31);
            txtIP.TabIndex = 1;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(486, 67);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(150, 31);
            txtPort.TabIndex = 2;
            txtPort.TextChanged += txtPort_TextChanged;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(59, 128);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(577, 285);
            txtMessage.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 73);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 4;
            label1.Text = "Host IP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 70);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 5;
            label2.Text = "Port:";
            // 
            // Task1_Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMessage);
            Controls.Add(txtPort);
            Controls.Add(txtIP);
            Controls.Add(btnSend);
            Name = "Task1_Client";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task1_Client";
            FormClosing += Task1_Client_FormClosing;
            Load += Task1_Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private TextBox txtIP;
        private TextBox txtPort;
        private TextBox txtMessage;
        private Label label1;
        private Label label2;
    }
}