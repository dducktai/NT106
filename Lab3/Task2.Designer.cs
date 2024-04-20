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
            SuspendLayout();
            // 
            // listViewCommand
            // 
            listViewCommand.Location = new Point(26, 95);
            listViewCommand.Name = "listViewCommand";
            listViewCommand.Size = new Size(742, 332);
            listViewCommand.TabIndex = 0;
            listViewCommand.UseCompatibleStateImageBehavior = false;
            // 
            // btnListen
            // 
            btnListen.Location = new Point(617, 54);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(153, 32);
            btnListen.TabIndex = 1;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListen);
            Controls.Add(listViewCommand);
            Name = "Task2";
            Text = "Task2";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewCommand;
        private Button btnListen;
    }
}