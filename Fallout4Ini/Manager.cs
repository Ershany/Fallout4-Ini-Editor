using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            }

            // Check on things that need both of them, we no longer need to get the file contents because if this
            // Statement is true, then we would have already read the contents of the file this iteration
            if (form.IniDir.Text != "" && form.PrefsIniDir.Text != "")
            {
                // Now do stuff with both file lines

            }
        }

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
        public void CheckUnlockFPS()
        {
            // This value is what will be changed on the "iPresentInterval=value" line
            int value = -1;
            if (form.UnlockFPSBox.Checked)
            {
                value = 0;
            }
            else
            {
                value = 1;
            }
            //fileLine = form.GetFileLines();
        }
    }
}
