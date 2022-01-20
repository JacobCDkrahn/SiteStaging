namespace WindowsFormsApp1
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
            this.inFolder = new System.Windows.Forms.Button();
            this.outFolder = new System.Windows.Forms.Button();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.targetText = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.destinationFolder = new System.Windows.Forms.Label();
            this.templateSourceLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inFolder
            // 
            this.inFolder.Location = new System.Drawing.Point(454, 16);
            this.inFolder.Name = "inFolder";
            this.inFolder.Size = new System.Drawing.Size(75, 23);
            this.inFolder.TabIndex = 4;
            this.inFolder.Text = "inFolder";
            this.inFolder.UseVisualStyleBackColor = true;
            this.inFolder.Click += new System.EventHandler(this.inFolder_Click);
            // 
            // outFolder
            // 
            this.outFolder.Location = new System.Drawing.Point(454, 41);
            this.outFolder.Name = "outFolder";
            this.outFolder.Size = new System.Drawing.Size(75, 23);
            this.outFolder.TabIndex = 5;
            this.outFolder.Text = "outFolder";
            this.outFolder.UseVisualStyleBackColor = true;
            this.outFolder.Click += new System.EventHandler(this.outFolder_Click_1);
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(119, 16);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(329, 20);
            this.sourceText.TabIndex = 6;
            this.sourceText.TextChanged += new System.EventHandler(this.SourceFolder_TextChanged);
            // 
            // targetText
            // 
            this.targetText.Location = new System.Drawing.Point(119, 41);
            this.targetText.Name = "targetText";
            this.targetText.Size = new System.Drawing.Size(329, 20);
            this.targetText.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.destinationFolder);
            this.panel1.Controls.Add(this.templateSourceLabel);
            this.panel1.Controls.Add(this.outFolder);
            this.panel1.Controls.Add(this.targetText);
            this.panel1.Controls.Add(this.inFolder);
            this.panel1.Controls.Add(this.sourceText);
            this.panel1.Location = new System.Drawing.Point(8, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 216);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // destinationFolder
            // 
            this.destinationFolder.AutoSize = true;
            this.destinationFolder.Location = new System.Drawing.Point(21, 46);
            this.destinationFolder.Name = "destinationFolder";
            this.destinationFolder.Size = new System.Drawing.Size(92, 13);
            this.destinationFolder.TabIndex = 9;
            this.destinationFolder.Text = "Destination Folder";
            // 
            // templateSourceLabel
            // 
            this.templateSourceLabel.AutoSize = true;
            this.templateSourceLabel.Location = new System.Drawing.Point(25, 19);
            this.templateSourceLabel.Name = "templateSourceLabel";
            this.templateSourceLabel.Size = new System.Drawing.Size(88, 13);
            this.templateSourceLabel.TabIndex = 8;
            this.templateSourceLabel.Text = "Template Source";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 661);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SharePointSetup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

    

        private System.Windows.Forms.Button inFolder;
        private System.Windows.Forms.Button outFolder;
        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.TextBox targetText;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label templateSourceLabel;
        private System.Windows.Forms.Label destinationFolder;
    }
}

