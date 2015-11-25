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
using System.Threading;

namespace Fallout4Ini
{
    public partial class EditorForm : Form
    {
        private string metaDataFile = @"C:\Users\" + Environment.UserName + @"\Documents\Fallout4IniEditor.ini";
        private Manager manager;
        private bool running;

        public EditorForm()
        {
            // Initialize
            manager = new Manager(this);
            InitializeComponent();
            Init();
            Update();
        }

        // Used an async method to update and check on the ini files instead of a thread, because a thread
        // does not allow me to manipulate the GUI, so an async method will do the trick
        public async void Update()
        {
            running = true;
            while (running)
            {
                // Check the ini files and change the GUI once a second
                manager.Update();
                await Task.Delay(1000);
            }
        }
 
        // Method that initializes things that the program needs
        private void Init()
        {
            // Check to see if the metaDataFile does not exist
            if (!File.Exists(metaDataFile))
            {
                File.Create(metaDataFile).Close();
            }
            // If the file exists set things up
            else
            {
                string[] fileLines = GetFileLines(metaDataFile);

                // Check to see if the directories for the ini files are saved in the metaDataFile and if, load them into the labels
                int location = IsFound(fileLines, "[Fallout4 Directory]: ");
                if (location != -1)
                {
                    string line = fileLines[location];
                    line = line.Substring(22).Trim();
                    iniDir.Text = line;
                }
                location = IsFound(fileLines, "[Fallout4Prefs Directory]: ");
                if (location != -1)
                {
                    string line = fileLines[location];
                    line = line.Substring(27).Trim();
                    prefsIniDir.Text = line;
                }
            }
            // Now check to see if the directories were added to the labels, and if so then allow the user to manipulate the ini files
            manager.CheckTabControl();
        }

        // Directory picking code
        private void defaultIniButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the Fallout4.ini file located in Documents/My Games/Fallout4";

            // Check to see if there is any previous directories, and if there is, start the initial directory at that position
            if (iniDir.Text != "")
            {
                ofd.InitialDirectory = iniDir.Text;
            }
            else if (prefsIniDir.Text != "")
            {
                ofd.InitialDirectory = @prefsIniDir.Text;
            }
            else
            {
                ofd.InitialDirectory = @"C:\";
            }

            // See if the user provides a files
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                iniDir.Text = ofd.FileName;
                // Now that a directory has changed or has been added, see if we should enable/disable the tab control
                manager.CheckTabControl();
            }
        }

        // Directory picking code
        private void prefsIniButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the Fallout4Prefs.ini file in Documents/My Games/Fallout4";

            // Check to see if there is any previous directories, and if there is, start the initial directory at that position
            if (prefsIniDir.Text != "")
            {
                ofd.InitialDirectory = @prefsIniDir.Text;
            }
            else if (iniDir.Text != "")
            {
                ofd.InitialDirectory = iniDir.Text;
            }
            else
            {
                ofd.InitialDirectory = @"C:\";
            }
            
            // See if the user provides a files
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                prefsIniDir.Text = ofd.FileName;
                // Now that a directory has changed or has been added, see if we should enable/disable the tab control
                manager.CheckTabControl();
            }
        }

        // Method the executes when the user closes the form (it saves data to a metafile)
        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Write things to the metafile
            string[] linesToWrite = {"[Fallout4 Directory]: " + iniDir.Text + "\n",
                                     "[Fallout4Prefs Directory]: " + prefsIniDir.Text + "\n"};
            ClearFile(metaDataFile);
            AppendFile(linesToWrite, metaDataFile);

            // Stopping the multi tasking of the async method
            running = false;
        }

        // Method that will read all of the lines of a file, and returns the result
        public string[] GetFileLines(string path)
        {
            try
            {
                return File.ReadAllLines(path);
            }
            catch (UnauthorizedAccessException e)
            {
                throw;
            }
        }

        // Method that will look through a line to see if it contains an item (if it finds it it will return what line index it found it at)
        // Note: First line index is 0, method will return -1 if it did not find it
        public int IsFound(string[] lines, string item)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(item))
                {
                    return i;
                }
            }
            return -1;
        }

        // Method that overwrites a file with new contents
        public void OverwriteFile(string[] lines, string path)
        {
            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Truncate, FileAccess.Write))
                {
                    foreach (var line in lines)
                    {
                        byte[] bytes = GetBytes(line);
                        stream.Write(bytes, 0, bytes.Length);
                    }

                    stream.Flush();
                }
            }
            catch (UnauthorizedAccessException e)
            {
                throw;
            }
        }

        // Method that overwrites a file but adds \n characters at the end of every line
        public void OverwriteLineFile(string[] lines, string path)
        {
            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Truncate, FileAccess.Write))
                {
                    foreach (var line in lines)
                    {
                        byte[] bytes = GetBytes(line + "\r\n");
                        stream.Write(bytes, 0, bytes.Length);
                    }

                    stream.Flush();
                }
            }
            catch (UnauthorizedAccessException e)
            {
                throw;
            }
        }

        // Method that appends to a file
        public void AppendFile(string[] lines, string path)
        {
            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(stream))
                    {
                        foreach (var line in lines)
                        {
                            sw.WriteLine(line);
                        }
                        sw.Flush();
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                throw;
            }
        }

        // Method to clear a file
        public void ClearFile(string path)
        {
            try
            {
                File.Create(path).Close();
            }
            catch (UnauthorizedAccessException e)
            {
                throw;
            }
        }

        // Method to convert a string to a byte array
        private byte[] GetBytes(string str) 
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        // Method to convert a byte array to a string
        private string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        // Method that executes if the user clicks the donation button
        private void donationButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=6TD83ABPVEDYG");
        }

        // Method that executes if the user clicks the about button
        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fallout 4 ini editor made by Brady Jessup\n" + 
                            "This program allows you to edit Fallout 4 settings with no knowledge of messing with the ini files\n" +
                            "This program uses a metadata file located in your documents so please do not delete it\n" + 
                            "All updates will be free regardless of donations\n" +
                            "Developed using C# and Visual Studio\n" + 
                            "Please report any bugs to this email: Bradyjessup@hotmail.com", "About the Fallout4 Ini Editor");
        }

        // Method that executes if the user clicks the Unlock the FPS checkbox
        private void unlockFPSBox_CheckedChanged(object sender, EventArgs e)
        {
            manager.SetUnlockFPS();
        }

        private void depthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            manager.SetDepthOfField();
        }

    }
}
