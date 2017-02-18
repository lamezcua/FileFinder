namespace MexFinder
{
    partial class dbConnect
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
            this.grpDatabase = new System.Windows.Forms.GroupBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboServers = new System.Windows.Forms.ComboBox();
            this.btnSetDefault = new System.Windows.Forms.Button();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.chkUseIntSec = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboDbs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grpDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatabase
            // 
            this.grpDatabase.Controls.Add(this.txtPasswd);
            this.grpDatabase.Controls.Add(this.txtUserName);
            this.grpDatabase.Controls.Add(this.label11);
            this.grpDatabase.Controls.Add(this.label12);
            this.grpDatabase.Enabled = false;
            this.grpDatabase.Location = new System.Drawing.Point(229, 23);
            this.grpDatabase.Name = "grpDatabase";
            this.grpDatabase.Size = new System.Drawing.Size(181, 112);
            this.grpDatabase.TabIndex = 5;
            this.grpDatabase.TabStop = false;
            this.grpDatabase.Text = "Database";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(9, 71);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(163, 20);
            this.txtPasswd.TabIndex = 7;
            this.txtPasswd.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(9, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(163, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "User Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Password";
            // 
            // cboServers
            // 
            this.cboServers.FormattingEnabled = true;
            this.cboServers.Location = new System.Drawing.Point(3, 16);
            this.cboServers.Name = "cboServers";
            this.cboServers.Size = new System.Drawing.Size(193, 21);
            this.cboServers.TabIndex = 11;
            this.cboServers.SelectedIndexChanged += new System.EventHandler(this.cboServers_SelectedIndexChanged);
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.Enabled = false;
            this.btnSetDefault.Location = new System.Drawing.Point(3, 83);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Size = new System.Drawing.Size(94, 27);
            this.btnSetDefault.TabIndex = 10;
            this.btnSetDefault.Text = "Set As Default";
            this.btnSetDefault.UseVisualStyleBackColor = true;
            this.btnSetDefault.Click += new System.EventHandler(this.btnSetDefault_Click);
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(103, 83);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(94, 27);
            this.btnTestConn.TabIndex = 9;
            this.btnTestConn.Text = "Test Connection";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // chkUseIntSec
            // 
            this.chkUseIntSec.AutoSize = true;
            this.chkUseIntSec.Checked = true;
            this.chkUseIntSec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseIntSec.Location = new System.Drawing.Point(236, 0);
            this.chkUseIntSec.Name = "chkUseIntSec";
            this.chkUseIntSec.Size = new System.Drawing.Size(137, 17);
            this.chkUseIntSec.TabIndex = 8;
            this.chkUseIntSec.Text = "Use Integrated Security";
            this.chkUseIntSec.UseVisualStyleBackColor = true;
            this.chkUseIntSec.CheckedChanged += new System.EventHandler(this.chkUseIntSec_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "SQL Server To Connect";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(3, 113);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(194, 23);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Disconnected";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboDbs
            // 
            this.cboDbs.Enabled = false;
            this.cboDbs.FormattingEnabled = true;
            this.cboDbs.Location = new System.Drawing.Point(3, 56);
            this.cboDbs.Name = "cboDbs";
            this.cboDbs.Size = new System.Drawing.Size(193, 21);
            this.cboDbs.TabIndex = 13;
            this.cboDbs.SelectedIndexChanged += new System.EventHandler(this.cboDbs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Databases";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(200, 16);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(23, 23);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "..";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dbConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDbs);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSetDefault);
            this.Controls.Add(this.cboServers);
            this.Controls.Add(this.btnTestConn);
            this.Controls.Add(this.grpDatabase);
            this.Controls.Add(this.chkUseIntSec);
            this.Controls.Add(this.label13);
            this.Name = "dbConnect";
            this.Size = new System.Drawing.Size(413, 141);
            this.grpDatabase.ResumeLayout(false);
            this.grpDatabase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatabase;
        private System.Windows.Forms.ComboBox cboServers;
        private System.Windows.Forms.Button btnSetDefault;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.CheckBox chkUseIntSec;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboDbs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
    }
}
