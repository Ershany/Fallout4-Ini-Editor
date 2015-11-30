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
        private string metaDataFile = @"C:\Users\" + Environment.UserName + @"\Documents\Fallout4IniEditor.ini"; // Metadata file's path
        private Manager manager; // Manager object to manage the GUI components and ini files
        private bool running; // Used for the async method

        public EditorForm()
        {
            // Initialize
            manager = new Manager(this);
            InitializeComponent();
            Init();
            InitIni();
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
            manager.SetTabControl();

            // Show the user a message before the program starts (if they have not entered ini files, meaning it is there first time using the software)
            if (!TabControl.Enabled)
            {
                MessageBox.Show("IMPORTANT NOTICE\n" +
                            "If this is your first time using the software please ensure you have not moved the ini lines around to different headers, like moving a line from [Display] to [Imagespace]\n" +
                            "If you did please delete your ini files and launch Fallout4 so they are rebuilt\n" +
                            "Also make sure to use your ini files in Documents\\My Games\\Fallout4, not the ini files from SteamApps\\Common\\Fallout4\n" +
                            "Please do not delete the file in Documents called \"Fallout4IniEditor\"");
            }
        }

        // Method that makes sure the ini files have the correct lines to modify (e.g. FOV)
        private void InitIni()
        {
            // Make sure the user has provided ini files
            if (!TabControl.Enabled) return;

            // Get the file lines
            string[] prefsIniLines = GetFileLines(PrefsIniDir.Text);
            string[] iniLines = GetFileLines(IniDir.Text);

            // Ensure the UnlockFPS line is there
            if (IsFound(prefsIniLines, "iPresentInterval=") == -1)
            {
                int index = IsFound(prefsIniLines, "[Display]");
                prefsIniLines = GetNewArray(prefsIniLines, new string[]{"iPresentInterval=1"}, index + 1);
                ClearFile(PrefsIniDir.Text);
                AppendFile(prefsIniLines, PrefsIniDir.Text);
            }

            // Ensure that the Depth of Field lines are there
            if (IsFound(prefsIniLines, "bDoDepthOfField=") == -1)
            {
                int index = IsFound(prefsIniLines, "[Imagespace]");
                prefsIniLines = GetNewArray(prefsIniLines, new string[] {"bDoDepthOfField=1"}, index + 1);
                ClearFile(PrefsIniDir.Text);
                AppendFile(prefsIniLines, PrefsIniDir.Text);
            }
            if(IsFound(prefsIniLines, "bScreenSpaceBokeh=") == -1) 
            {
                int index = IsFound(prefsIniLines, "[Imagespace]");
                prefsIniLines = GetNewArray(prefsIniLines, new string[] {"bScreenSpaceBokeh=1"}, index + 1);
                ClearFile(PrefsIniDir.Text);
                AppendFile(prefsIniLines, PrefsIniDir.Text);
            }

            // Ensure the FOV lines are there
            // The default ini files have it under the wrong header so check for the lines under the [Display] header only (Check between an interval)
            // Now search if the FOV lines are inbetween the interval
            int startSearchIndex = IsFound(iniLines, "[Display]");
            int endSearchIndex = IsFound(iniLines, "[HairLighting]");
            int temp1 = IsFound(iniLines, "fDefaultWorldFOV=");
            int temp2 = IsFound(iniLines, "fDefault1stPersonFOV=");
            if (temp1 == -1 || temp1 < startSearchIndex || temp1 > endSearchIndex)
            {
                // Since the line is not under display, add it
                iniLines = GetNewArray(iniLines, new string[] {"fDefaultWorldFOV=90"}, startSearchIndex + 1);
                ClearFile(IniDir.Text);
                AppendFile(iniLines, IniDir.Text);
            }
            if (temp2 == -1 || temp2 < startSearchIndex || temp2 > endSearchIndex)
            {
                // Since the line is not under display, add it
                iniLines = GetNewArray(iniLines, new string[] {"fDefault1stPersonFOV=90"}, startSearchIndex + 1);
                ClearFile(IniDir.Text);
                AppendFile(iniLines, IniDir.Text);
            }
            if (IsFound(prefsIniLines, "fDefaultWorldFOV=") == -1)
            {
                int index = IsFound(prefsIniLines, "[Display]");
                prefsIniLines = GetNewArray(prefsIniLines, new string[] {"fDefaultWorldFOV=90"}, index + 1);
                ClearFile(PrefsIniDir.Text);
                AppendFile(prefsIniLines, PrefsIniDir.Text);
            }
            if (IsFound(prefsIniLines, "fDefault1stPersonFOV=") == -1)
            {
                int index = IsFound(prefsIniLines, "[Display]");
                prefsIniLines = GetNewArray(prefsIniLines, new string[] {"fDefault1stPersonFOV=90"}, index + 1);
                ClearFile(PrefsIniDir.Text);
                AppendFile(prefsIniLines, PrefsIniDir.Text);
            }

            // Ensure that the lines for skip intro are not turned on (not useful for the program) if they are there, get rid of em
            if (IsFound(iniLines, "SIntroSequence=1") != -1)
            {
                int index = IsFound(iniLines, "SIntroSequence=1");
                iniLines[index] = "";
                ClearFile(IniDir.Text);
                AppendFile(iniLines, IniDir.Text);
            }
            if (IsFound(iniLines, "fChancesToPlayAlternateIntro=1") != -1)
            {
                int index = IsFound(iniLines, "fChancesToPlayAlternateIntro=1");
                iniLines[index] = "";
                ClearFile(IniDir.Text);
                AppendFile(iniLines, IniDir.Text);
            }
            if (IsFound(iniLines, "uMainMenuDelayBeforeAllowSkip=1") != -1)
            {
                int index = IsFound(iniLines, "uMainMenuDelayBeforeAllowSkip=1");
                iniLines[index] = "";
                ClearFile(IniDir.Text);
                AppendFile(iniLines, IniDir.Text);
            }
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
                manager.SetTabControl();
                InitIni();
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
                manager.SetTabControl();
                InitIni();
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

        // Method to make a new array with new lines at the new position
        public string[] GetNewArray(string[] lines, string[] linesToAdd, int index)
        {
            string[] newLines = new string[lines.Length + linesToAdd.Length];
            int j = 0;
            for (int i = 0; i < newLines.Length; i++)
            {
                if (i == index + j && j < linesToAdd.Length)
                {
                    newLines[i] = linesToAdd[j];
                    j++;
                }
                else
                {
                    newLines[i] = lines[i - j]; 
                }
            }
            return newLines;
        }

        // Method to delete elements out of an array and then shrink the array (uses LINQ <--- Why I chose C#)
        public string[] DeleteElementsInArray(string[] lines, string[] linesToDel)
        {
            string[] newLines = new string[lines.Length - linesToDel.Length];
            foreach(var line in lines) 
            {
                
            }
            return newLines;
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

        // Method that executes when the user clicks on the enable or disable depth of field
        private void depthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            manager.SetDepthOfField();
        }

        // Method that executes when the user clicks the numericUpDown for first person FOV
        private void firstFOVNum_ValueChanged(object sender, EventArgs e)
        {
            manager.SetFirstPersonFOV();
        }

        // Method that executes when the user clicks the numericUpDown for third person FOV
        private void thirdFOVNum_ValueChanged(object sender, EventArgs e)
        {
            manager.SetThirdPersonFOV();
        }

        // Method that executes when the user clicks the skip intro check box
        private void skipIntroBox_CheckedChanged(object sender, EventArgs e)
        {
            manager.SetIntroVideo();
        }

    }
}
