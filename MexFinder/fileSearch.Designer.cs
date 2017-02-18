namespace MexFinder
{
    partial class fileSearch
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFindFiles = new System.Windows.Forms.Button();
            this.tvFolders = new System.Windows.Forms.TreeView();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkUseDate = new System.Windows.Forms.CheckBox();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnBrowseFileFind = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBaseFolderFileFinder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.bgwFileFinder = new System.ComponentModel.BackgroundWorker();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.grpOptions.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindFiles
            // 
            this.btnFindFiles.Location = new System.Drawing.Point(343, 11);
            this.btnFindFiles.Name = "btnFindFiles";
            this.btnFindFiles.Size = new System.Drawing.Size(53, 151);
            this.btnFindFiles.TabIndex = 17;
            this.btnFindFiles.Text = "Go!";
            this.btnFindFiles.UseVisualStyleBackColor = true;
            this.btnFindFiles.Click += new System.EventHandler(this.btnFindFiles_Click);
            // 
            // tvFolders
            // 
            this.tvFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFolders.Location = new System.Drawing.Point(3, 168);
            this.tvFolders.Name = "tvFolders";
            this.tvFolders.Size = new System.Drawing.Size(413, 381);
            this.tvFolders.TabIndex = 18;
            this.tvFolders.DoubleClick += new System.EventHandler(tvFolders_DoubleClick);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkUseDate);
            this.grpOptions.Controls.Add(this.grpDate);
            this.grpOptions.Controls.Add(this.btnBrowseFileFind);
            this.grpOptions.Controls.Add(this.label7);
            this.grpOptions.Controls.Add(this.txtBaseFolderFileFinder);
            this.grpOptions.Controls.Add(this.label8);
            this.grpOptions.Controls.Add(this.txtFileName);
            this.grpOptions.Location = new System.Drawing.Point(0, 0);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(337, 162);
            this.grpOptions.TabIndex = 16;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkUseDate
            // 
            this.chkUseDate.AutoSize = true;
            this.chkUseDate.Location = new System.Drawing.Point(3, 97);
            this.chkUseDate.Name = "chkUseDate";
            this.chkUseDate.Size = new System.Drawing.Size(15, 14);
            this.chkUseDate.TabIndex = 10;
            this.chkUseDate.UseVisualStyleBackColor = true;
            this.chkUseDate.CheckedChanged += new System.EventHandler(this.chkUseDate_CheckedChanged);
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.label10);
            this.grpDate.Controls.Add(this.label9);
            this.grpDate.Controls.Add(this.dtStart);
            this.grpDate.Controls.Add(this.dtEnd);
            this.grpDate.Enabled = false;
            this.grpDate.Location = new System.Drawing.Point(20, 97);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(311, 59);
            this.grpDate.TabIndex = 6;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Use Last Modified Criteria";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Newer Than";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Older Than";
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(134, 15);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(148, 20);
            this.dtStart.TabIndex = 6;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(134, 36);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(148, 20);
            this.dtEnd.TabIndex = 8;
            // 
            // btnBrowseFileFind
            // 
            this.btnBrowseFileFind.Location = new System.Drawing.Point(300, 67);
            this.btnBrowseFileFind.Name = "btnBrowseFileFind";
            this.btnBrowseFileFind.Size = new System.Drawing.Size(31, 23);
            this.btnBrowseFileFind.TabIndex = 3;
            this.btnBrowseFileFind.Text = "...";
            this.btnBrowseFileFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseFileFind.UseVisualStyleBackColor = true;
            this.btnBrowseFileFind.Click += new System.EventHandler(this.btnBrowseFileFind_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Base Folder";
            // 
            // txtBaseFolderFileFinder
            // 
            this.txtBaseFolderFileFinder.Location = new System.Drawing.Point(9, 70);
            this.txtBaseFolderFileFinder.Name = "txtBaseFolderFileFinder";
            this.txtBaseFolderFileFinder.Size = new System.Drawing.Size(285, 20);
            this.txtBaseFolderFileFinder.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "File Name Contains:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(9, 32);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(322, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // bgwFileFinder
            // 
            this.bgwFileFinder.WorkerReportsProgress = true;
            this.bgwFileFinder.WorkerSupportsCancellation = true;
            // 
            // dlgFolder
            // 
            this.dlgFolder.RootFolder = System.Environment.SpecialFolder.Personal;
            this.dlgFolder.ShowNewFolderButton = false;
            // 
            // fileSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindFiles);
            this.Controls.Add(this.tvFolders);
            this.Controls.Add(this.grpOptions);
            this.Name = "fileSearch";
            this.Size = new System.Drawing.Size(419, 552);
            this.Load += new System.EventHandler(this.fileSearch_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnFindFiles;
        private System.Windows.Forms.TreeView tvFolders;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Button btnBrowseFileFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBaseFolderFileFinder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.CheckBox chkUseDate;
        private System.ComponentModel.BackgroundWorker bgwFileFinder;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
    }
}
