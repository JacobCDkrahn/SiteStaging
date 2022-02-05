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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.inFolder = new System.Windows.Forms.Button();
            this.outFolder = new System.Windows.Forms.Button();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.targetText = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contentsCheckBox = new System.Windows.Forms.CheckBox();
            this.participantCheckBox = new System.Windows.Forms.CheckBox();
            this.actionBoxLabel = new System.Windows.Forms.Label();
            this.renameCheckBox = new System.Windows.Forms.CheckBox();
            this.duplicateCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.destinationBoxLabel = new System.Windows.Forms.Label();
            this.sPDRadio = new System.Windows.Forms.RadioButton();
            this.lDradio = new System.Windows.Forms.RadioButton();
            this.SharePointRoot = new System.Windows.Forms.TextBox();
            this.Site = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.ConnectText = new System.Windows.Forms.Label();
            this.ConnectStatus = new System.Windows.Forms.Label();
            this.ConnectedText = new System.Windows.Forms.Label();
           // this.sPDest = new System.Windows.Forms.Label();
           // this.sPDestText = new System.Windows.Forms.TextBox();
            this.destinationFolder = new System.Windows.Forms.Label();
            this.templateSourceLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.connectPanel = new System.Windows.Forms.Panel();
            this.locationPanel = new System.Windows.Forms.Panel();
           this.sharePointTextBox = new System.Windows.Forms.TextBox();
            this.SharePointURL = new System.Windows.Forms.Label();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.sourceBoxLabel = new System.Windows.Forms.Label();
            this.lSRadio = new System.Windows.Forms.RadioButton();
            this.sPSRadio = new System.Windows.Forms.RadioButton();
            this.varPanel = new System.Windows.Forms.Panel();
            this.participantPanel = new System.Windows.Forms.Panel();
            this.participantSeriesLabel = new System.Windows.Forms.Label();
            this.numParticipantLabel = new System.Windows.Forms.Label();
            this.participantSeries = new System.Windows.Forms.TextBox();
            this.numParticipants = new System.Windows.Forms.TextBox();
            this.varPanelOver = new System.Windows.Forms.Panel();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toProgramBox = new System.Windows.Forms.TextBox();
            this.toMonthBox = new System.Windows.Forms.TextBox();
            this.toSiteBox = new System.Windows.Forms.TextBox();
            this.programLabel = new System.Windows.Forms.Label();
            this.FromProgramBox = new System.Windows.Forms.TextBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.fromMonthBox = new System.Windows.Forms.TextBox();
            this.SiteLabel = new System.Windows.Forms.Label();
            this.fromSiteBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.locationPanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.varPanel.SuspendLayout();
            this.participantPanel.SuspendLayout();
            this.varPanelOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // inFolder
            // 
            this.inFolder.BackColor = System.Drawing.Color.Silver;
            this.inFolder.Location = new System.Drawing.Point(441, 208);
            this.inFolder.Name = "inFolder";
            this.inFolder.Size = new System.Drawing.Size(75, 23);
            this.inFolder.TabIndex = 4;
            this.inFolder.Text = "inFolder";
            this.inFolder.UseVisualStyleBackColor = false;
            this.inFolder.Visible = false;
            this.inFolder.Click += new System.EventHandler(this.inFolder_Click);
            // 
            // outFolder
            // 
            this.outFolder.BackColor = System.Drawing.Color.Silver;
            this.outFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.outFolder.Location = new System.Drawing.Point(441, 234);
            this.outFolder.Name = "outFolder";
            this.outFolder.Size = new System.Drawing.Size(75, 23);
            this.outFolder.TabIndex = 5;
            this.outFolder.Text = "outFolder";
            this.outFolder.UseVisualStyleBackColor = false;
            this.outFolder.Visible = false;
            this.outFolder.Click += new System.EventHandler(this.outFolder_Click_1);
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(110, 210);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(329, 20);
            this.sourceText.TabIndex = 6;
            this.sourceText.Visible = false;
            // 
            // targetText
            // 
            this.targetText.Location = new System.Drawing.Point(110, 235);
            this.targetText.Name = "targetText";
            this.targetText.Size = new System.Drawing.Size(329, 20);
            this.targetText.TabIndex = 7;
            this.targetText.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.inFolder);
            this.panel1.Controls.Add(this.sourceText);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.SharePointRoot);
            this.panel1.Controls.Add(this.Site);
            this.panel1.Controls.Add(this.Execute);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.userNameText);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.ConnectText);
            this.panel1.Controls.Add(this.ConnectStatus);
            this.panel1.Controls.Add(this.ConnectedText);
           // this.panel1.Controls.Add(this.sPDest);
           // this.panel1.Controls.Add(this.sPDestText);
            this.panel1.Controls.Add(this.destinationFolder);
            this.panel1.Controls.Add(this.templateSourceLabel);
            this.panel1.Controls.Add(this.outFolder);
            this.panel1.Controls.Add(this.targetText);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.connectPanel);
            this.panel1.Controls.Add(this.locationPanel);
            this.panel1.Controls.Add(this.optionsPanel);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 449);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.contentsCheckBox);
            this.panel3.Controls.Add(this.participantCheckBox);
            this.panel3.Controls.Add(this.actionBoxLabel);
            this.panel3.Controls.Add(this.renameCheckBox);
            this.panel3.Controls.Add(this.duplicateCheckBox);
            this.panel3.Location = new System.Drawing.Point(278, 297);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 142);
            this.panel3.TabIndex = 36;
            // 
            // contentsCheckBox
            // 
            this.contentsCheckBox.AllowDrop = true;
            this.contentsCheckBox.AutoSize = true;
            this.contentsCheckBox.BackColor = System.Drawing.Color.Silver;
            this.contentsCheckBox.Enabled = false;
            this.contentsCheckBox.Location = new System.Drawing.Point(3, 75);
            this.contentsCheckBox.Name = "contentsCheckBox";
            this.contentsCheckBox.Size = new System.Drawing.Size(111, 17);
            this.contentsCheckBox.TabIndex = 28;
            this.contentsCheckBox.Text = "Rename Contents";
            this.contentsCheckBox.UseVisualStyleBackColor = false;
            // 
            // participantCheckBox
            // 
            this.participantCheckBox.AutoSize = true;
            this.participantCheckBox.BackColor = System.Drawing.Color.Silver;
            this.participantCheckBox.Location = new System.Drawing.Point(3, 98);
            this.participantCheckBox.Name = "participantCheckBox";
            this.participantCheckBox.Size = new System.Drawing.Size(100, 17);
            this.participantCheckBox.TabIndex = 27;
            this.participantCheckBox.Text = "Participant Files";
            this.participantCheckBox.UseVisualStyleBackColor = false;
            this.participantCheckBox.CheckedChanged += new System.EventHandler(this.participantCheckBox_CheckedChanged_1);
            // 
            // actionBoxLabel
            // 
            this.actionBoxLabel.AutoSize = true;
            this.actionBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionBoxLabel.Location = new System.Drawing.Point(19, 0);
            this.actionBoxLabel.Name = "actionBoxLabel";
            this.actionBoxLabel.Size = new System.Drawing.Size(83, 25);
            this.actionBoxLabel.TabIndex = 26;
            this.actionBoxLabel.Text = "Actions";
            // 
            // renameCheckBox
            // 
            this.renameCheckBox.AutoSize = true;
            this.renameCheckBox.BackColor = System.Drawing.Color.Silver;
            this.renameCheckBox.Location = new System.Drawing.Point(3, 52);
            this.renameCheckBox.Name = "renameCheckBox";
            this.renameCheckBox.Size = new System.Drawing.Size(66, 17);
            this.renameCheckBox.TabIndex = 11;
            this.renameCheckBox.Text = "Rename";
            this.renameCheckBox.UseVisualStyleBackColor = false;
            this.renameCheckBox.CheckedChanged += new System.EventHandler(this.renameCheckBox_CheckedChanged);
            // 
            // duplicateCheckBox
            // 
            this.duplicateCheckBox.AutoSize = true;
            this.duplicateCheckBox.BackColor = System.Drawing.Color.Silver;
            this.duplicateCheckBox.Location = new System.Drawing.Point(3, 29);
            this.duplicateCheckBox.Name = "duplicateCheckBox";
            this.duplicateCheckBox.Size = new System.Drawing.Size(71, 17);
            this.duplicateCheckBox.TabIndex = 10;
            this.duplicateCheckBox.Text = "Duplicate";
            this.duplicateCheckBox.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.destinationBoxLabel);
           // this.panel2.Controls.Add(this.sPDRadio);
            this.panel2.Controls.Add(this.lDradio);
            this.panel2.Location = new System.Drawing.Point(143, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 142);
            this.panel2.TabIndex = 35;
            // 
            // destinationBoxLabel
            // 
            this.destinationBoxLabel.AutoSize = true;
            this.destinationBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationBoxLabel.Location = new System.Drawing.Point(2, 0);
            this.destinationBoxLabel.Name = "destinationBoxLabel";
            this.destinationBoxLabel.Size = new System.Drawing.Size(120, 25);
            this.destinationBoxLabel.TabIndex = 25;
            this.destinationBoxLabel.Text = "Destination";
            // 
            // sPDRadio
            // 
            this.sPDRadio.AutoSize = true;
            this.sPDRadio.Location = new System.Drawing.Point(7, 21);
            this.sPDRadio.Name = "sPDRadio";
            this.sPDRadio.Size = new System.Drawing.Size(78, 30);
            this.sPDRadio.TabIndex = 23;
            this.sPDRadio.TabStop = true;
            this.sPDRadio.Text = "SharePoint\r\nDestination";
            this.sPDRadio.UseVisualStyleBackColor = true;
            this.sPDRadio.CheckedChanged += new System.EventHandler(this.sPDRadio_CheckedChanged);
            // 
            // lDradio
            // 
            this.lDradio.AutoSize = true;
            this.lDradio.Location = new System.Drawing.Point(7, 51);
            this.lDradio.Name = "lDradio";
            this.lDradio.Size = new System.Drawing.Size(107, 17);
            this.lDradio.TabIndex = 22;
            this.lDradio.TabStop = true;
            this.lDradio.Text = "Local Destination";
            this.lDradio.UseVisualStyleBackColor = true;
            this.lDradio.CheckedChanged += new System.EventHandler(this.lDradio_CheckedChanged);
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
            this.Site.BackColor = System.Drawing.Color.Silver;
            this.Site.Location = new System.Drawing.Point(12, 34);
            this.Site.Name = "Site";
            this.Site.Size = new System.Drawing.Size(84, 13);
            this.Site.TabIndex = 30;
            this.Site.Text = "Sharepoint Root";
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(408, 297);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(115, 145);
            this.Execute.TabIndex = 14;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
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
            this.password.BackColor = System.Drawing.Color.Silver;
            this.password.Location = new System.Drawing.Point(43, 89);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 27;
            this.password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Silver;
            this.Username.Location = new System.Drawing.Point(40, 59);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 26;
            this.Username.Text = "Username";
            // 
            // ConnectText
            // 
            this.ConnectText.AutoSize = true;
            this.ConnectText.BackColor = System.Drawing.Color.Silver;
            this.ConnectText.Location = new System.Drawing.Point(68, 128);
            this.ConnectText.Name = "ConnectText";
            this.ConnectText.Size = new System.Drawing.Size(118, 13);
            this.ConnectText.TabIndex = 24;
            this.ConnectText.Text = "Connect To SharePoint";
            // 
            // ConnectStatus
            // 
            this.ConnectStatus.AutoSize = true;
            this.ConnectStatus.BackColor = System.Drawing.Color.Silver;
            this.ConnectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectStatus.ForeColor = System.Drawing.Color.Red;
            this.ConnectStatus.Location = new System.Drawing.Point(438, 126);
            this.ConnectStatus.Name = "ConnectStatus";
            this.ConnectStatus.Size = new System.Drawing.Size(32, 20);
            this.ConnectStatus.TabIndex = 23;
            this.ConnectStatus.Text = "NO";
            this.ConnectStatus.UseMnemonic = false;
            // 
            // ConnectedText
            // 
            this.ConnectedText.AutoSize = true;
            this.ConnectedText.BackColor = System.Drawing.Color.Silver;
            this.ConnectedText.Location = new System.Drawing.Point(318, 128);
            this.ConnectedText.Name = "ConnectedText";
            this.ConnectedText.Size = new System.Drawing.Size(114, 13);
            this.ConnectedText.TabIndex = 22;
            this.ConnectedText.Text = "SharePoint Connected";
            // 
            // sPDest
            // 
           // this.sPDest.AutoSize = true;
            //this.sPDest.BackColor = System.Drawing.Color.Silver;
            //this.sPDest.Location = new System.Drawing.Point(44, 232);
            //this.sPDest.Name = "sPDest";
            //this.sPDest.Size = new System.Drawing.Size(60, 26);
            //this.sPDest.TabIndex = 19;
           // this.sPDest.Text = "SharePoint\r\nDestination";
           // this.sPDest.Visible = false;
            // 
            // sPDestText
            // 
           //this.sPDestText.Location = new System.Drawing.Point(110, 234);
            //this.sPDestText.Name = "sPDestText";
            //this.sPDestText.Size = new System.Drawing.Size(329, 20);
            //this.sPDestText.TabIndex = 18;
            //this.sPDestText.Visible = false;
            // 
            // destinationFolder
            // 
            this.destinationFolder.AutoSize = true;
            this.destinationFolder.BackColor = System.Drawing.Color.Silver;
            this.destinationFolder.Location = new System.Drawing.Point(15, 239);
            this.destinationFolder.Name = "destinationFolder";
            this.destinationFolder.Size = new System.Drawing.Size(92, 13);
            this.destinationFolder.TabIndex = 9;
            this.destinationFolder.Text = "Destination Folder";
            this.destinationFolder.Visible = false;
            // 
            // templateSourceLabel
            // 
            this.templateSourceLabel.AutoSize = true;
            this.templateSourceLabel.BackColor = System.Drawing.Color.Silver;
            this.templateSourceLabel.Location = new System.Drawing.Point(34, 213);
            this.templateSourceLabel.Name = "templateSourceLabel";
            this.templateSourceLabel.Size = new System.Drawing.Size(70, 13);
            this.templateSourceLabel.TabIndex = 8;
            this.templateSourceLabel.Text = "Local Source";
            this.templateSourceLabel.Visible = false;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Silver;
            this.connectButton.Location = new System.Drawing.Point(192, 123);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 25;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // connectPanel
            // 
            this.connectPanel.BackColor = System.Drawing.Color.Silver;
            this.connectPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.connectPanel.Location = new System.Drawing.Point(9, 4);
            this.connectPanel.Name = "connectPanel";
            this.connectPanel.Size = new System.Drawing.Size(514, 160);
            this.connectPanel.TabIndex = 32;
            // 
            // locationPanel
            // 
            this.locationPanel.BackColor = System.Drawing.Color.Silver;
            this.locationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.locationPanel.Controls.Add(this.sharePointTextBox);
           this.locationPanel.Controls.Add(this.SharePointURL);
            this.locationPanel.Location = new System.Drawing.Point(9, 170);
            this.locationPanel.Name = "locationPanel";
            this.locationPanel.Size = new System.Drawing.Size(514, 120);
            this.locationPanel.TabIndex = 33;
            // 
            // sharePointTextBox
            // 
          this.sharePointTextBox.Location = new System.Drawing.Point(99, 39);
           this.sharePointTextBox.Name = "sharePointTextBox";
          this.sharePointTextBox.Size = new System.Drawing.Size(329, 20);
          this.sharePointTextBox.TabIndex = 16;
          this.sharePointTextBox.Text = "https://jacobkrahn.sharepoint.com/sites/SiteStaging/Shared%20Documents/TestFolder" +
    "";
           this.sharePointTextBox.Visible = false;
            // 
            // SharePointURL
            // 
            this.SharePointURL.AutoSize = true;
            this.SharePointURL.BackColor = System.Drawing.Color.Silver;
            this.SharePointURL.Location = new System.Drawing.Point(4, 41);
            this.SharePointURL.Name = "SharePointURL";
            this.SharePointURL.Size = new System.Drawing.Size(96, 13);
            this.SharePointURL.TabIndex = 15;
            this.SharePointURL.Text = "SharePoint Source";
            this.SharePointURL.Visible = false;
       
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.Silver;
            this.optionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.optionsPanel.Controls.Add(this.sourceBoxLabel);
            this.optionsPanel.Controls.Add(this.lSRadio);
            this.optionsPanel.Controls.Add(this.sPSRadio);
            this.optionsPanel.Location = new System.Drawing.Point(9, 297);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(124, 142);
            this.optionsPanel.TabIndex = 34;
            // 
            // sourceBoxLabel
            // 
            this.sourceBoxLabel.AutoSize = true;
            this.sourceBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceBoxLabel.Location = new System.Drawing.Point(19, 0);
            this.sourceBoxLabel.Name = "sourceBoxLabel";
            this.sourceBoxLabel.Size = new System.Drawing.Size(80, 25);
            this.sourceBoxLabel.TabIndex = 24;
            this.sourceBoxLabel.Text = "Source";
            // 
            // lSRadio
            // 
            this.lSRadio.AutoSize = true;
            this.lSRadio.Location = new System.Drawing.Point(7, 51);
            this.lSRadio.Name = "lSRadio";
            this.lSRadio.Size = new System.Drawing.Size(88, 17);
            this.lSRadio.TabIndex = 23;
            this.lSRadio.TabStop = true;
            this.lSRadio.Text = "Local Source";
            this.lSRadio.UseVisualStyleBackColor = true;
            this.lSRadio.CheckedChanged += new System.EventHandler(this.lSRadio_CheckedChanged);
            // 
            // sPSRadio
            // 
            this.sPSRadio.AutoSize = true;
            this.sPSRadio.Location = new System.Drawing.Point(8, 28);
            this.sPSRadio.Name = "sPSRadio";
            this.sPSRadio.Size = new System.Drawing.Size(114, 17);
            this.sPSRadio.TabIndex = 22;
            this.sPSRadio.TabStop = true;
            this.sPSRadio.Text = "SharePoint Source";
            this.sPSRadio.UseVisualStyleBackColor = true;
            this.sPSRadio.CheckedChanged += new System.EventHandler(this.sPSRadio_CheckedChanged);
            // 
            // varPanel
            // 
            this.varPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.varPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.varPanel.Controls.Add(this.participantPanel);
            this.varPanel.Controls.Add(this.varPanelOver);
            this.varPanel.Location = new System.Drawing.Point(531, 1);
            this.varPanel.Name = "varPanel";
            this.varPanel.Size = new System.Drawing.Size(414, 449);
            this.varPanel.TabIndex = 9;
            this.varPanel.Visible = false;
            // 
            // participantPanel
            // 
            this.participantPanel.BackColor = System.Drawing.Color.Silver;
            this.participantPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.participantPanel.Controls.Add(this.participantSeriesLabel);
            this.participantPanel.Controls.Add(this.numParticipantLabel);
            this.participantPanel.Controls.Add(this.participantSeries);
            this.participantPanel.Controls.Add(this.numParticipants);
            this.participantPanel.Location = new System.Drawing.Point(11, 250);
            this.participantPanel.Name = "participantPanel";
            this.participantPanel.Size = new System.Drawing.Size(385, 192);
            this.participantPanel.TabIndex = 7;
            this.participantPanel.Visible = false;
            // 
            // participantSeriesLabel
            // 
            this.participantSeriesLabel.AutoSize = true;
            this.participantSeriesLabel.Location = new System.Drawing.Point(7, 36);
            this.participantSeriesLabel.Name = "participantSeriesLabel";
            this.participantSeriesLabel.Size = new System.Drawing.Size(89, 13);
            this.participantSeriesLabel.TabIndex = 3;
            this.participantSeriesLabel.Text = "Participant Series";
            // 
            // numParticipantLabel
            // 
            this.numParticipantLabel.AutoSize = true;
            this.numParticipantLabel.Location = new System.Drawing.Point(34, 5);
            this.numParticipantLabel.Name = "numParticipantLabel";
            this.numParticipantLabel.Size = new System.Drawing.Size(62, 26);
            this.numParticipantLabel.TabIndex = 2;
            this.numParticipantLabel.Text = "Number Of \r\nParticipants";
            // 
            // participantSeries
            // 
            this.participantSeries.Location = new System.Drawing.Point(102, 33);
            this.participantSeries.Name = "participantSeries";
            this.participantSeries.Size = new System.Drawing.Size(100, 20);
            this.participantSeries.TabIndex = 1;
            this.participantSeries.Text = "100";
            // 
            // numParticipants
            // 
            this.numParticipants.Location = new System.Drawing.Point(102, 7);
            this.numParticipants.Name = "numParticipants";
            this.numParticipants.Size = new System.Drawing.Size(100, 20);
            this.numParticipants.TabIndex = 0;
            this.numParticipants.Text = "25";
            // 
            // varPanelOver
            // 
            this.varPanelOver.BackColor = System.Drawing.Color.Silver;
            this.varPanelOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.varPanelOver.Controls.Add(this.toLabel);
            this.varPanelOver.Controls.Add(this.fromLabel);
            this.varPanelOver.Controls.Add(this.toProgramBox);
            this.varPanelOver.Controls.Add(this.toMonthBox);
            this.varPanelOver.Controls.Add(this.toSiteBox);
            this.varPanelOver.Controls.Add(this.programLabel);
            this.varPanelOver.Controls.Add(this.FromProgramBox);
            this.varPanelOver.Controls.Add(this.monthLabel);
            this.varPanelOver.Controls.Add(this.fromMonthBox);
            this.varPanelOver.Controls.Add(this.SiteLabel);
            this.varPanelOver.Controls.Add(this.fromSiteBox);
            this.varPanelOver.Location = new System.Drawing.Point(11, 4);
            this.varPanelOver.Name = "varPanelOver";
            this.varPanelOver.Size = new System.Drawing.Size(385, 240);
            this.varPanelOver.TabIndex = 6;
            this.varPanelOver.Visible = false;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(218, 17);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(22, 13);
            this.toLabel.TabIndex = 10;
            this.toLabel.Text = "TO";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(102, 17);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(38, 13);
            this.fromLabel.TabIndex = 9;
            this.fromLabel.Text = "FROM";
            // 
            // toProgramBox
            // 
            this.toProgramBox.Location = new System.Drawing.Point(190, 93);
            this.toProgramBox.Name = "toProgramBox";
            this.toProgramBox.Size = new System.Drawing.Size(119, 20);
            this.toProgramBox.TabIndex = 8;
            this.toProgramBox.Text = "Program Name Here";
            // 
            // toMonthBox
            // 
            this.toMonthBox.Location = new System.Drawing.Point(190, 64);
            this.toMonthBox.Name = "toMonthBox";
            this.toMonthBox.Size = new System.Drawing.Size(119, 20);
            this.toMonthBox.TabIndex = 7;
            this.toMonthBox.Text = "Month Name Here";
            // 
            // toSiteBox
            // 
            this.toSiteBox.Location = new System.Drawing.Point(190, 36);
            this.toSiteBox.Name = "toSiteBox";
            this.toSiteBox.Size = new System.Drawing.Size(119, 20);
            this.toSiteBox.TabIndex = 6;
            this.toSiteBox.Text = "Sitename Here";
            // 
            // programLabel
            // 
            this.programLabel.AutoSize = true;
            this.programLabel.BackColor = System.Drawing.Color.Silver;
            this.programLabel.Location = new System.Drawing.Point(6, 96);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(46, 13);
            this.programLabel.TabIndex = 5;
            this.programLabel.Text = "Program";
            // 
            // FromProgramBox
            // 
            this.FromProgramBox.Location = new System.Drawing.Point(65, 93);
            this.FromProgramBox.Name = "FromProgramBox";
            this.FromProgramBox.Size = new System.Drawing.Size(119, 20);
            this.FromProgramBox.TabIndex = 4;
            this.FromProgramBox.Text = "_PROGRAM_";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.Color.Silver;
            this.monthLabel.Location = new System.Drawing.Point(6, 67);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(37, 13);
            this.monthLabel.TabIndex = 3;
            this.monthLabel.Text = "Month";
            // 
            // fromMonthBox
            // 
            this.fromMonthBox.Location = new System.Drawing.Point(65, 64);
            this.fromMonthBox.Name = "fromMonthBox";
            this.fromMonthBox.Size = new System.Drawing.Size(119, 20);
            this.fromMonthBox.TabIndex = 2;
            this.fromMonthBox.Text = "_MONTH_";
            // 
            // SiteLabel
            // 
            this.SiteLabel.AutoSize = true;
            this.SiteLabel.BackColor = System.Drawing.Color.Silver;
            this.SiteLabel.Location = new System.Drawing.Point(6, 39);
            this.SiteLabel.Name = "SiteLabel";
            this.SiteLabel.Size = new System.Drawing.Size(53, 13);
            this.SiteLabel.TabIndex = 1;
            this.SiteLabel.Text = "SiteName";
            // 
            // fromSiteBox
            // 
            this.fromSiteBox.Location = new System.Drawing.Point(65, 36);
            this.fromSiteBox.Name = "fromSiteBox";
            this.fromSiteBox.Size = new System.Drawing.Size(119, 20);
            this.fromSiteBox.TabIndex = 0;
            this.fromSiteBox.Text = "_SITE_";
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.varPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Base";
            this.Text = "SharePointSetup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.locationPanel.ResumeLayout(false);
            this.locationPanel.PerformLayout();
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.varPanel.ResumeLayout(false);
            this.participantPanel.ResumeLayout(false);
            this.participantPanel.PerformLayout();
            this.varPanelOver.ResumeLayout(false);
            this.varPanelOver.PerformLayout();
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
        private System.Windows.Forms.CheckBox renameCheckBox;
        private System.Windows.Forms.CheckBox duplicateCheckBox;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Panel varPanel;
        private System.Windows.Forms.Label SiteLabel;
        private System.Windows.Forms.TextBox fromSiteBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.TextBox fromMonthBox;
        private System.Windows.Forms.Label programLabel;
        private System.Windows.Forms.TextBox FromProgramBox;
        private System.Windows.Forms.Label SharePointURL;
        private System.Windows.Forms.TextBox sharePointTextBox;
        private System.Windows.Forms.Label sPDest;
        private System.Windows.Forms.TextBox sPDestText;
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
        private System.Windows.Forms.Panel connectPanel;
        private System.Windows.Forms.Panel locationPanel;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Panel varPanelOver;
        private System.Windows.Forms.RadioButton lSRadio;
        private System.Windows.Forms.RadioButton sPSRadio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton sPDRadio;
        private System.Windows.Forms.RadioButton lDradio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label sourceBoxLabel;
        private System.Windows.Forms.Label actionBoxLabel;
        private System.Windows.Forms.Label destinationBoxLabel;
        private System.Windows.Forms.CheckBox participantCheckBox;
        private System.Windows.Forms.Panel participantPanel;
        private System.Windows.Forms.Label numParticipantLabel;
        private System.Windows.Forms.TextBox participantSeries;
        private System.Windows.Forms.TextBox numParticipants;
        private System.Windows.Forms.Label participantSeriesLabel;
        private System.Windows.Forms.CheckBox contentsCheckBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox toProgramBox;
        private System.Windows.Forms.TextBox toMonthBox;
        private System.Windows.Forms.TextBox toSiteBox;
    }
}

