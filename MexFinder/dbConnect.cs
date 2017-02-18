using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MexFinder.Properties;

namespace MexFinder
{
    public partial class dbConnect : UserControl
    {

        Settings settings = new Settings();
        private string connectionString;
        public string ConnectionString
        {
            get { return connectionString; }
        }

        private dbExplore assocCtl;
        public dbExplore AssocCtl
        {
            get { return assocCtl; }
            set { assocCtl = value; }
        }

        public dbConnect() : this(string.Empty,null) { }

        public dbConnect(string defaultConnectionString, dbExplore ctl)
        {
            InitializeComponent();
            connectionString = defaultConnectionString;
            assocCtl = ctl;
            foreach (string s in settings.savedServers)
            {
                cboServers.Items.Add(s);
            }
        }

        private void chkUseIntSec_CheckedChanged(object sender, EventArgs e)
        {
            btnTestConn.Enabled = true;
            assocCtl.ResetConnection();
            if (chkUseIntSec.Checked)
                grpDatabase.Enabled = false;
            else
                grpDatabase.Enabled = true;
        }
        private void SetWait()
        {
            assocCtl.ResetConnection();
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "Trying ...";
            btnBrowse.Enabled = false;
            btnTestConn.Enabled = false;
            btnSetDefault.Enabled = false;
            Refresh();
        }

        private void SetDone(string status,Color color)
        {
            btnBrowse.Enabled = true;
            btnTestConn.Enabled = true;
            lblStatus.Text = status;
            lblStatus.ForeColor = color;
        }

        /// <summary>
        /// Test Connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestConn_Click(object sender, EventArgs e)
        {
            SetWait();
            if (cboServers.Text.Trim().Length < 1)
            {
                SetDone("Enter Server Name or Url", Color.Red);
                return;
            }
            
            string connStr2Test;
            if (chkUseIntSec.Checked)
                connStr2Test = stringConnectionBuilder(cboServers.Text);
            else
                connStr2Test = stringConnectionBuilder(cboServers.Text, txtUserName.Text, txtPasswd.Text);

            cboDbs.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr2Test))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_databases";
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        cboDbs.Enabled = true;
                        connectionString = connStr2Test;
                        while (reader.Read())
                        {
                            cboDbs.Items.Add(reader.GetString(0));
                        }
                        SetDone("Connected", Color.Green);
                        cboServers.Items.Add(cboServers.Text);
                    }
                    else
                    {
                        SetDone("Connection Failed", Color.Yellow);
                        connectionString = String.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                SetDone("Connection Failed", Color.Red);
                connectionString = String.Empty;
            }
        }

        /// <summary>
        /// Builds a connection string suitable for SQL server, using integrated security
        /// </summary>
        /// <param name="serverName">The name (or url) of the server</param>
        /// <returns></returns>
        private static string stringConnectionBuilder(string serverName)
        {
            return "Data Source=" + serverName + ";Integrated Security=SSPI;";
        }
        /// <summary>
        /// Builds a connection string suitable for SQL server 
        /// </summary>
        /// <param name="serverName">The name (or url) of the server</param>
        /// <param name="userName"></param>
        /// <param name="passwd"></param>
        /// <returns></returns>
        private static string stringConnectionBuilder(string serverName, string userName,
                                      string passwd)
        {
            return "Data Source=" + serverName + ";User Id=" + userName + ";Password=" + passwd + ";";
        }

        private void cboDbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDbs.Text.Trim().Length>1)
            {
                btnSetDefault.Enabled = true;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SetWait();
            SqlDataSourceEnumerator servers = SqlDataSourceEnumerator.Instance;
            DataTable serversTable = servers.GetDataSources();
            foreach(DataRow row in serversTable.Rows)
            {
                string serverName = String.Format("{0}\\{1}", row[0], row[1]);
                cboServers.Items.Add(serverName);
            }
            SetDone("Servers Retrieved!", Color.Green);            
        }

        private void cboServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTestConn.Enabled = true;
        }

        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            connectionString = connectionString + ";Initial Catalog=" + cboDbs.Text + ";";
            SetDone("Connection Set", Color.Blue);
            btnSetDefault.Enabled = false;
            btnTestConn.Enabled = false;
            cboDbs.Enabled = false;
            if (!settings.savedServers.Contains(cboServers.Text))
            {
                settings.savedServers.Add(cboServers.Text);
                settings.Save();
            }
            if (assocCtl != null)
            {
                assocCtl.ConnectionString = connectionString;
                assocCtl.Enabled = true;
            }
        }
    }
}
