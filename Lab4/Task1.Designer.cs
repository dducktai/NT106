namespace Lab4
{
    partial class Task1
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
            this.btnGet = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.rtbHTML = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "TASK 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(634, 80);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(119, 40);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(46, 80);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(570, 40);
            this.txtURL.TabIndex = 3;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // rtbHTML
            // 
            this.rtbHTML.Location = new System.Drawing.Point(46, 138);
            this.rtbHTML.Name = "rtbHTML";
            this.rtbHTML.ReadOnly = true;
            this.rtbHTML.Size = new System.Drawing.Size(706, 386);
            this.rtbHTML.TabIndex = 4;
            this.rtbHTML.Text = "";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.rtbHTML);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.label1);
            this.Name = "Task1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.RichTextBox rtbHTML;
    }
}