namespace Lab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbHTML = new System.Windows.Forms.RichTextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "TASK 3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbHTML
            // 
            this.rtbHTML.Location = new System.Drawing.Point(44, 153);
            this.rtbHTML.Name = "rtbHTML";
            this.rtbHTML.ReadOnly = true;
            this.rtbHTML.Size = new System.Drawing.Size(706, 386);
            this.rtbHTML.TabIndex = 7;
            this.rtbHTML.Text = "";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(44, 74);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(570, 26);
            this.txtURL.TabIndex = 6;
            this.txtURL.Text = "https://uit.edu.vn/";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(632, 74);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(119, 58);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(44, 106);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(570, 26);
            this.txtPath.TabIndex = 8;
            this.txtPath.Text = "C:\\Users\\Admin\\Downloads\\";
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.rtbHTML);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.label1);
            this.Name = "Task3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbHTML;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtPath;
    }
}