using System;
using System.Collections.Generic;
using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace DairySystem
{
    public partial class enteries : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";

       
        OracleDataAdapter adapter;
        DataSet ds;
        public enteries()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(ordb);

                adapter = new OracleDataAdapter(
                    "select * from DiaryEntries", conn);

                ds = new DataSet();
                adapter.Fill(ds);

                MessageBox.Show("Rows: " + ds.Tables[0].Rows.Count);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter);

                adapter.Update(ds.Tables[0]);

                MessageBox.Show("Updated Successfully ✔");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void enteries_Load(object sender, EventArgs e)
        {

        }
    }
}
