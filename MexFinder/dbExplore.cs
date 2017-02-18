using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace MexFinder
{
    public partial class dbExplore : UserControl
    {
        private frmFinder parent;
        internal frmFinder FrmParent
        {
            get { return parent; }
            set { parent = value; }
        }

        private string connectionString;

        public string ConnectionString
        {
            set { connectionString = value; }
        }

        public dbExplore()
        {
            InitializeComponent();
        }

        public void ResetConnection()
        {
            txtTable.Text = String.Empty;
            txtColumns.Text = String.Empty;
            lstResults.Items.Clear();
            this.Enabled = false;
            FrmParent.SetStatus("Connection string reset!");
        }

        private void DisplayTables(string p)
        {
            lblWhat.Text = "Tables";
            if ((connectionString == null) || (connectionString.Trim() == String.Empty))
            {
                FrmParent.SetStatus("Invalid connection string");
                MessageBox.Show("Invalid connection string");
                return;
            }
            lstResults.Items.Clear();
            try
            {
                foreach (string s in FetchTables(p))
                {
                    lstResults.Items.Add(s);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                FrmParent.SetStatus(e.Message);
            }
        }

        private void GetAllCols(string p)
        {
            lblWhat.Text = String.Format("Columns with criteria \"{0}\"", p);

            if ((connectionString == null) || (connectionString.Trim() == String.Empty))
            {
                MessageBox.Show("Invalid connection string");
                return;
            }
            lstResults.Items.Clear();
            try
            {
                foreach (string s in FetchColumns(p, String.Empty))
                {
                    lstResults.Items.Add(s);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        #region dbMethods
        private string[] FetchTables(string criteria)
        {

            List<string> results = new List<string>();
            string query = @"SELECT table_name  FROM INFORMATION_SCHEMA.tables WITH (NOLOCK) 
            WHERE  TABLE_TYPE = 'BASE TABLE'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (criteria == string.Empty)
                    {
                        while (reader.Read())
                        {
                            results.Add(reader.GetString(0));
                        }
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            if (name.Contains(criteria))
                            {
                                results.Add(name);
                            }
                        }
                    }
                    FrmParent.SetStatus(String.Format("{0} tables fetched", results.Count));
                }
                else
                {
                    results.Add(String.Format("Criteria \"{0}\" yield no matches", criteria));
                    FrmParent.SetStatus("No matches");
                }
            }
            return results.ToArray();
        }

        private string[] FetchColumns(string colCriteria, string tableCriteria)
        {
            List<string> results = new List<string>();
            string[] allTables = FetchTables(string.Empty);

            foreach (string table in allTables)
            {
                string query = String.Format(
                    "SELECT name FROM syscolumns WITH (NOLOCK) WHERE id=object_id('{0}')", table);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            if (name.Contains(colCriteria))
                            {
                                results.Add(String.Format("Table  [ {0} ] has [ {1} ] column", table, name));
                            }
                        }
                    }
                }
                FrmParent.SetStatus(String.Format("{0} columns fetched", results.Count));
                Refresh();
            }
            if (results.Count == 0)
            {
                results.Add(String.Format("No column matched \"{0}\"", colCriteria));
            }
            return results.ToArray();
        }

        #endregion

    }
}