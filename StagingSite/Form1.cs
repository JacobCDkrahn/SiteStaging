using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;

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

        private void outFolder_Click(object sender, EventArgs e)
        {
          
        }

  
      

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

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

        private void SourceFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            bool spSource = false;
            bool spDest = false;
            bool sourceVerified = false;
            bool targetVerified = false;
            string source="";
            string target="";
       //Source Verification
            if (sPSourceCheckBox.Checked == true) {
                if (sharePointTextBox.Text.Length ==0)
                {

                    MessageBox.Show("Please Input a SharePoint Source");

                }
                else {
                    spSource = true;
                    sourceVerified = true;  
                    source = sharePointTextBox.Text;
                }
            }
            if (localSourceCheckBox.Checked == true)
            {
                if (sourceText.Text.Length == 0)
                {
                    MessageBox.Show("Please Input a Local Source");
                }
                else
                {

                    spSource = false;
                    sourceVerified = true;
                    source = sourceText.Text;
                    
                }
            }
            //Dest Verification
            if (sPDestCheck.Checked) {
                if (sPDestText.Text.Length ==0)
                {

                    MessageBox.Show("Please Input a SharePoint Destination");

                }
                else {
                    spDest = true;
                    targetVerified = true;  
                    target= sPDestText.Text;
                }
            }
            if (localDestCheck.Checked) {
                if (targetText.Text.Length==0)
                {
                    MessageBox.Show("Please Input a Local Source");
                }
                else {
                    spDest = false;
                    targetVerified = true;
                    target = targetText.Text;
                }
            
            
            }



            if ( (sourceVerified== false || targetVerified== false) && duplicateCheckBox.Checked == true)
            {
                MessageBox.Show(" You must Select a source to duplicate to and from.","Error");

            }











            if(sourceVerified && targetVerified)
            {
                if(spSource||spDest){
                    if (ConnectStatus.Text == "NO") {

                        MessageBox.Show("You must connect to SharePoint");
                    
                    }
                    if (duplicateCheckBox.Checked)
                    {
                       
                        Web web = context.Web;
                        Microsoft.SharePoint.Client.File filetoDownload = web.GetFileByServerRelativeUrl(sharePointTextBox.Text);
                        context.Load(filetoDownload);
                        context.ExecuteQuery();
                        var fileRef = filetoDownload.ServerRelativeUrl;
                        var fileInfo = Microsoft.SharePoint.Client.File.OpenBinaryDirect(context, fileRef);
                        var fileName = Path.Combine(targetText.Text, (string)filetoDownload.Name);

                        using (var fileStream = System.IO.File.Create(fileName))
                        {
                            fileInfo.Stream.CopyTo(fileStream);
                        }
                    }
                    if (renameCheckBox.Checked) {


                        Program.rename(siteBox.Text, monthBox.Text, programBox.Text, target);



                    }





                }
                else {
                    if (duplicateCheckBox.Checked)
                    {
                        Program.duplicate(source, target);

                    }





                    if (targetVerified && renameCheckBox.Checked)
                    {
                        Program.rename(siteBox.Text, monthBox.Text, programBox.Text, target);

                    }
                }




            }
        }
        


        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void renameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (renameCheckBox.Checked)
            {
                varPanel.Visible = true;
                base.Size = new Size(966, 503);
            }
            else
            {
                varPanel.Visible = false;
                base.Size = new Size(566, 503);
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            localSourceCheckBox.Checked = false;
        }

        private void templateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sPSourceCheckBox.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

         
            localDestCheck.Checked = false;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            sPDestCheck.Checked = false;
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

   
    
        private void sharePointTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
          



                context = new ClientContext(SharePointRoot.Text);
           // Web web = context.Web;
            SecureString pword = new SecureString();
                passwordBox.Text.ToList().ForEach(pword.AppendChar);
                context.Credentials = new SharePointOnlineCredentials(userNameText.Text, pword);
                Site site = context.Site;
                context.Load(site);
            // context.ExecuteQuery();



            ConnectStatus.Text = "YES";
                ConnectStatus.ForeColor = Color.Green;
            
        }
    }
}
