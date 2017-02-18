using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MexFinder
{
    public struct SearchSettings
    {
        public string BasePath;
        public string FileExtension;
        public string TextToSearch;
    }

    public delegate void DisplayStatus(string text);

    public partial class frmFinder : Form
    {
   
        public frmFinder()
        {
            InitializeComponent();
            //dbExplore1.ConnectionString = dbConnect.ConnectionString;
            dbConnect.AssocCtl = dbExplore1;
            dbExplore1.FrmParent = this;
            fileSearch1.FrmParent = this;
            textSearch1.FrmParent = this;
        }

        void tbpDb_Enter(object sender, System.EventArgs e)
        {
            dbConnect.AssocCtl.Enabled = false;
        }

        public void SetStatus(string text)
        {
            lblStatus.Text = text;
        }
        private void textSearch1_Load(object sender, EventArgs e)
        {

        }
     
        
    }

}