namespace MexFinder
{
    partial class textSearch
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
            this.btnGo = new System.Windows.Forms.Button();
            this.tvResults = new System.Windows.Forms.TreeView();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBasePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToSearch = new System.Windows.Forms.TextBox();
            this.cboExtensions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bwSearcher = new System.ComponentModel.BackgroundWorker();
            this.dlgFolderPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(317, 9);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(51, 103);
            this.btnGo.TabIndex = 14;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tvResults
            // 
            this.tvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvResults.Location = new System.Drawing.Point(3, 118);
            this.tvResults.Name = "tvResults";
            this.tvResults.Size = new System.Drawing.Size(380, 430);
            this.tvResults.TabIndex = 15;
            this.tvResults.DoubleClick += new System.EventHandler(this.tvResults_DoubleClick);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.btnBrowse);
            this.grpOptions.Controls.Add(this.label3);
            this.grpOptions.Controls.Add(this.txtBasePath);
            this.grpOptions.Controls.Add(this.label2);
            this.grpOptions.Controls.Add(this.txtToSearch);
            this.grpOptions.Controls.Add(this.cboExtensions);
            this.grpOptions.Controls.Add(this.label1);
            this.grpOptions.Location = new System.Drawing.Point(3, 3);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(308, 109);
            this.grpOptions.TabIndex = 13;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(180, 76);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(31, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base Folder";
            // 
            // txtBasePath
            // 
            this.txtBasePath.Location = new System.Drawing.Point(9, 77);
            this.txtBasePath.Name = "txtBasePath";
            this.txtBasePath.Size = new System.Drawing.Size(165, 20);
            this.txtBasePath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text To Search *___*";
            // 
            // txtToSearch
            // 
            this.txtToSearch.Location = new System.Drawing.Point(9, 32);
            this.txtToSearch.Name = "txtToSearch";
            this.txtToSearch.Size = new System.Drawing.Size(286, 20);
            this.txtToSearch.TabIndex = 1;
            // 
            // cboExtensions
            // 
            this.cboExtensions.FormattingEnabled = true;
            this.cboExtensions.Items.AddRange(new object[] {
            ".cs",
            ".xml",
            ".txt",
            ".html",
            ".js"});
            this.cboExtensions.Location = new System.Drawing.Point(217, 77);
            this.cboExtensions.Name = "cboExtensions";
            this.cboExtensions.Size = new System.Drawing.Size(78, 21);
            this.cboExtensions.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Extension";
            // 
            // bwSearcher
            // 
            this.bwSearcher.WorkerReportsProgress = true;
            this.bwSearcher.WorkerSupportsCancellation = true;
            // 
            // dlgFolderPicker
            // 
            this.dlgFolderPicker.ShowNewFolderButton = false;
            // 
            // textSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tvResults);
            this.Controls.Add(this.grpOptions);
            this.Name = "textSearch";
            this.Size = new System.Drawing.Size(386, 548);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        


        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TreeView tvResults;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBasePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToSearch;
        private System.Windows.Forms.ComboBox cboExtensions;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker bwSearcher;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderPicker;
    }
}
