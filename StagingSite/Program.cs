using Microsoft.SharePoint;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SharePoint.Client;
using File = System.IO.File;
using Aspose.Words;
using Aspose.Words.Replacing;

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


        public static void spDownload(string source) {
           
            }
        
        
        
        
        
        
        
        

        //Recursively Duplicates files and folders from inFile Directory to OutFile Directory
        public static void duplicate(String inFile, String outFile )
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
        // Overloaded method, Creates participant files Recursively  and optionally Duplicates files and folders from inFile Directory to OutFile Directory
        public static void duplicate(String inFile, String outFile,bool duplicateBool, int pcount, int pseries)
        {
            if (!Directory.Exists(outFile))
            {
                Directory.CreateDirectory(outFile);
            }


            foreach (var directory in Directory.GetDirectories(inFile))
            {
                if (directory.Contains("nnn"))
                {
                    for (int i = 1; i <= pcount; i++)
                    {
                        string foldername = Path.GetFileName(directory);
                        string number = (pseries + i).ToString();
                        foldername = foldername.Replace("nnn", number);
                        string participantDirectory = Path.Combine(outFile, foldername);
                        Directory.CreateDirectory(participantDirectory);
                        duplicate(directory, participantDirectory, duplicateBool, pcount, pseries);
                    }

                }
                else
                {
                    if (duplicateBool)
                    {
                        duplicate(directory, Path.Combine(outFile, Path.GetFileName(directory)), duplicateBool, pcount, pseries);
                    }
                }
            }


            foreach (var file in Directory.GetFiles(inFile))
            {
                if (File.Exists(Path.Combine(outFile, Path.GetFileName(file))))
                {
                    File.Delete(Path.Combine(outFile, Path.GetFileName(file)));
                }
                if (file.Contains("nnn"))
                {
                    for (int i = 1; i <= pcount; i++)
                    {
                        string filename = Path.GetFileName(file);
                        string number = (pseries + i).ToString();
                        filename = filename.Replace("nnn", number);

                        File.Copy(file, Path.Combine(outFile, filename), true);
                    }
                }
                else
                {
                    if (duplicateBool)
                    {
                        File.Copy(file, Path.Combine(outFile, Path.GetFileName(file)), true);
                    }
                }
            }
        }
        //Recursively renames all items inside of the outfile
        public static void rename(bool contents, string fromSiteName, string fromMonth,string fromProgramName, string toSiteName, string toMonth, string toProgramName, string outfile)
        {
            string fileName;
            string directoryName;

            foreach (var file in Directory.GetFiles(outfile))
            {
                fileName = file.Replace(fromMonth,toMonth);
                fileName = fileName.Replace(fromSiteName,toSiteName);
                fileName = fileName.Replace(fromProgramName,toProgramName);
                if (!File.Exists(fileName))
                {
                    if (contents)
                    {

                        // Load a Word docx document
                        Document doc = new Document(file);
                        // Find and replace text in the document
                        doc.Range.Replace(fromMonth, toMonth, new FindReplaceOptions(FindReplaceDirection.Forward));
                        doc.Range.Replace(fromSiteName, toSiteName, new FindReplaceOptions(FindReplaceDirection.Forward));
                        doc.Range.Replace(fromProgramName, toProgramName, new FindReplaceOptions(FindReplaceDirection.Forward));


                        // Save the Word document
                        doc.Save(fileName);

                    }
                    else
                    {
                        File.Move(file, fileName);
                    }
                 
                }
                
            }
         


            
            foreach (var directory in Directory.GetDirectories(outfile))
            {
                directoryName = directory.Replace(fromMonth, toMonth);
                directoryName = directoryName.Replace(fromSiteName, toSiteName);
                directoryName = directoryName.Replace(fromProgramName, toProgramName);
                if (!Directory.Exists(directoryName)) {
                    Directory.Move(directory, directoryName);
                }
     
                rename(contents, fromSiteName, fromMonth,fromProgramName,toSiteName,toMonth,toProgramName, directoryName);


            }
        }




    }
}
