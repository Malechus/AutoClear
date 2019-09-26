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
            createBat();
            selfDestruct();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputBox.AppendText("Thank you for downloading AutoClear, by Malechus!\n\nThis program will create folders in your Pictures and Downloads directories called 'Temp.' These folders can be used to store any files (like this installer) that you save or download to use once, but will not need again. Every time you log in, these folders will have been emptied, to keep those files from cluttering up your hard drive. In addition, every time you log in your Recycle Bin will have been emptied automatically.\n\n I recommend setting these temp folders as your default download and screenshot locations, you can do this through your browser settings and your screenshot application settings respectively. When you click agree below, the program will be installed and you will probably never see it again, as it runs very quickly and automatically. If you've changed your mind, click 'Cancel' to exit the installer.\n\n Enjoy!\n\n \u00a9 Garrett Kelly, 2019");
        }

        private void createBat()
        {
            StreamWriter autoclear = new StreamWriter(@"C:\Users\%username%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\autoclear.bat");
            autoclear.WriteLine("echo off");
            autoclear.WriteLine(@"rd /q /s c:\users\%username%\downloads\Temp");
            autoclear.WriteLine(@"rd /q /s c:\users\%username%\pictures\Temp");
            autoclear.WriteLine(@"rd /q /s %systemdrive%\$recycle.bin");
            autoclear.WriteLine(@"mkdir c:\users\%username%\downloads\Temp");
            autoclear.WriteLine(@"mkdir c:\users\%username%\pictures\Temp");
            autoclear.WriteLine("exit");
        }

        private void selfDestruct()
        {
            Process selfDestruct = new Process();

            selfDestruct.StartInfo.FileName = "cmd.exe";
            selfDestruct.StartInfo.CreateNoWindow = true;
            selfDestruct.StartInfo.Arguments = @"timeout 6 <nul & del /q " + Application.ExecutablePath;
        }
    }
}
