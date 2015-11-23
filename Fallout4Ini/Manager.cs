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
