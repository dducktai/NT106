namespace Lab2
{
    partial class Task5
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
            listViewFile = new ListView();
            clnName = new ColumnHeader();
            clnSize = new ColumnHeader();
            clnTail = new ColumnHeader();
            clnDate = new ColumnHeader();
            btnOpen = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // listViewFile
            // 
            listViewFile.Columns.AddRange(new ColumnHeader[] { clnName, clnSize, clnTail, clnDate });
            listViewFile.FullRowSelect = true;
            listViewFile.GridLines = true;
            listViewFile.Location = new Point(59, 93);
            listViewFile.Name = "listViewFile";
            listViewFile.Size = new Size(725, 374);
            listViewFile.TabIndex = 0;
            listViewFile.UseCompatibleStateImageBehavior = false;
            listViewFile.View = View.Details;
            // 
            // clnName
            // 
            clnName.Text = "Tên file";
            clnName.Width = 200;
            // 
            // clnSize
            // 
            clnSize.Text = "Kích thước (byte)";
            clnSize.Width = 180;
            // 
            // clnTail
            // 
            clnTail.Text = "Đuôi mở rộng";
            clnTail.Width = 160;
            // 
            // clnDate
            // 
            clnDate.Text = "Ngày khởi tạo";
            clnDate.Width = 180;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Coral;
            btnOpen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(366, 477);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(112, 34);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat ExtraBold", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label6.Location = new Point(301, 9);
            label6.Name = "label6";
            label6.Size = new Size(222, 77);
            label6.TabIndex = 29;
            label6.Text = "Task 5";
            // 
            // Task5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(854, 523);
            Controls.Add(label6);
            Controls.Add(btnOpen);
            Controls.Add(listViewFile);
            Name = "Task5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewFile;
        private ColumnHeader clnName;
        private ColumnHeader clnSize;
        private ColumnHeader clnTail;
        private ColumnHeader clnDate;
        private Button btnOpen;
        private Label label6;
    }
}