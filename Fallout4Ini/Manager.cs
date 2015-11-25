using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fallout4Ini
{
    // Manager class has functions in it that will manage them tools of the software and change settings
    class Manager
    {
        private EditorForm form;
        public Manager(EditorForm form)
        {
            this.form = form;
        }

        /*----------------------------------------Functions called by Update (in manager)-------------------------------------*/

        // Function that gets called very often to check on the ini files and update the GUI 
        // So if the user changes the ini files manually, my program will respond to the changes (example: uncheck a checkbox)
        public void Update()
        {
            string[] fallout4Lines, fallout4PrefsLines;
            // Check on the Fallout4.ini file
            if (form.IniDir.Text != "")
            {
                fallout4Lines = form.GetFileLines(form.IniDir.Text);

                // Now do stuff with these lines

            }

            // Check on the Fallout4Prefs.ini file
            if (form.PrefsIniDir.Text != "")
            {
                fallout4PrefsLines = form.GetFileLines(form.PrefsIniDir.Text);
                
                // Now do stuff with these lines
                CheckUnlockFPS(fallout4PrefsLines);
                CheckDepthOfField(fallout4PrefsLines);
            }

            // Check on things that need both of them, we no longer need to get the file contents because if this
            // Statement is true, then we would have already read the contents of the file this iteration
            if (form.IniDir.Text != "" && form.PrefsIniDir.Text != "")
            {
                // Now do stuff with both file lines

            }
        }

        // Function called by Update, which will check or uncheck the unlock FPS depending on if the file  is changed
        private void CheckUnlockFPS(string[] fallout4PrefsLines)
        {
            if (form.IsFound(fallout4PrefsLines, "iPresentInterval=0") != -1)
            {
                form.UnlockFPSBox.Checked = true;
            }
            else if (form.IsFound(fallout4PrefsLines, "iPresentInterval=1") != -1)
            {
                form.UnlockFPSBox.Checked = false;
            }
        }

        // Function called by Update, which will set the depth of field accordingly
        private void CheckDepthOfField(string[] fallout4PrefLines)
        {
            if (form.IsFound(fallout4PrefLines, "bDoDepthOfField=1") != -1 && form.IsFound(fallout4PrefLines, "bScreenSpaceBokeh=1") != -1)
            {
                form.DepthBox.SelectedIndex = 1;
            }
            else if (form.IsFound(fallout4PrefLines, "bDoDepthOfField=0") != -1 && form.IsFound(fallout4PrefLines, "bScreenSpaceBokeh=0") != -1)
            {
                form.DepthBox.SelectedIndex = 0;
            }
        }
        
        /*------------------------------------------------Functions called by the form-----------------------------------------*/

        // Function that will check if the tab control should be active
        public void CheckTabControl()
        {
            if (form.IniDir.Text != "" && form.PrefsIniDir.Text != "")
            {
                form.TabControl.Enabled = true;
            }
            else
            {
                form.TabControl.Enabled = false;
            }
        }


        // Function that will execute when the user clicks the Unlock the FPS checkbox
        public void SetUnlockFPS()
        {
            try
            {
                // This value is what will be changed on the "iPresentInterval=value" line
                int value = form.UnlockFPSBox.Checked ? 0 : 1;
            
                string[] fileLines = form.GetFileLines(form.PrefsIniDir.Text);
            
                int index = form.IsFound(fileLines, "iPresentInterval=");
                if (index != -1)
                {
                    fileLines[index] = "iPresentInterval=" + value;
                }

                // Now overwrite the old file with the line using append to file 
                form.ClearFile(form.PrefsIniDir.Text);
                form.AppendFile(fileLines, form.PrefsIniDir.Text);
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("Please ensure that the ini files are not readonly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Function that will execute when the user clicks the Depth of Field ComboBox
        public void SetDepthOfField()
        {
            try
            {
                //This value is what will be changed on the bDoDepthOfField=value and bScreenSpaceBokeh=value line
                int value = -1;
                if (form.DepthBox.Text == "Disabled")
                {
                    value = 0;
                }
                else if (form.DepthBox.Text == "Enabled")
                {
                    value = 1;
                }

                string[] fileLines = form.GetFileLines(form.PrefsIniDir.Text);

                int index1 = form.IsFound(fileLines, "bDoDepthOfField=");
                int index2 = form.IsFound(fileLines, "bScreenSpaceBokeh=");
                if (index1 != -1 && index2 != -1)
                {
                    fileLines[index1] = "bDoDepthOfField=" + value;
                    fileLines[index2] = "bScreenSpaceBokeh=" + value;
                }

                // Now overwrite the old file with the line using append to file
                form.ClearFile(form.PrefsIniDir.Text);
                form.AppendFile(fileLines, form.PrefsIniDir.Text);
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("Please ensure that the ini files are not readonly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
