using System;
using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

using CrystalDecisions.Shared;

namespace DairySystem
{
    public partial class ReportForm : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        public ReportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport1 rpt = new CrystalReport1();

            
            crystalReportViewer2.ReportSource = rpt;

            crystalReportViewer2.Refresh();

        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
