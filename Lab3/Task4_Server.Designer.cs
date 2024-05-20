namespace Lab3
{
    partial class Task4_Server
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
            btnListen = new Button();
            lvLog = new ListView();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Location = new Point(805, 38);
            btnListen.Margin = new Padding(4);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(199, 50);
            btnListen.TabIndex = 7;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // lvLog
            // 
            lvLog.Location = new Point(36, 99);
            lvLog.Margin = new Padding(4);
            lvLog.Name = "lvLog";
            lvLog.Size = new Size(963, 439);
            lvLog.TabIndex = 6;
            lvLog.UseCompatibleStateImageBehavior = false;
            lvLog.View = View.List;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(598, 38);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(199, 50);
            btnClose.TabIndex = 8;
            btnClose.Text = "End Chat";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Task4_Server
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(btnClose);
            Controls.Add(btnListen);
            Controls.Add(lvLog);
            Name = "Task4_Server";
            Text = "Task4_Server";
            Load += Task4_Server_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnListen;
        private ListView lvLog;
        private Button btnClose;
    }
}