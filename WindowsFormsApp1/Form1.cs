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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
