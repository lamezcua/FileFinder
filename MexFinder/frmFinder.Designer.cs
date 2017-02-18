namespace MexFinder
{
    partial class frmFinder
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.prgMain = new System.Windows.Forms.ToolStripProgressBar();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tbpText = new System.Windows.Forms.TabPage();
            this.textSearch1 = new MexFinder.textSearch();
            this.tbpFiles = new System.Windows.Forms.TabPage();
            this.fileSearch1 = new MexFinder.fileSearch();
            this.tbpDb = new System.Windows.Forms.TabPage();
            this.dbExplore1 = new MexFinder.dbExplore();
            this.dbConnect = new MexFinder.dbConnect();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tbpText.SuspendLayout();
            this.tbpFiles.SuspendLayout();
            this.tbpDb.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.prgMain});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(459, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(342, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Ready";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prgMain
            // 
            this.prgMain.Name = "prgMain";
            this.prgMain.Size = new System.Drawing.Size(100, 16);
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tbpText);
            this.tbMain.Controls.Add(this.tbpFiles);
            this.tbMain.Controls.Add(this.tbpDb);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(459, 517);
            this.tbMain.TabIndex = 1;
            // 
            // tbpText
            // 
            this.tbpText.Controls.Add(this.textSearch1);
            this.tbpText.Location = new System.Drawing.Point(4, 22);
            this.tbpText.Name = "tbpText";
            this.tbpText.Padding = new System.Windows.Forms.Padding(3);
            this.tbpText.Size = new System.Drawing.Size(451, 491);
            this.tbpText.TabIndex = 0;
            this.tbpText.Text = "Text";
            this.tbpText.UseVisualStyleBackColor = true;
            // 
            // textSearch1
            // 
            this.textSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSearch1.Location = new System.Drawing.Point(3, 3);
            this.textSearch1.Name = "textSearch1";
            this.textSearch1.Size = new System.Drawing.Size(445, 485);
            this.textSearch1.TabIndex = 0;
            this.textSearch1.Load += new System.EventHandler(this.textSearch1_Load);
            // 
            // tbpFiles
            // 
            this.tbpFiles.Controls.Add(this.fileSearch1);
            this.tbpFiles.Location = new System.Drawing.Point(4, 22);
            this.tbpFiles.Name = "tbpFiles";
            this.tbpFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFiles.Size = new System.Drawing.Size(451, 491);
            this.tbpFiles.TabIndex = 1;
            this.tbpFiles.Text = "Files";
            this.tbpFiles.UseVisualStyleBackColor = true;
            // 
            // fileSearch1
            // 
            this.fileSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSearch1.Location = new System.Drawing.Point(3, 3);
            this.fileSearch1.Name = "fileSearch1";
            this.fileSearch1.Size = new System.Drawing.Size(445, 485);
            this.fileSearch1.TabIndex = 0;
            // 
            // tbpDb
            // 
            this.tbpDb.Controls.Add(this.dbExplore1);
            this.tbpDb.Controls.Add(this.dbConnect);
            this.tbpDb.Location = new System.Drawing.Point(4, 22);
            this.tbpDb.Name = "tbpDb";
            this.tbpDb.Size = new System.Drawing.Size(451, 491);
            this.tbpDb.TabIndex = 2;
            this.tbpDb.Text = "Database";
            this.tbpDb.UseVisualStyleBackColor = true;
            this.tbpDb.Enter += new System.EventHandler(this.tbpDb_Enter);
            // 
            // dbExplore1
            // 
            this.dbExplore1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dbExplore1.Location = new System.Drawing.Point(3, 146);
            this.dbExplore1.Name = "dbExplore1";
            this.dbExplore1.Size = new System.Drawing.Size(451, 345);
            this.dbExplore1.TabIndex = 1;
            // 
            // dbConnect
            // 
            this.dbConnect.AssocCtl = null;
            this.dbConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbConnect.Location = new System.Drawing.Point(0, 0);
            this.dbConnect.Name = "dbConnect";
            this.dbConnect.Size = new System.Drawing.Size(451, 140);
            this.dbConnect.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "...";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Base Folder";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Text To Search *___*";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 20);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ".cs",
            ".xml",
            ".txt",
            ".html",
            ".js"});
            this.comboBox1.Location = new System.Drawing.Point(217, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "File Extension";
            // 
            // frmFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 539);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmFinder";
            this.Text = "Finder";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tbMain.ResumeLayout(false);
            this.tbpText.ResumeLayout(false);
            this.tbpFiles.ResumeLayout(false);
            this.tbpDb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar prgMain;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tbpText;
        private System.Windows.Forms.TabPage tbpDb;
        private System.Windows.Forms.TabPage tbpFiles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private textSearch textSearch1;
        private fileSearch fileSearch1;
        private dbConnect dbConnect;
        private dbExplore dbExplore1;
    }
}

