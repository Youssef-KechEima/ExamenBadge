using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ExamenBadge
{
    public partial class Imprimer : Form
    {
        ReportClass r;
        string stg;
        public Imprimer(ReportClass _r,string _stg)
        {
            this.r = _r;
            this.stg = _stg;
            InitializeComponent();
        }

        private void Imprimer_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = r;
            crystalReportViewer1.SelectionFormula = stg;
        }
    }
}
