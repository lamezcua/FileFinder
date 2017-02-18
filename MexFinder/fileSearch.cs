using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MexFinder
{
    public partial class fileSearch : UserControl
    {
        private frmFinder parent;
        internal frmFinder FrmParent
        {
            get { return parent; }
            set { parent = value; }
        }

        private string baseFolder = string.Empty;
        private string criteria = String.Empty;
        private List<FileInfo> files = new List<FileInfo>();
        public fileSearch()
        {
            InitializeComponent();
            SetupBackgroundWorker();
        }

        #region SetupBackgroundWorker
        void SetupBackgroundWorker()
        {
            bgwFileFinder.DoWork += new DoWorkEventHandler(bgwFileFinder_DoWork);
            bgwFileFinder.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwFileFinder_RunWorkerCompleted);
            bgwFileFinder.ProgressChanged += new ProgressChangedEventHandler(bgwFileFinder_ProgressChanged);

        }

        void bgwFileFinder_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is FileInfo)
            {
                FileInfo f = e.UserState as FileInfo;
                tvFolders.Nodes.Add(new TreeNode(f.FullName));
            }
        }

        void bgwFileFinder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetReady();
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                ListResults();
                FrmParent.SetStatus("User cancelled, partial results");
            }
            else
            {
                ListResults();
                FrmParent.SetStatus(String.Format("Finished {0} files match", files.Count));
            }
        }


        void bgwFileFinder_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            if (bgwFileFinder.CancellationPending)
                e.Cancel = true;
            FindFolders(baseFolder, worker, e);
        }

        private void FindFolders(string folder, BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            DirectoryInfo di = new DirectoryInfo(baseFolder);
            AddFolders(di);
        }

        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileSearch_Load(object sender, EventArgs e)
        {
            dtStart.CustomFormat = "MMM dd, yy - ddd hh:mm:ss";
            dtStart.Value = DateTime.Now.AddMonths(-1);
            dtEnd.CustomFormat = "MMM dd, yy - ddd hh:mm:ss";
            FrmParent.SetStatus("Ready!");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindFiles_Click(object sender, EventArgs e)
        {
            if (bgwFileFinder.IsBusy)
                bgwFileFinder.CancelAsync();
            else
            {
                criteria = txtFileName.Text.Trim();
                if (baseFolder == string.Empty)
                {
                    FrmParent.SetStatus("Empty base folder!");
                    return;
                }
                if (criteria == String.Empty)
                {
                    FrmParent.SetStatus("Empty search criteria!");
                    return;
                }
                SetBusy();
                FrmParent.SetStatus(String.Format("Looking for folder that matches {0}", criteria));
                bgwFileFinder.RunWorkerAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void ListResults()
        {
            //if (files.Count > 2)
            //{
            //    tvFolders.Nodes.Clear();
            //    FileInfo first = files[0];
            //    foreach (FileInfo file in files)
            //    {
            //        if (file.Directory.FullName == first.Directory.FullName)
            //        {

            //        }
            //    }
            //}
            FrmParent.SetStatus("Finished");
        }
        
        private void SetReady()
        {
            grpOptions.Enabled = true;
            btnFindFiles.BackColor = BackColor;
            btnFindFiles.Text = "Go!";
        }


        private void SetBusy()
        {
            files = new List<FileInfo>();
            tvFolders.Nodes.Clear();
            grpOptions.Enabled = false;
            btnFindFiles.BackColor = Color.Tomato;
            btnFindFiles.Text = "Stop";
        }

        private void AddFolders(DirectoryInfo di)
        {
            foreach (FileInfo f in di.GetFiles())
            {               
                if (f.Name.Contains(criteria))
                {
                    files.Add(f);
                    bgwFileFinder.ReportProgress(10, f);
                }
            }
            foreach (DirectoryInfo d in di.GetDirectories())
            {
                AddFolders(d);
            }
        }

        private void btnBrowseFileFind_Click(object sender, EventArgs e)
        {
            if (dlgFolder.ShowDialog() == DialogResult.OK)
            {
                baseFolder = dlgFolder.SelectedPath;
                txtBaseFolderFileFinder.Text = baseFolder;
            }
        }

        private void chkUseDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseDate.Checked)
                grpDate.Enabled = true;
            else
                grpDate.Enabled = false;
        }

        void tvFolders_DoubleClick(object sender, System.EventArgs e)
        {
            if (tvFolders.SelectedNode != null)
            {
                try
                {
                    FileInfo fi = new FileInfo(tvFolders.SelectedNode.Text);
                    System.Diagnostics.Process.Start("Explorer", fi.Directory.FullName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

    }
}
