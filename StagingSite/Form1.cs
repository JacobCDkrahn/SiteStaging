using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Base : Form
    {
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
            if (duplicateCheckBox.Checked) {
                
                Program.duplicate(sourceText.Text, targetText.Text);
           
            }
            if (renameCheckBox.Checked) {
                Program.rename(siteBox.Text,monthBox.Text,programBox.Text,targetText.Text);
            
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
                base.Size = new Size(966, 276);
            }
            else
            {
                varPanel.Visible = false;
                base.Size = new Size(566, 276);
            }
        }
    }
}
