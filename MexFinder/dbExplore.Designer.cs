namespace MexFinder
{
    partial class dbExplore
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
            this.lstResults = new System.Windows.Forms.ListBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWhat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstResults
            // 
            this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(3, 123);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(275, 212);
            this.lstResults.TabIndex = 2;
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(3, 35);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(186, 20);
            this.txtTable.TabIndex = 3;
            this.txtTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTable_KeyDown);
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(3, 74);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(186, 20);
            this.txtColumns.TabIndex = 4;
            this.txtColumns.KeyDown += new System.Windows.Forms.KeyEventHandler(txtColumns_KeyDown);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(4, 16);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(143, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Find Tables (Name Contains)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Find Columns Named ";
            // 
            // lblWhat
            // 
            this.lblWhat.AutoSize = true;
            this.lblWhat.Location = new System.Drawing.Point(7, 104);
            this.lblWhat.Name = "lblWhat";
            this.lblWhat.Size = new System.Drawing.Size(10, 13);
            this.lblWhat.TabIndex = 7;
            this.lblWhat.Text = ".";
            // 
            // dbExplore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.lstResults);
            this.Name = "dbExplore";
            this.Size = new System.Drawing.Size(281, 341);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void txtColumns_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (txtColumns.Text.Trim().Length < 1)
                {
                    return;
                }
                GetAllCols(txtColumns.Text.Trim());
            }

        }

     
        void txtTable_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                DisplayTables(txtTable.Text.Trim());
            }
        }

   

        #endregion

        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWhat;

    }
}
