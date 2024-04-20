namespace Lab3
{
    partial class Task1_Server
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
            txtPort = new TextBox();
            btnListen = new Button();
            lwMessage = new ListView();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 57);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 11;
            label2.Text = "Port:";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(97, 54);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(150, 31);
            txtPort.TabIndex = 8;
            // 
            // btnListen
            // 
            btnListen.Location = new Point(631, 57);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(112, 34);
            btnListen.TabIndex = 6;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // lwMessage
            // 
            lwMessage.Location = new Point(43, 130);
            lwMessage.Name = "lwMessage";
            lwMessage.Size = new Size(699, 285);
            lwMessage.TabIndex = 12;
            lwMessage.UseCompatibleStateImageBehavior = false;
            lwMessage.View = View.List;
            lwMessage.SelectedIndexChanged += lwMessage_SelectedIndexChanged;
            // 
            // Task1_Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lwMessage);
            Controls.Add(label2);
            Controls.Add(txtPort);
            Controls.Add(btnListen);
            Name = "Task1_Server";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task1_Server";
            FormClosing += Task1_Server_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtPort;
        private Button btnListen;
        private ListView lwMessage;
    }
}