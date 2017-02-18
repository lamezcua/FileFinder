using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MexFinder
{
    public partial class textSearch : UserControl
    {
        SearchSettings settings;
        Dictionary<string, List<String>> fileList = new Dictionary<string, List<string>>();
        
        private frmFinder parent;
        internal frmFinder FrmParent
        {
            get { return parent; }
            set { parent = value; }
        }

        public textSearch()
        {
            InitializeComponent();
            settings.BasePath = String.Empty;
            settings.FileExtension = String.Empty;
            settings.TextToSearch = String.Empty;
            bwSearcher.DoWork += new DoWorkEventHandler(bwSearcher_DoWork);
            bwSearcher.ProgressChanged += new ProgressChangedEventHandler(bwSearcher_ProgressChanged);
            bwSearcher.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwSearcher_RunWorkerCompleted);
        }


        # region backgound worker
        void bwSearcher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetReady();
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                ListAllFiles();
                FrmParent.SetStatus("User cancelled, partial results");
            }
            else
            {
                ListAllFiles();
                FrmParent.SetStatus(String.Format("Finished {0} files match", fileList.Count));
            }
        }

        void bwSearcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string file = e.UserState as string;
            FrmParent.SetStatus(file);
        }

        void bwSearcher_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            if (bwSearcher.CancellationPending)
                e.Cancel = true;
            FindFiles(new DirectoryInfo(settings.BasePath), worker, e);
        }
        #endregion

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dlgFolderPicker.ShowDialog() == DialogResult.OK)
            {
                txtBasePath.Text = dlgFolderPicker.SelectedPath;
                FrmParent.SetStatus("Selected folder : " + dlgFolderPicker.SelectedPath);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (bwSearcher.IsBusy)
            {
                bwSearcher.CancelAsync();
            }
            else
            {
                if (ValidateInput())
                {
                    SetRunning();
                    FrmParent.SetStatus("Running");
                    bwSearcher.RunWorkerAsync();
                }
            }
        }

        void tvResults_DoubleClick(object sender, System.EventArgs e)
        {
            string selectedfile;
            if (tvResults.SelectedNode.Parent == null)
                selectedfile = tvResults.SelectedNode.Text;
            else
            {
                selectedfile = tvResults.SelectedNode.Parent.Text;
                FrmParent.SetStatus("File : " + selectedfile);

                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "notepad";
                p.StartInfo.Arguments = selectedfile;
                p.Start();
            }
        }

        private bool ValidateInput()
        {
            if (txtToSearch.Text.Trim().Length < 1)
            {
                FrmParent.SetStatus("Enter text to search!");
                return false;
            }
            if (cboExtensions.Text.Trim().Length < 1)
            {
                FrmParent.SetStatus("Enter file extension!");
                return false;
            }
            if (txtBasePath.Text.Trim().Length < 1)
            {
                FrmParent.SetStatus("Must enter base path");
                return false;
            }
            settings.BasePath = txtBasePath.Text;
            if (cboExtensions.Text.StartsWith("."))
                settings.FileExtension = cboExtensions.Text;
            else
                settings.FileExtension = "." + cboExtensions.Text;
            settings.TextToSearch = txtToSearch.Text;
            return true;
        }

        private void SetRunning()
        {
            grpOptions.Enabled = false;
            btnGo.BackColor = Color.Tomato;
            btnGo.Text = "Stop";
            fileList = new Dictionary<string, List<string>>();
            tvResults.Nodes.Clear();
        }

        private void SetReady()
        {
            grpOptions.Enabled = true;
            btnGo.BackColor = BackColor;
            btnGo.Text = "Go!";
        }

        private void FindFiles(DirectoryInfo baseDir, BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            foreach (FileInfo fi in baseDir.GetFiles())
            {
                if (settings.FileExtension != fi.Extension)
                    continue;
                using (StreamReader sr = new StreamReader(fi.FullName))
                {
                    string line;
                    List<String> l = new List<string>();
                    int lineNum = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineNum++;

                        if (line.Contains(settings.TextToSearch))
                        {
                            l.Add(String.Format("[{0}] : {1}", lineNum, line));
                        }
                    } // of reading all lined
                    if (l.Count > 0)
                    {
                        fileList.Add(fi.FullName, l);
                        bwSearcher.ReportProgress(10, fi.FullName);
                    }
                }// of using streamreader
            }
            foreach (DirectoryInfo di in baseDir.GetDirectories())
            {
                FindFiles(di, worker, e);
            }
        }

        private void ListAllFiles()
        {
            if (fileList.Count < 1)
            {
                FrmParent.SetStatus("No files matched");
            }
            foreach (string fname in fileList.Keys)
            {
                TreeNode tn = new TreeNode(fname);
                List<string> lst = fileList[fname];
                foreach (string s in lst)
                {
                    TreeNode tch = new TreeNode(s);
                    tn.Nodes.Add(tch);
                }
                tvResults.Nodes.Add(tn);
            }
        }
    }

}
