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
            string[] fallout4Lines = null;
            string[] fallout4PrefsLines = null;
            // Check on the Fallout4.ini file
            if (form.IniDir.Text != "")
            {
                fallout4Lines = form.GetFileLines(form.IniDir.Text);

                // Now do stuff with these lines
                CheckSkipVideo(fallout4Lines);
                CheckPauseAltTab(fallout4Lines);
                CheckIncreaseFPS(fallout4Lines);
                CheckRemoveStutter(fallout4Lines);
                CheckHighRes(fallout4Lines);
                CheckInnerGlow(fallout4Lines);
                CheckFixMouse(fallout4Lines);
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
                CheckFirstPersonFOV(fallout4Lines, fallout4PrefsLines);
                CheckThirdPersonFOV(fallout4Lines, fallout4PrefsLines);
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

        // Function called by Update, which will set the First Person FOV accordingly
        private void CheckFirstPersonFOV(string[] iniLines, string[] prefIniLines)
        {
            int value1 = Convert.ToInt32(iniLines[form.IsFound(iniLines, "fDefault1stPersonFOV=")].Substring(21));
            int value2 = Convert.ToInt32(prefIniLines[form.IsFound(prefIniLines, "fDefault1stPersonFOV=")].Substring(21));
            //If the two values are the same, display the FOV, else display the default 90 (this should not occur unless the user tampers with the files)
            if (value1 == value2)
                form.FirstFOVNum.Value = value1;
            else
                form.FirstFOVNum.Value = 90;
        }

        // Function called by Update, which will set the Third Person FOV accordingly
        private void CheckThirdPersonFOV(string[] iniLines, string[] prefIniLines)
        {
            int value1 = Convert.ToInt32(iniLines[form.IsFound(iniLines, "fDefaultWorldFOV=")].Substring(17));
            int value2 = Convert.ToInt32(prefIniLines[form.IsFound(prefIniLines, "fDefaultWorldFOV=")].Substring(17));
            //If the two values are the same, display the FOV, else display the default 90 (this should not occur unless the user tampers with the files)
            if (value1 == value2)
                form.ThirdFOVNum.Value = value1;
            else
                form.ThirdFOVNum.Value = 90;
        }

        // Function called by Update, which will set the Skip Intro Video checkbox accordingly
        private void CheckSkipVideo(string[] iniLines)
        {
            int index1 = form.IsFound(iniLines, "SIntroSequence=0");
            int index2 = form.IsFound(iniLines, "fChancesToPlayAlternateIntro=0");
            int index3 = form.IsFound(iniLines, "uMainMenuDelayBeforeAllowSkip=0");
            // If all of the lines exist, then the intro video is being skipped
            if (index1 != -1 && index2 != -1 && index3 != -1)
            {
                form.SkipIntroBox.Checked = true;
            }
            else
            {
                form.SkipIntroBox.Checked = false;
            }
        }

        // Function called by Update, which will set the PauseAltTab checkbox accordingly
        private void CheckPauseAltTab(string[] iniLines)
        {
            if (form.IsFound(iniLines, "bAlwaysActive=1") != -1)
            {
                form.PauseAltTabBox.Checked = false;
            }
            else if (form.IsFound(iniLines, "bAlwaysActive=0") != -1)
            {
                form.PauseAltTabBox.Checked = true;
            }
        }

        // Function called by Update, which will set the IncreaseFPS checkbox accordingly
        private void CheckIncreaseFPS(string[] iniLines)
        {
            if (form.IsFound(iniLines, "uInterior Cell Buffer=12") != -1 && form.IsFound(iniLines, "uExterior Cell Buffer=144") != -1 && form.IsFound(iniLines, "iNumHWThreads=8") != -1)
            {
                form.IncreaseFPSBox.Checked = true;
            }
            else
            {
                form.IncreaseFPSBox.Checked = false;
            }
        }

        // Function called by Update, which will set RemoveStutter checkbox accordingly
        private void CheckRemoveStutter(string[] iniLines)
        {
            if (form.IsFound(iniLines, "iPreloadSizeLimit=262144000") != -1)
            {
                form.RemoveStutterBox.Checked = true;
            }
            else
            {
                form.RemoveStutterBox.Checked = false;
            }
        }

        // Function called by Update, which will set HighRes checkbox accordingly
        private void CheckHighRes(string[] iniLines)
        {
            if (form.IsFound(iniLines, "bForceUpdateDiffuseOnly=0") != -1 && form.IsFound(iniLines, "iTextureDegradeDistance0=1600") != -1 &&
                form.IsFound(iniLines, "iTextureDegradeDistance1=3000") != -1 && form.IsFound(iniLines, "iTextureUpgradeDistance0=1200") != -1 &&
                form.IsFound(iniLines, "iTextureUpgradeDistance1=2400") != -1)
            {
                form.HighResBox.Checked = true;
            }
            else
            {
                form.HighResBox.Checked = false;
            }
        }

        // Function called by Update, which will set InnerGlow checkbox accordingly
        private void CheckInnerGlow(string[] iniLines)
        {
            if (form.IsFound(iniLines, "sStartingConsoleCommand=cl off") != -1)
            {
                form.InnerGlowBox.Checked = true;
            }
            else
            {
                form.InnerGlowBox.Checked = false;
            }
        }

        // Function called by Update, which will set FixMouse checkbox accordingly
        private void CheckFixMouse(string[] iniLines)
        {
            if (form.IsFound(iniLines, "fIronSightsPitchSpeedRatio=1.0000") != -1 && form.IsFound(iniLines, "fPitchSpeedRatio=1.0000") != -1)
            {
                form.FixMouseBox.Checked = true;
            }
            else
            {
                form.FixMouseBox.Checked = false;
            }
        }
        
        /*------------------------------------------------Functions called by the form-----------------------------------------*/

        // Function that will check if the tab control should be active
        public void SetTabControl()
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
        
        // Function that will execute when the user changes First Person FOV
        public void SetFirstPersonFOV()
        {
            try
            {
                int value = Convert.ToInt32(form.FirstFOVNum.Value);

                string[] fileLines1 = form.GetFileLines(form.IniDir.Text);
                string[] fileLines2 = form.GetFileLines(form.PrefsIniDir.Text);

                int index1 = form.IsFound(fileLines1, "fDefault1stPersonFOV=");
                int index2 = form.IsFound(fileLines2, "fDefault1stPersonFOV=");
                if (index1 != -1 && index2 != -1)
                {
                    fileLines1[index1] = "fDefault1stPersonFOV=" + value;
                    fileLines2[index2] = "fDefault1stPersonFOV=" + value;
                }

                // Now overwrite the old files with the line using append to file
                form.ClearFile(form.IniDir.Text);
                form.ClearFile(form.PrefsIniDir.Text);
                form.AppendFile(fileLines1, form.IniDir.Text);
                form.AppendFile(fileLines2, form.PrefsIniDir.Text);
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("Please ensure that the ini files are not readonly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Function that will execute when the user changes Third Person FOV
        public void SetThirdPersonFOV()
        {
            try
            {
                int value = Convert.ToInt32(form.ThirdFOVNum.Value);

                string[] fileLines1 = form.GetFileLines(form.IniDir.Text);
                string[] fileLines2 = form.GetFileLines(form.PrefsIniDir.Text);

                int index1 = form.IsFound(fileLines1, "fDefaultWorldFOV=");
                int index2 = form.IsFound(fileLines2, "fDefaultWorldFOV=");
                if (index1 != -1 && index2 != -1)
                {
                    fileLines1[index1] = "fDefaultWorldFOV=" + value;
                    fileLines2[index2] = "fDefaultWorldFOV=" + value;
                }

                // Now overwrite the old files with the line using append to file
                form.ClearFile(form.IniDir.Text);
                form.ClearFile(form.PrefsIniDir.Text);
                form.AppendFile(fileLines1, form.IniDir.Text);
                form.AppendFile(fileLines2, form.PrefsIniDir.Text);
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("Please ensure that the ini files are not readonly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Function that will execute when the user clicks the skip intro checkbox
        public void SetIntroVideo()
        {
            try
            {
                string[] fileLines = form.GetFileLines(form.IniDir.Text);

                // If the box is checked, add the lines, else delete the lines from the file (this is the only way to revert the changes)
                if (form.SkipIntroBox.Checked)
                {
                    int index = form.IsFound(fileLines, "[General]");
                    if (form.IsFound(fileLines, "uMainMenuDelayBeforeAllowSkip=0") == -1)
                    {
                        fileLines = form.GetNewArray(fileLines, new string[] { "uMainMenuDelayBeforeAllowSkip=0" }, index + 1);
                    }
                    if (form.IsFound(fileLines, "fChancesToPlayAlternateIntro=0") == -1)
                    {
                        fileLines = form.GetNewArray(fileLines, new string[] { "fChancesToPlayAlternateIntro=0" }, index + 1);
                    }
                    if (form.IsFound(fileLines, "SIntroSequence=0") == -1)
                    {
                        fileLines = form.GetNewArray(fileLines, new string[] { "SIntroSequence=0" }, index + 1);
                    }
                    form.ClearFile(form.IniDir.Text);
                    form.AppendFile(fileLines, form.IniDir.Text);
                }
                else
                {
                    // Get the index of the lines were searching for
                    int index1 = form.IsFound(fileLines, "SIntroSequence=");
                    int index2 = form.IsFound(fileLines, "fChancesToPlayAlternateIntro=");
                    int index3 = form.IsFound(fileLines, "uMainMenuDelayBeforeAllowSkip=");

                    // Check to see if the index was found, if it was delete it from the fileLines
                    if (index1 != -1)
                    {
                        fileLines = form.DeleteElementsInArray(fileLines, new string[] {"SIntroSequence=0"});
                    }
                    if (index2 != -1)
                    {
                        fileLines = form.DeleteElementsInArray(fileLines, new string[] {"fChancesToPlayAlternateIntro=0"});
                    }
                    if (index3 != -1)
                    {
                        fileLines = form.DeleteElementsInArray(fileLines, new string[] {"uMainMenuDelayBeforeAllowSkip=0"});
                    }
                    form.ClearFile(form.IniDir.Text);
                    form.AppendFile(fileLines, form.IniDir.Text);
                }
                
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("Please ensure that the ini files are not readonly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Function that executes when the user clicks on the Pause when alt tabbed checkbox
        public void SetPauseAltTab()
        {
            try
            {
                string[] fileLines = form.GetFileLines(form.IniDir.Text);
                int value = 1;

                // Check to see if it was checked or unchecked
                if (form.PauseAltTabBox.Checked)
                {
                    value = 0;
                }

                // Now get the index of the line and manipulate it
                fileLines[form.IsFound(fileLines, "bAlwaysActive=")] = "bAlwaysActive=" + value;
                form.ClearFile(form.IniDir.Text);
                form.AppendFile(fileLines, form.IniDir.Text);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Please ensure that the ini files are not readonly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Function that executes when the user clicks on the increaseFPS checkbox
        public void SetIncreaseFPS()
        {
            try
            {
                string[] fileLines = form.GetFileLines(form.IniDir.Text);
                
                // Check to see if the checkbox was checked or unchecked and make sure that the settings aren't already there
                if (form.IncreaseFPSBox.Checked)
                {
                    // Ensure that the lines are not there to duplicate them
                    if (form.IsFound(fileLines, "uInterior Cell Buffer=12") == -1 && form.IsFound(fileLines, "uExterior Cell Buffer=144") == -1 && form.IsFound(fileLines, "iNumHWThreads=8") == -1)
                    {
                        // Needs to get written under the general header, so find the index of the header
                        int index = form.IsFound(fileLines, "[General]");

                        fileLines = form.GetNewArray(fileLines, new string[] { "uInterior Cell Buffer=12", "uExterior Cell Buffer=144", "iNumHWThreads=8" }, index + 1);
                    }
                }
                else
                {
                    fileLines = form.DeleteElementsInArray(fileLines, new string[] {"uInterior Cell Buffer=12", "uExterior Cell Buffer=144", "iNumHWThreads=8"});
                }

                form.ClearFile(form.IniDir.Text);
                form.AppendFile(fileLines, form.IniDir.Text);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Please ensure that the ini files are not readonly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Function that executes when the user clicks on the removeStutter checkbox
        public void SetRemoveStutter()
        {
            try
            {
                string[] fileLines = form.GetFileLines(form.IniDir.Text);

                // Check to see if the checkbox was checked or unchecked
                if (form.RemoveStutterBox.Checked)
                {
                    // Ensure that the lines are not there to duplicate them
                    if (form.IsFound(fileLines, "iPreloadSizeLimit=262144000") == -1)
                    {
                        // Needs to get written under the general header, so find the index of the header
                        int index = form.IsFound(fileLines, "[General]");

                        fileLines = form.GetNewArray(fileLines, new string[] {"iPreloadSizeLimit=262144000"}, index + 1);
                    }
                        
                }
                else
                {
                    fileLines = form.DeleteElementsInArray(fileLines, new string[] {"iPreloadSizeLimit=262144000"});
                }

                form.ClearFile(form.IniDir.Text);
                form.AppendFile(fileLines, form.IniDir.Text);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Please ensure that the ini files are not readonly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Function that executes when the user clicks on the highRes checkbox
        public void SetHighRes()
        {
            try
            {
                string[] fileLines = form.GetFileLines(form.IniDir.Text);

                // Check to see if the checkbox was checked or unchecked
                if (form.HighResBox.Checked)
                {
                    // Ensure that the lines are not there to duplicate them
                    if (form.IsFound(fileLines, "bForceUpdateDiffuseOnly=0") == -1 && form.IsFound(fileLines, "iTextureDegradeDistance0=1600") == -1 &&
                        form.IsFound(fileLines, "iTextureDegradeDistance1=3000") == -1 && form.IsFound(fileLines, "iTextureUpgradeDistance0=1200") == -1 &&
                        form.IsFound(fileLines, "iTextureUpgradeDistance1=2400") == -1)
                    {
                        // Needs to get written under the general header, so find the index of the header
                        int index = form.IsFound(fileLines, "[General]");

                        fileLines = form.GetNewArray(fileLines, new string[] {"bForceUpdateDiffuseOnly=0", "iTextureDegradeDistance0=1600", "iTextureDegradeDistance1=3000", "iTextureUpgradeDistance0=1200", "iTextureUpgradeDistance1=2400"}, index + 1);
                    }
                }
                else
                {
                    fileLines = form.DeleteElementsInArray(fileLines, new string[] {"bForceUpdateDiffuseOnly=0", "iTextureDegradeDistance0=1600", "iTextureDegradeDistance1=3000", "iTextureUpgradeDistance0=1200", "iTextureUpgradeDistance1=2400"});
                }

                form.ClearFile(form.IniDir.Text);
                form.AppendFile(fileLines, form.IniDir.Text);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Please ensure that the ini files are not readonly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Function that executes when the user clicks on the innerGlow checkbox
        public void SetInnerGlow()
        {
            try
            {
                string[] fileLines = form.GetFileLines(form.IniDir.Text);

                // Check to see if the checkbox was checked or unchecked
                if (form.InnerGlowBox.Checked)
                {
                    // Ensure that the lines are not there to duplicate them
                    if (form.IsFound(fileLines, "sStartingConsoleCommand=cl off") == -1)
                    {
                        // Needs to get written under the general header, so find the index of the header
                        int index = form.IsFound(fileLines, "[General]");

                        fileLines = form.GetNewArray(fileLines, new string[] {"sStartingConsoleCommand=cl off"}, index + 1);
                    }
                }
                else
                {
                    fileLines = form.DeleteElementsInArray(fileLines, new string[] {"sStartingConsoleCommand=cl off"});
                }

                form.ClearFile(form.IniDir.Text);
                form.AppendFile(fileLines, form.IniDir.Text);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Please ensure that the ini files are not readonly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Function that executes when the user clicks on the FixMosue checkbox
        public void SetFixMouse()
        {
            try
            {
                string[] fileLines = form.GetFileLines(form.IniDir.Text);
                string value1 = "0.8000";
                string value2 = "0.5625";

                // Check to see if the checkbox was checked or unchecked
                if (form.FixMouseBox.Checked)
                {
                    value1 = "1.0000";
                    value2 = "1.0000";
                }

                // Change the lines
                fileLines[form.IsFound(fileLines, "fIronSightsPitchSpeedRatio=")] = "fIronSightsPitchSpeedRatio=" + value1;
                fileLines[form.IsFound(fileLines, "fPitchSpeedRatio=")] = "fPitchSpeedRatio=" + value2;

                form.ClearFile(form.IniDir.Text);
                form.AppendFile(fileLines, form.IniDir.Text);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Please ensure that the ini files are not readonly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
