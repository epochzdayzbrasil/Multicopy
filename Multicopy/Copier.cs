using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multicopy
{
    public partial class Copier : Form
    {
        private string source;
        private bool optionEraseBefore;
        private bool optionRamCopy;
        private string optionVolumeSetText;
        private IList<DriveInfo> drives;
        private bool optionSetName;

        public Copier(string source, IList<DriveInfo> drives, bool optionEraseBefore, bool optionSetName, string optionVolumeSetText, bool optionRamCopy)
        {
            InitializeComponent();
            this.source = source;
            this.drives = drives;
            this.optionEraseBefore = optionEraseBefore;
            this.optionVolumeSetText = optionVolumeSetText;
            this.optionRamCopy = optionRamCopy;
            this.optionSetName = optionSetName;

            if (MessageBox.Show("Just checking", "Are you sure you want to go ahead with this copy?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Show();
                run();
            }
            else
            {
                Close();
            }
        }

        private void run()
        {
            logBox.AppendText("Starting copy" + Environment.NewLine);
            if (optionEraseBefore) { doPreErase(); };
            doFileCopy();
            if (optionSetName) { doSetName(); }
            logBox.AppendText("All done!" + Environment.NewLine);
            MessageBox.Show("All done!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void doSetName()
        {
            logBox.AppendText("Setting volume names.... ");
            var tasks = new List<Task>();
            foreach (var d in drives)
            {
                var w = new nameWorker(d, optionVolumeSetText);
                var t = Task.Factory.StartNew(w.name);
                tasks.Add(t);
            }
            logBox.AppendText("using " + tasks.Count + " threads ");
            Task.WaitAll(tasks.ToArray());
            logBox.AppendText("- DONE!" + Environment.NewLine);
        }

        private void doFileCopy()
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(source);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + source);
            }

            logBox.AppendText("Copying files.... ");
            var tasks = new List<Task>();

            foreach (var d in drives)
            {
                var w = new copyWorker(d, source);
                var t = Task.Factory.StartNew(w.copy);
                tasks.Add(t);
            }
            logBox.AppendText("using " + tasks.Count + " threads ");
            Task.WaitAll(tasks.ToArray());
            logBox.AppendText("- DONE!" + Environment.NewLine);
        }

        private void doRamCopy()
        {
            throw new NotImplementedException();
        }

        private void doPreErase()
        {
            logBox.AppendText("Erasing disks.... ");
            var tasks = new List<Task>();
            foreach (var d in drives)
            {
                var w = new eraseWorker(d);
                var t = Task.Factory.StartNew(w.erase);
                tasks.Add(t);
            }
            logBox.AppendText("using " + tasks.Count + " threads ");
            Task.WaitAll(tasks.ToArray());
            logBox.AppendText("- DONE!" + Environment.NewLine);
        }

        private class eraseWorker
        {
            private DriveInfo d { get; set; }

            public eraseWorker(DriveInfo d)
            {
                this.d = d;
            }

            public void erase()
            {
                new DirectoryInfo(d.VolumeLabel).Delete(true);
            }
        }

        private class copyWorker
        {
            private DriveInfo d { get; set; }
            private string s { get; set; }
            public copyWorker(DriveInfo drive, string source)
            {
                this.d = drive;
                this.s = source;
            }

            public void copy()
            {
                DirectoryCopy(s, d.RootDirectory.ToString(), true);
            }

            // Source: https://msdn.microsoft.com/en-us/library/bb762914(v=vs.110).aspx
            private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
            {
                // Get the subdirectories for the specified directory.
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);

                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found: "
                        + sourceDirName);
                }

                DirectoryInfo[] dirs = dir.GetDirectories();
                // If the destination directory doesn't exist, create it.
                if (!Directory.Exists(destDirName))
                {
                    Directory.CreateDirectory(destDirName);
                }

                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(temppath, false);
                }

                // If copying subdirectories, copy them and their contents to new location.
                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string temppath = Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                    }
                }
            }
        }

        private class nameWorker
        {
            private DriveInfo d;
            private string n;
            public nameWorker(DriveInfo d, string name)
            {
                this.d = d;
                this.n = name;
            }
            
            public void name()
            {
                d.VolumeLabel = n;
            }
        }
    }
}
