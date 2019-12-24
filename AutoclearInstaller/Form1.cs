using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AutoclearInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agreeButton_Click(object sender, EventArgs e)
        {
            CreateBat();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputBox.AppendText("Thank you for downloading AutoClear, version 0.1, by Malechus!\n\nThis program will create folders in your Pictures, Documents, and Downloads directories called 'Temp.' These folders can be used to store any files (like this installer) that you save or download to use once, but will not need again. Every time you log in, these folders will have been emptied, to keep those files from cluttering up your hard drive. In addition, every time you log in your Recycle Bin will have been emptied automatically. Files deleted this way will be recoverable from the Recycle Bin the first time you log in, and will be permanently deleted the second time.\n\nIt is recommended that you set these temp folders as your default download and screenshot locations, you can do this through your browser settings and your screenshot application settings respectively. \n\nThis version works for Windows 10 and Windows 7.\n\nWhen you click 'Agree' below, the program will be installed and you will probably never see it again, as it runs automatically, and usually very quickly. The program will be run when when after installation. If you've changed your mind, click 'Cancel' to exit the installer.\n\nEnjoy!\n\n \u00a9 Garrett Kelly, 2019");
        }

        private void CreateBat()
        {
            string name = Environment.GetEnvironmentVariable("username");
            string filename = @"autoclear.bat";
            string dir = @"c:\users\%username%\appdata\roaming\microsoft\windows\start menu\programs\startup\".Replace("%username%", name);
            string FilePath = Path.Combine(dir, filename);
            using (StreamWriter autoclear = File.CreateText(FilePath))
            {
                autoclear.WriteLine("echo off");
                autoclear.WriteLine(@"rd /q /s %systemdrive%\$recycle.bin");
                autoclear.WriteLine(@"rd /q /s c:\users\%username%\downloads\Temp");
                autoclear.WriteLine(@"rd /q /s c:\users\%username%\pictures\Temp");
                autoclear.WriteLine(@"rd /q /s c:\users\%username%\documents\Temp");
                autoclear.WriteLine(@"mkdir c:\users\%username%\downloads\Temp");
                autoclear.WriteLine(@"mkdir c:\users\%username%\pictures\Temp");
                autoclear.WriteLine(@"mkdir c:\users\%username%\documents\Temp");
                autoclear.WriteLine("exit");
                autoclear.Close();
            }

            Process RunAutoClear = new Process();
            RunAutoClear.StartInfo.FileName = FilePath;
            RunAutoClear.Start();
        }
    }
}
