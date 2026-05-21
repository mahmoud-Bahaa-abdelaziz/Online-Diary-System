using System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace DairySystem
{
    public partial class Dairy : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        int currentUserId;

        
        public Dairy(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void Dairy_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "insert into DiaryEntries values(EntrySeq.NEXTVAL, :p_uid, :p_txt, sysdate)";
            cmd.BindByName = true;

            OracleParameter p1 = new OracleParameter("p_uid", OracleDbType.Int32);
            p1.Value = currentUserId; 

            OracleParameter p2 = new OracleParameter("p_txt", OracleDbType.Varchar2);
            p2.Value = txtEntry.Text;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");
        }

        private void Dairy_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn != null)
                conn.Dispose();
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            View v = new View(currentUserId);
            v.Show();
        }
    }
}
