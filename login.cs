using System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace DairySystem
{
    public partial class login : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";

        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(ordb))
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

               
                cmd.CommandText = "select UserID from Users where Username=:u and Password=:p";

                cmd.Parameters.Add("u", txtUser.Text);
                cmd.Parameters.Add("p", txtPass.Text);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int userId = Convert.ToInt32(result);

                    MessageBox.Show("Login Success");

                    Dairy f = new Dairy(userId); 
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}