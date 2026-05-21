using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace DairySystem
{
    public partial class View : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;

        int currentUserId;

        public View(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        
        private void View_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand cmd = new OracleCommand("GETALLENTRIES", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor)
                              .Direction = ParameterDirection.Output;

                OracleDataReader dr = cmd.ExecuteReader();

                cmbID.Items.Clear();

                while (dr.Read())
                {
                    if (Convert.ToInt32(dr["USERID"]) == currentUserId)
                    {
                        cmbID.Items.Add(dr["ENTRYID"].ToString());
                    }
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }

        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbID.SelectedItem == null)
                {
                    MessageBox.Show("Select ID first");
                    return;
                }

                int id = Convert.ToInt32(cmbID.SelectedItem);

                OracleCommand cmd = new OracleCommand("GetEntryText", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_id", OracleDbType.Int32).Value = id;

                cmd.Parameters.Add("p_text", OracleDbType.Varchar2, 200)
                              .Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                txtEntry.Text = cmd.Parameters["p_text"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Click Error: " + ex.Message);
            }
        }

        
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("GETALLENTRIES", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor)
                              .Direction = ParameterDirection.Output;

                OracleDataReader dr = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("ID", "EntryID");
                dataGridView1.Columns.Add("Text", "EntryText");
                dataGridView1.Columns.Add("Date", "EntryDate");

                while (dr.Read())
                {
                    if (Convert.ToInt32(dr["USERID"]) == currentUserId)
                    {
                        dataGridView1.Rows.Add(
                            dr["ENTRYID"].ToString(),
                            dr["ENTRYTEXT"].ToString(),
                            dr["ENTRYDATE"].ToString()
                        );
                    }
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load All Error: " + ex.Message);
            }
        }

        
        private void btnGetID_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("GetMaxID", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_id", OracleDbType.Int32)
                              .Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                txtIDResult.Text = cmd.Parameters["p_id"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void View_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn != null)
                conn.Dispose();
        }
    }
}