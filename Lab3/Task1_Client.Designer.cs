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
            btnSend.Location = new Point(859, 485);
            btnSend.Margin = new Padding(4, 4, 4, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(146, 44);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(178, 86);
            txtIP.Margin = new Padding(4, 4, 4, 4);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(316, 39);
            txtIP.TabIndex = 1;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(632, 86);
            txtPort.Margin = new Padding(4, 4, 4, 4);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(194, 39);
            txtPort.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(77, 164);
            txtMessage.Margin = new Padding(4, 4, 4, 4);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(749, 364);
            txtMessage.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 93);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 4;
            label1.Text = "Host IP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(562, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 32);
            label2.TabIndex = 5;
            label2.Text = "Port:";
            // 
            // Task1_Client
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMessage);
            Controls.Add(txtPort);
            Controls.Add(txtIP);
            Controls.Add(btnSend);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Task1_Client";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task1_Client";
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