namespace ASEAssignmentProject
{
    partial class Form1
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
            this.ProgramWindow = new System.Windows.Forms.RichTextBox();
            this.OutputWindow = new System.Windows.Forms.PictureBox();
            this.CommandLine = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgramWindow
            // 
            this.ProgramWindow.Location = new System.Drawing.Point(12, 12);
            this.ProgramWindow.Name = "ProgramWindow";
            this.ProgramWindow.Size = new System.Drawing.Size(400, 300);
            this.ProgramWindow.TabIndex = 0;
            this.ProgramWindow.Text = "";
            // 
            // OutputWindow
            // 
            this.OutputWindow.Location = new System.Drawing.Point(444, 12);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(400, 300);
            this.OutputWindow.TabIndex = 1;
            this.OutputWindow.TabStop = false;
            // 
            // CommandLine
            // 
            this.CommandLine.Location = new System.Drawing.Point(12, 318);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Size = new System.Drawing.Size(400, 20);
            this.CommandLine.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 367);
            this.Controls.Add(this.CommandLine);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.ProgramWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ProgramWindow;
        private System.Windows.Forms.PictureBox OutputWindow;
        private System.Windows.Forms.TextBox CommandLine;
    }
}

