namespace WindowsFormsApp1
{
    partial class Base
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
            this.duplicateCheckBox = new System.Windows.Forms.CheckBox();
            this.renameCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.Execute = new System.Windows.Forms.Button();
            this.varPanel = new System.Windows.Forms.Panel();
            this.siteBox = new System.Windows.Forms.TextBox();
            this.SiteLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.programLabel = new System.Windows.Forms.Label();
            this.programBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.varPanel.SuspendLayout();
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
            this.panel1.Controls.Add(this.Execute);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.renameCheckBox);
            this.panel1.Controls.Add(this.duplicateCheckBox);
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
            // duplicateCheckBox
            // 
            this.duplicateCheckBox.AutoSize = true;
            this.duplicateCheckBox.Location = new System.Drawing.Point(63, 87);
            this.duplicateCheckBox.Name = "duplicateCheckBox";
            this.duplicateCheckBox.Size = new System.Drawing.Size(71, 17);
            this.duplicateCheckBox.TabIndex = 10;
            this.duplicateCheckBox.Text = "Duplicate";
            this.duplicateCheckBox.UseVisualStyleBackColor = true;
            this.duplicateCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // renameCheckBox
            // 
            this.renameCheckBox.AutoSize = true;
            this.renameCheckBox.Location = new System.Drawing.Point(63, 111);
            this.renameCheckBox.Name = "renameCheckBox";
            this.renameCheckBox.Size = new System.Drawing.Size(66, 17);
            this.renameCheckBox.TabIndex = 11;
            this.renameCheckBox.Text = "Rename";
            this.renameCheckBox.UseVisualStyleBackColor = true;
            this.renameCheckBox.CheckedChanged += new System.EventHandler(this.renameCheckBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(63, 135);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(63, 159);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(452, 159);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(75, 51);
            this.Execute.TabIndex = 14;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // varPanel
            // 
            this.varPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.varPanel.Controls.Add(this.programLabel);
            this.varPanel.Controls.Add(this.programBox);
            this.varPanel.Controls.Add(this.monthLabel);
            this.varPanel.Controls.Add(this.monthBox);
            this.varPanel.Controls.Add(this.SiteLabel);
            this.varPanel.Controls.Add(this.siteBox);
            this.varPanel.Location = new System.Drawing.Point(546, 11);
            this.varPanel.Name = "varPanel";
            this.varPanel.Size = new System.Drawing.Size(394, 216);
            this.varPanel.TabIndex = 9;
            this.varPanel.Visible = false;
            // 
            // siteBox
            // 
            this.siteBox.Location = new System.Drawing.Point(117, 16);
            this.siteBox.Name = "siteBox";
            this.siteBox.Size = new System.Drawing.Size(119, 20);
            this.siteBox.TabIndex = 0;
            this.siteBox.Text = "Sitename Here";
            // 
            // SiteLabel
            // 
            this.SiteLabel.AutoSize = true;
            this.SiteLabel.Location = new System.Drawing.Point(58, 19);
            this.SiteLabel.Name = "SiteLabel";
            this.SiteLabel.Size = new System.Drawing.Size(53, 13);
            this.SiteLabel.TabIndex = 1;
            this.SiteLabel.Text = "SiteName";
            this.SiteLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(58, 47);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(37, 13);
            this.monthLabel.TabIndex = 3;
            this.monthLabel.Text = "Month";
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(117, 44);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(119, 20);
            this.monthBox.TabIndex = 2;
            this.monthBox.Text = "Month Name Here";
            // 
            // programLabel
            // 
            this.programLabel.AutoSize = true;
            this.programLabel.Location = new System.Drawing.Point(58, 76);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(46, 13);
            this.programLabel.TabIndex = 5;
            this.programLabel.Text = "Program";
            this.programLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // programBox
            // 
            this.programBox.Location = new System.Drawing.Point(117, 73);
            this.programBox.Name = "programBox";
            this.programBox.Size = new System.Drawing.Size(119, 20);
            this.programBox.TabIndex = 4;
            this.programBox.Text = "Program Name Here";
            this.programBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 237);
            this.Controls.Add(this.varPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Base";
            this.Text = "SharePointSetup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.varPanel.ResumeLayout(false);
            this.varPanel.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox renameCheckBox;
        private System.Windows.Forms.CheckBox duplicateCheckBox;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Panel varPanel;
        private System.Windows.Forms.Label SiteLabel;
        private System.Windows.Forms.TextBox siteBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.Label programLabel;
        private System.Windows.Forms.TextBox programBox;
    }
}

