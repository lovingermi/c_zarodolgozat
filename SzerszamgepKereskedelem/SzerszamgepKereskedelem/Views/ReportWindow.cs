using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzerszamgepKereskedelem.Presenters;
using SzerszamgepKereskedelem.ViewInterfaces;

namespace SzerszamgepKereskedelem.Views
{
    public partial class ReportWindow : Form, IReportView
    {
        private ReportParameter[] allPar = new ReportParameter[4];
        private ReportPresenter reportPresenter;
        public ReportWindow(string cikkszam)
        {
            InitializeComponent();
            reportPresenter = new ReportPresenter(this);

            reportPresenter.getSelectedMegrendeles(cikkszam);
            
        }

        public string gepCikkszam
        {
            set
            {
                string cikkszam = value;
                // create parameters array
                ReportParameter parCikkszam = new ReportParameter("cikkszam", cikkszam);
                allPar[0] = parCikkszam; //assign parameters to parameter array
            }
        }

        public string gepMegnevezes
        {
            set
            {
                string megnevezes = value;
                if (String.IsNullOrEmpty(megnevezes))
                {
                    megnevezes = " ";
                }
                ReportParameter parMegnevezes = new ReportParameter("megnevezes", megnevezes);
                allPar[1] = parMegnevezes;
            }
        }

        public string gepGyarto
        {
            set
            {
                string gyarto = value;
                if (String.IsNullOrEmpty(gyarto))
                {
                    gyarto = " ";
                }
                ReportParameter parGyarto = new ReportParameter("gyarto", gyarto);
                allPar[2] = parGyarto;
            }
        }
        public string gepTipus
        {
            set
            {
                string tipus = value;
                if (String.IsNullOrEmpty(tipus))
                {
                    tipus = " ";
                }
                ReportParameter parTipus = new ReportParameter("tipus", tipus);
                allPar[3] = parTipus;
                reportViewer1.LocalReport.SetParameters(allPar);
                this.reportViewer1.RefreshReport();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
