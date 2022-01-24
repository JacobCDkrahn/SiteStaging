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
            this.sharePointTextBox = new System.Windows.Forms.TextBox();
            this.SharePointURL = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.localSourceCheckBox = new System.Windows.Forms.CheckBox();
            this.sPSourceCheckBox = new System.Windows.Forms.CheckBox();
            this.renameCheckBox = new System.Windows.Forms.CheckBox();
            this.duplicateCheckBox = new System.Windows.Forms.CheckBox();
            this.destinationFolder = new System.Windows.Forms.Label();
            this.templateSourceLabel = new System.Windows.Forms.Label();
            this.varPanel = new System.Windows.Forms.Panel();
            this.programLabel = new System.Windows.Forms.Label();
            this.programBox = new System.Windows.Forms.TextBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.SiteLabel = new System.Windows.Forms.Label();
            this.siteBox = new System.Windows.Forms.TextBox();
            this.sPDest = new System.Windows.Forms.Label();
            this.sPDestText = new System.Windows.Forms.TextBox();
            this.localDestCheck = new System.Windows.Forms.CheckBox();
            this.sPDestCheck = new System.Windows.Forms.CheckBox();
            this.ConnectedText = new System.Windows.Forms.Label();
            this.ConnectStatus = new System.Windows.Forms.Label();
            this.ConnectText = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.SharePointRoot = new System.Windows.Forms.TextBox();
            this.Site = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.varPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inFolder
            // 
            this.inFolder.Location = new System.Drawing.Point(445, 196);
            this.inFolder.Name = "inFolder";
            this.inFolder.Size = new System.Drawing.Size(75, 23);
            this.inFolder.TabIndex = 4;
            this.inFolder.Text = "inFolder";
            this.inFolder.UseVisualStyleBackColor = true;
            this.inFolder.Click += new System.EventHandler(this.inFolder_Click);
            // 
            // outFolder
            // 
            this.outFolder.Location = new System.Drawing.Point(445, 248);
            this.outFolder.Name = "outFolder";
            this.outFolder.Size = new System.Drawing.Size(75, 23);
            this.outFolder.TabIndex = 5;
            this.outFolder.Text = "outFolder";
            this.outFolder.UseVisualStyleBackColor = true;
            this.outFolder.Click += new System.EventHandler(this.outFolder_Click_1);
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(110, 196);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(329, 20);
            this.sourceText.TabIndex = 6;
            this.sourceText.TextChanged += new System.EventHandler(this.SourceFolder_TextChanged);
            // 
            // targetText
            // 
            this.targetText.Location = new System.Drawing.Point(110, 248);
            this.targetText.Name = "targetText";
            this.targetText.Size = new System.Drawing.Size(329, 20);
            this.targetText.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SharePointRoot);
            this.panel1.Controls.Add(this.Site);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.userNameText);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.ConnectText);
            this.panel1.Controls.Add(this.ConnectStatus);
            this.panel1.Controls.Add(this.ConnectedText);
            this.panel1.Controls.Add(this.localDestCheck);
            this.panel1.Controls.Add(this.sPDestCheck);
            this.panel1.Controls.Add(this.sPDest);
            this.panel1.Controls.Add(this.sPDestText);
            this.panel1.Controls.Add(this.sharePointTextBox);
            this.panel1.Controls.Add(this.SharePointURL);
            this.panel1.Controls.Add(this.Execute);
            this.panel1.Controls.Add(this.localSourceCheckBox);
            this.panel1.Controls.Add(this.sPSourceCheckBox);
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
            this.panel1.Size = new System.Drawing.Size(532, 449);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sharePointTextBox
            // 
            this.sharePointTextBox.Location = new System.Drawing.Point(110, 170);
            this.sharePointTextBox.Name = "sharePointTextBox";
            this.sharePointTextBox.Size = new System.Drawing.Size(329, 20);
            this.sharePointTextBox.TabIndex = 16;
            this.sharePointTextBox.Text = "https://jacobkrahn.sharepoint.com/sites/SiteStaging/Shared%20Documents/TestFolder" +
    "";
            this.sharePointTextBox.TextChanged += new System.EventHandler(this.sharePointTextBox_TextChanged);
            // 
            // SharePointURL
            // 
            this.SharePointURL.AutoSize = true;
            this.SharePointURL.Location = new System.Drawing.Point(8, 174);
            this.SharePointURL.Name = "SharePointURL";
            this.SharePointURL.Size = new System.Drawing.Size(96, 13);
            this.SharePointURL.TabIndex = 15;
            this.SharePointURL.Text = "SharePoint Source";
            this.SharePointURL.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(447, 315);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(75, 51);
            this.Execute.TabIndex = 14;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // localSourceCheckBox
            // 
            this.localSourceCheckBox.AutoSize = true;
            this.localSourceCheckBox.Location = new System.Drawing.Point(15, 317);
            this.localSourceCheckBox.Name = "localSourceCheckBox";
            this.localSourceCheckBox.Size = new System.Drawing.Size(89, 17);
            this.localSourceCheckBox.TabIndex = 13;
            this.localSourceCheckBox.Text = "Local Source";
            this.localSourceCheckBox.UseVisualStyleBackColor = true;
            this.localSourceCheckBox.CheckedChanged += new System.EventHandler(this.templateCheckBox_CheckedChanged);
            // 
            // sPSourceCheckBox
            // 
            this.sPSourceCheckBox.AutoSize = true;
            this.sPSourceCheckBox.Location = new System.Drawing.Point(15, 294);
            this.sPSourceCheckBox.Name = "sPSourceCheckBox";
            this.sPSourceCheckBox.Size = new System.Drawing.Size(115, 17);
            this.sPSourceCheckBox.TabIndex = 12;
            this.sPSourceCheckBox.Text = "SharePoint Source";
            this.sPSourceCheckBox.UseVisualStyleBackColor = true;
            this.sPSourceCheckBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // renameCheckBox
            // 
            this.renameCheckBox.AutoSize = true;
            this.renameCheckBox.Location = new System.Drawing.Point(301, 317);
            this.renameCheckBox.Name = "renameCheckBox";
            this.renameCheckBox.Size = new System.Drawing.Size(66, 17);
            this.renameCheckBox.TabIndex = 11;
            this.renameCheckBox.Text = "Rename";
            this.renameCheckBox.UseVisualStyleBackColor = true;
            this.renameCheckBox.CheckedChanged += new System.EventHandler(this.renameCheckBox_CheckedChanged);
            // 
            // duplicateCheckBox
            // 
            this.duplicateCheckBox.AutoSize = true;
            this.duplicateCheckBox.Location = new System.Drawing.Point(301, 296);
            this.duplicateCheckBox.Name = "duplicateCheckBox";
            this.duplicateCheckBox.Size = new System.Drawing.Size(71, 17);
            this.duplicateCheckBox.TabIndex = 10;
            this.duplicateCheckBox.Text = "Duplicate";
            this.duplicateCheckBox.UseVisualStyleBackColor = true;
            this.duplicateCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // destinationFolder
            // 
            this.destinationFolder.AutoSize = true;
            this.destinationFolder.Location = new System.Drawing.Point(12, 253);
            this.destinationFolder.Name = "destinationFolder";
            this.destinationFolder.Size = new System.Drawing.Size(92, 13);
            this.destinationFolder.TabIndex = 9;
            this.destinationFolder.Text = "Destination Folder";
            // 
            // templateSourceLabel
            // 
            this.templateSourceLabel.AutoSize = true;
            this.templateSourceLabel.Location = new System.Drawing.Point(34, 199);
            this.templateSourceLabel.Name = "templateSourceLabel";
            this.templateSourceLabel.Size = new System.Drawing.Size(70, 13);
            this.templateSourceLabel.TabIndex = 8;
            this.templateSourceLabel.Text = "Local Source";
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
            this.varPanel.Size = new System.Drawing.Size(394, 449);
            this.varPanel.TabIndex = 9;
            this.varPanel.Visible = false;
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
            // siteBox
            // 
            this.siteBox.Location = new System.Drawing.Point(117, 16);
            this.siteBox.Name = "siteBox";
            this.siteBox.Size = new System.Drawing.Size(119, 20);
            this.siteBox.TabIndex = 0;
            this.siteBox.Text = "Sitename Here";
            // 
            // sPDest
            // 
            this.sPDest.AutoSize = true;
            this.sPDest.Location = new System.Drawing.Point(44, 222);
            this.sPDest.Name = "sPDest";
            this.sPDest.Size = new System.Drawing.Size(60, 26);
            this.sPDest.TabIndex = 19;
            this.sPDest.Text = "SharePoint\r\nDestination";
            // 
            // sPDestText
            // 
            this.sPDestText.Location = new System.Drawing.Point(110, 224);
            this.sPDestText.Name = "sPDestText";
            this.sPDestText.Size = new System.Drawing.Size(329, 20);
            this.sPDestText.TabIndex = 18;
            // 
            // localDestCheck
            // 
            this.localDestCheck.AutoSize = true;
            this.localDestCheck.Location = new System.Drawing.Point(156, 317);
            this.localDestCheck.Name = "localDestCheck";
            this.localDestCheck.Size = new System.Drawing.Size(108, 17);
            this.localDestCheck.TabIndex = 21;
            this.localDestCheck.Text = "Local Destination";
            this.localDestCheck.UseVisualStyleBackColor = true;
            this.localDestCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // sPDestCheck
            // 
            this.sPDestCheck.AutoSize = true;
            this.sPDestCheck.Location = new System.Drawing.Point(156, 294);
            this.sPDestCheck.Name = "sPDestCheck";
            this.sPDestCheck.Size = new System.Drawing.Size(134, 17);
            this.sPDestCheck.TabIndex = 20;
            this.sPDestCheck.Text = "SharePoint Destination";
            this.sPDestCheck.UseVisualStyleBackColor = true;
            this.sPDestCheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ConnectedText
            // 
            this.ConnectedText.AutoSize = true;
            this.ConnectedText.Location = new System.Drawing.Point(318, 128);
            this.ConnectedText.Name = "ConnectedText";
            this.ConnectedText.Size = new System.Drawing.Size(114, 13);
            this.ConnectedText.TabIndex = 22;
            this.ConnectedText.Text = "SharePoint Connected";
            this.ConnectedText.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // ConnectStatus
            // 
            this.ConnectStatus.AutoSize = true;
            this.ConnectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectStatus.ForeColor = System.Drawing.Color.Red;
            this.ConnectStatus.Location = new System.Drawing.Point(438, 121);
            this.ConnectStatus.Name = "ConnectStatus";
            this.ConnectStatus.Size = new System.Drawing.Size(32, 20);
            this.ConnectStatus.TabIndex = 23;
            this.ConnectStatus.Text = "NO";
            this.ConnectStatus.UseMnemonic = false;
            // 
            // ConnectText
            // 
            this.ConnectText.AutoSize = true;
            this.ConnectText.Location = new System.Drawing.Point(68, 128);
            this.ConnectText.Name = "ConnectText";
            this.ConnectText.Size = new System.Drawing.Size(118, 13);
            this.ConnectText.TabIndex = 24;
            this.ConnectText.Text = "Connect To SharePoint";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(189, 123);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 25;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // SharePointRoot
            // 
            this.SharePointRoot.Location = new System.Drawing.Point(102, 31);
            this.SharePointRoot.Name = "SharePointRoot";
            this.SharePointRoot.Size = new System.Drawing.Size(220, 20);
            this.SharePointRoot.TabIndex = 31;
            this.SharePointRoot.Text = "https://jacobkrahn.sharepoint.com/sites/SiteStaging/";
            // 
            // Site
            // 
            this.Site.AutoSize = true;
            this.Site.Location = new System.Drawing.Point(12, 34);
            this.Site.Name = "Site";
            this.Site.Size = new System.Drawing.Size(84, 13);
            this.Site.TabIndex = 30;
            this.Site.Text = "Sharepoint Root";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(102, 89);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(220, 20);
            this.passwordBox.TabIndex = 29;
            this.passwordBox.Text = "B4ssmasta";
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(102, 59);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(220, 20);
            this.userNameText.TabIndex = 28;
            this.userNameText.Text = "jacobkrahn@jacobkrahn.onmicrosoft.com";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(43, 89);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 27;
            this.password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(40, 59);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 26;
            this.Username.Text = "Username";
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 464);
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
        private System.Windows.Forms.CheckBox localSourceCheckBox;
        private System.Windows.Forms.CheckBox sPSourceCheckBox;
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
        private System.Windows.Forms.Label SharePointURL;
        private System.Windows.Forms.TextBox sharePointTextBox;
        private System.Windows.Forms.Label sPDest;
        private System.Windows.Forms.TextBox sPDestText;
        private System.Windows.Forms.CheckBox localDestCheck;
        private System.Windows.Forms.CheckBox sPDestCheck;
        private System.Windows.Forms.Label ConnectedText;
        private System.Windows.Forms.Label ConnectStatus;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label ConnectText;
        private System.Windows.Forms.TextBox SharePointRoot;
        private System.Windows.Forms.Label Site;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Username;
    }
}

