using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.SharePoint;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;





using Form = System.Windows.Forms.Form;

namespace WindowsFormsApp1
{
    public partial class Base : Form
    {
        ClientContext context;
        public Base()
        {
            InitializeComponent();
        }

      

  
      

     
        private void inFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.sourceText.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void outFolder_Click_1(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.targetText.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

  

        private void Execute_Click(object sender, EventArgs e)
        {
            bool spSource = sPSRadio.Checked;
            string spSourcePath = sharePointTextBox.Text;
            bool spDest = sPDRadio.Checked;
            bool duplicate = duplicateCheckBox.Checked;
            bool participant = participantCheckBox.Checked;
            bool rename= renameCheckBox.Checked;    
            bool sourceVerified = false;
            bool targetVerified = false;
            bool contents = contentsCheckBox.Checked;
            string source="";
            string target="";
            int pCount = 0;
            int pSeries = 0;

            if (participant) {
                 pCount=int.Parse(numParticipants.Text);
                 pSeries = int.Parse(participantSeries.Text);
            }
       //Source Verification
            if (spSource) {
                source = sharePointTextBox.Text;
            }else{ 
            source=sourceText.Text; 
            }
            if (source.Length > 0) { 
            sourceVerified=true;
            }
            //Dest Verification
            if (spDest) {
                target = sPDestText.Text;
            }
            else { target=targetText.Text; }
            if (target.Length > 0)
            {
                targetVerified = true;
            }
    

            if ( (sourceVerified== false || targetVerified== false) && duplicateCheckBox.Checked == true)
            {
                MessageBox.Show(" You must Select a Source and a Target.","Error");

            }


            if(sourceVerified && targetVerified)
            {
                if (spSource || spDest)
                {
                    if (ConnectStatus.Text == "NO")
                    {

                        MessageBox.Show("You must connect to SharePoint");
                    }
                    if (spDest)
                    {
                        target = "C:\\temp\\sharepointTemp\\";
                        Directory.CreateDirectory(target);
                    }
                }
                //Action handlers
                if (duplicate || participant)
                {
                    if (spSource)
                    {
                        if (!(participant))
                        {
                            downloadSharepoint(target,spSourcePath);
                        }
                        if (participant)
                        {
                            downloadSharepoint("C:\\temp\\sharepointTemp\\",spSourcePath);
                            Program.duplicate("C:\\temp\\sharepointTemp\\", target, duplicate, pCount, pSeries);
                            Directory.Delete("C:\\temp\\sharepointTemp\\",true);
                        }
                    }
                    else
                    {

                        if (participant)
                        {
                            Program.duplicate(source, target, duplicate, pCount, pSeries);
                        }
                        else
                        {
                            Program.duplicate(source, target);
                        }

                    }
                }
                    
                 //   if (spDest) {
                   // Program.rename(fromSiteBox.Text, fromMonthBox.Text, FromProgramBox.Text,toSiteBox.Text,toMonthBox.Text,toProgramBox.Text, target);
                    //

                    
                    //}

                    if (targetVerified && renameCheckBox.Checked)
                    {
                    if (spSource) {
                        downloadSharepoint(target, spSourcePath) ;
                    }
                    Program.rename(contents,fromSiteBox.Text, fromMonthBox.Text, FromProgramBox.Text, toSiteBox.Text, toMonthBox.Text, toProgramBox.Text, target);

                }

                if (spDest)
                {
                  
              
                }

            }
        }


    



        private void renameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (renameCheckBox.Checked)
            {
                contentsCheckBox.Enabled = true;
                varPanel.Visible = true;
                varPanelOver.Visible= true;
                base.Size = new Size(955, 491);
            }
            else
            {
                contentsCheckBox.Enabled = false;
                varPanelOver.Visible = false;
                if (participantPanel.Visible == false)
                {
                    varPanel.Visible = false;
                    base.Size = new Size(554, 491);
                }            }
        }

 

        private void connectButton_Click(object sender, EventArgs e)
        {



            connect();
            passwordBox.Text = "*********";
            
        }
        private void connect() {


            context = new ClientContext(SharePointRoot.Text);
            SecureString pword = new SecureString();
            passwordBox.Text.ToList().ForEach(pword.AppendChar);
            context.Credentials = new SharePointOnlineCredentials(userNameText.Text, pword);
            Site site = context.Site;
            context.Load(site);
            ConnectStatus.Text = "YES";
            ConnectStatus.ForeColor = Color.Green;



        }
        private void downloadSharepoint(string target, string sPFolder)
        {
            //   Web web = context.Web;
            var list = context.Web.Lists.GetByTitle(sPFolder);
            var rootFolder = list.RootFolder;
            string sPPath = string.Format(@"{0}{1}\", @"C:\", sPFolder);
            if (!Directory.Exists(sPPath)) { 
            System.IO.Directory.CreateDirectory(target);
            downloadSharePoint(rootFolder, context, target);
        }
            //Microsoft.SharePoint.Client.File filetoDownload = web.GetFileByServerRelativeUrl(sharePointTextBox.Text);
            //context.Load(filetoDownload);
            //context.ExecuteQuery();
            //var fileRef = filetoDownload.ServerRelativeUrl;
            //var fileInfo = Microsoft.SharePoint.Client.File.OpenBinaryDirect(context, fileRef);
            //var fileName = Path.Combine(target, (string)filetoDownload.Name);

 //           using (var fileStream = System.IO.File.Create(fileName))
   //         {
      //          fileInfo.Stream.CopyTo(fileStream);
     //       }
        }
        private static void downloadSharePoint(Folder sourceFolder, ClientContext context, string target)
        {
          
                context.Load(sourceFolder, k => k.Name, k => k.Files, k => k.Folders);
                context.ExecuteQuery();
            foreach (var folder in sourceFolder.Folders)
            {
                if (!(folder.Name == "Forms"))
                {

                    string folderpath = target + "\\" + folder.Name;
                    string subfolderPath = folderpath;
                    if (!Directory.Exists(subfolderPath))
                        System.IO.Directory.CreateDirectory(subfolderPath);

                    downloadSharePoint(folder, context, subfolderPath);
                }
            }

                foreach (var file in sourceFolder.Files)
                {
                    var fileName = Path.Combine(target, file.Name);
                    if (!System.IO.File.Exists(fileName))
                    {
                        var fileRef = file.ServerRelativeUrl;
                        var fileInfo = Microsoft.SharePoint.Client.File.OpenBinaryDirect(context, fileRef);
                        using (var fileStream = System.IO.File.Create(fileName))
                        {
                            fileInfo.Stream.CopyTo(fileStream);
                        }
                    }
                }

            
       
        }



        private void sPDRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (sPDRadio.Checked)
            {
                MessageBox.Show("SharePoint Destination requires Sharepoint Server.", "Error");
                sPDRadio.Checked = false;
                lDradio.Checked = true;
                //sPDest.Visible = true;
                //sPDestText.Visible = true;
            }
         //   else
           // {
            //    sPDest.Visible = false;
             //   sPDestText.Visible = false;

            //}
        }

        private void participantCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (participantCheckBox.Checked)
            {
                varPanel.Visible = true;
                participantPanel.Visible = true;
                base.Size = new Size(955, 491);
            }
            else
            {
                participantPanel.Visible = false;
                if (varPanelOver.Visible == false)
                {
                    varPanel.Visible = false;
                    base.Size = new Size(554, 491);
                }
            }
        }

   

        private void sPSRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (sPSRadio.Checked)
            {
                SharePointURL.Visible= true;
                sharePointTextBox.Visible= true;
            }
            else
            {
                SharePointURL.Visible = false;
                sharePointTextBox.Visible = false;

            }
        }

        private void lSRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (lSRadio.Checked)
            {
                templateSourceLabel.Visible = true;
                inFolder.Visible = true;
                sourceText.Visible = true;

            }
            else { templateSourceLabel.Visible = false;
            inFolder.Visible = false;
            sourceText.Visible = false;}
        }

        private void lDradio_CheckedChanged(object sender, EventArgs e)
        {
            if (lDradio.Checked) {
                outFolder.Visible = true;
                targetText.Visible = true;
                destinationFolder.Visible = true;

            }
            else { outFolder.Visible = false;
                targetText.Visible= false;
                destinationFolder.Visible = false;  
            
            }
        }

        private void SharePointRoot_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
