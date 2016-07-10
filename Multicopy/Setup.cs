using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Multicopy
{
    public partial class Setup : Form
    {
        private IEnumerable<DriveInfo> drives;

        public Setup()
        {
            InitializeComponent();
            sourceBrowser.Description = "Please select the source folder to be copied.";
            sourceBrowser.ShowNewFolderButton = false;
        }

        private void sourceButton_Click(object sender, EventArgs e)
        {
            var dr = sourceBrowser.ShowDialog();
            if (dr == DialogResult.OK)
            {
                sourceBox.Text = sourceBrowser.SelectedPath;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Help", "for help please see the GitHub repository");
        }

        private void updateDriveList()
        {
            getRemovableDrives();
            usbDrivesCheckbox.Items.Clear();
            if (drives != null)
            {
                foreach (var d in drives)
                {
                    usbDrivesCheckbox.Items.Add(d);
                }
            }
            else
            {
                usbDrivesCheckbox.Items.Add("No drives found");
            }
        }

        private void getRemovableDrives()
        {
            drives = DriveInfo.GetDrives().Where(d => d.DriveType == DriveType.Removable);
        }

        private void usbDrivesRescan_Click(object sender, EventArgs es)
        {
            updateDriveList();
        }

        private void optionSetName_CheckedChanged(object sender, EventArgs e)
        {
            optionVolumeSetText.Enabled = optionSetName.Checked;
        }

        private void setupGoButton_Click(object sender, EventArgs e)
        {
            var r = validate();
            if (!r.good)
            {
                MessageBox.Show("There were the following errors: \n" + r.problems.ToString(), "Please check your input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                new Copier(sourceBox.Text, usbDrivesCheckbox.CheckedItems.OfType<DriveInfo>().ToList(), optionEraseBefore.Checked, optionSetName.Checked, optionVolumeSetText.Text);
            }
        }

        private ValidationResult validate()
        {
            var r = new ValidationResult();
            // Validate form
            if (usbDrivesCheckbox.CheckedItems.Count == 0) { r.good = false; r.problems.AppendLine("No drives selected"); }
            if (sourceBox.Text.Length == 0) { r.good = false; r.problems.AppendLine("No source folder selected"); }
            return r;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/robertphipps/Multicopy");
        }
    }

    public class ValidationResult
    {
        public bool good { get; set; }
        public StringBuilder problems { get; set; }

        public ValidationResult()
        {
            problems = new StringBuilder();
            good = true;
        }
    }
}
