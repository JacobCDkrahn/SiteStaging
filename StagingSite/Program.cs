using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Base());
        }

        //Recursively Duplicates files and folders from inFile Directory to OutFile Directory
        public static void duplicate(String inFile, String outFile)
        {
            Directory.CreateDirectory(outFile);


            foreach (var directory in Directory.GetDirectories(inFile)) {

                duplicate(directory, Path.Combine(outFile,Path.GetFileName(directory)));

            }


            foreach (var file in Directory.GetFiles(inFile))
            {
                if (File.Exists(Path.Combine(outFile, Path.GetFileName(file))))
                {
                    File.Delete(Path.Combine(outFile, Path.GetFileName(file)));
                }
                File.Copy(file, Path.Combine(outFile, Path.GetFileName(file)),true);
            }
        }
        


        
        //Recursively renames all items inside of the outfile
        internal static void rename(string siteName, string month,string programName, string outfile)
        {
            string fileName;
            string directoryName;
           
            foreach (var file in Directory.GetFiles(outfile))
            {
                fileName = file.Replace("_MONTH_", month);
                fileName = fileName.Replace("_SITE_", siteName);
                fileName = fileName.Replace("_PROGRAM_", programName);

                File.Move(file, fileName);


            }
            foreach (var directory in Directory.GetDirectories(outfile))
            {
                directoryName = directory.Replace("_MONTH_", month);
                directoryName = directoryName.Replace("_SITE_", siteName);
                directoryName = directoryName.Replace("_PROGRAM_", programName);
                if (!Directory.Exists(directoryName)) {
                    Directory.Move(directory, directoryName);
                }
     
                rename(siteName, month,programName, directoryName);


            }
        }
    }
}
