namespace Lab3
{
    partial class Task3_Server
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
            listViewCommand = new ListView();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Location = new Point(619, 35);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(153, 39);
            btnListen.TabIndex = 3;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            // 
            // listViewCommand
            // 
            listViewCommand.Location = new Point(28, 83);
            listViewCommand.Name = "listViewCommand";
            listViewCommand.Size = new Size(742, 344);
            listViewCommand.TabIndex = 2;
            listViewCommand.UseCompatibleStateImageBehavior = false;
            listViewCommand.View = View.List;
            // 
            // Task3_Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListen);
            Controls.Add(listViewCommand);
            Name = "Task3_Server";
            Text = "Task3_Server";
            ResumeLayout(false);
        }

        #endregion

        private Button btnListen;
        private ListView listViewCommand;
    }
}