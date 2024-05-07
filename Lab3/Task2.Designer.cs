namespace Lab3
{
    partial class Task2
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
            listViewCommand = new ListView();
            btnListen = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listViewCommand
            // 
            listViewCommand.Location = new Point(26, 116);
            listViewCommand.Name = "listViewCommand";
            listViewCommand.Size = new Size(742, 311);
            listViewCommand.TabIndex = 0;
            listViewCommand.UseCompatibleStateImageBehavior = false;
            listViewCommand.View = View.List;
            listViewCommand.SelectedIndexChanged += listViewCommand_SelectedIndexChanged;
            // 
            // btnListen
            // 
            btnListen.Location = new Point(638, 71);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(130, 39);
            btnListen.TabIndex = 1;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(317, 18);
            label1.Name = "label1";
            label1.Size = new Size(148, 54);
            label1.TabIndex = 3;
            label1.Text = "Task 2";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 88);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 4;
            label2.Text = "IP: 127.0.10.1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 88);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 5;
            label3.Text = "Port: 8080";
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnListen);
            Controls.Add(listViewCommand);
            Name = "Task2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task2";
            FormClosing += Task2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewCommand;
        private Button btnListen;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}