using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
        private ReportParameter[] allPar = new ReportParameter[18];
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
                ReportParameter parMegnevezes = new ReportParameter("megnevezes", megnevezes);
                allPar[1] = parMegnevezes;
            }
        }

        public string gepGyarto
        {
            set
            {
                string gyarto = value;
                ReportParameter parGyarto = new ReportParameter("gyarto", gyarto);
                allPar[2] = parGyarto;
            }
        }
        public string gepTipus
        {
            set
            {
                string tipus = value;
                ReportParameter parTipus = new ReportParameter("tipus", tipus);
                allPar[3] = parTipus;
            }
        }

        public string beszDatum
        {
            set
            {
                string bDatum = value;
                ReportParameter parTipus = new ReportParameter("beszDatum", bDatum);
                allPar[4] = parTipus;
            }
            
        }

        public string beszEKAR
        {
            set
            {
                string bEKAR = value;
                ReportParameter parTipus = new ReportParameter("beszEKAR", bEKAR);
                allPar[5] = parTipus;
            }
        }

        public string beszTipus
        {
            set
            {
                string bTipus = value;
                ReportParameter parTipus = new ReportParameter("beszTipus", bTipus);
                allPar[6] = parTipus;
            }
        }

        public string beszSzamla
        {
            set
            {
                string bSzamla = value;
                ReportParameter parTipus = new ReportParameter("beszSzamla", bSzamla);
                allPar[7] = parTipus;
            }
        }

        public string VAMHatarozat
        {
            set
            {
                string VAMHAT = value;
                ReportParameter parTipus = new ReportParameter("beszVAM", VAMHAT);
                allPar[8] = parTipus;
                
            }
        }

        public string beszFuvar
        {
            set
            {
                string fuvar = value;
                ReportParameter parTipus = new ReportParameter("beszFuvar", fuvar);
                allPar[9] = parTipus;
            }
        }
        public string beszCMR
        {
            set
            {
                string bCMR = value;
                ReportParameter parTipus = new ReportParameter("beszCMR", bCMR);
                allPar[10] = parTipus;    
            }
            
        }

        public string vevoNev
        {
            set
            {
                string vNev = value;
                ReportParameter parTipus = new ReportParameter("vevoNev", vNev);
                allPar[11] = parTipus;
            }
        }
        public string vevoOrszag
        {
            set
            {
                string vOrszag = value;
                ReportParameter parTipus = new ReportParameter("vevoOrszag", vOrszag);
                allPar[12] = parTipus;
            }
        }
        public string vevoTelepules
        {
            set
            {
                string vTelepules = value;
                ReportParameter parTipus = new ReportParameter("vevoTelepules", vTelepules);
                allPar[13] = parTipus;
                
            }
           
        }

        public string eladasDatum
        {
            set
            {
                string eDatum = value;
                ReportParameter parTipus = new ReportParameter("eladasDatum", eDatum);
                allPar[14] = parTipus;
            }
        }
        public string eladasTipus
        {
            set
            {
                string eTipus = value;
                ReportParameter parTipus = new ReportParameter("eladasTipus", eTipus);
                allPar[15] = parTipus;
            }
        }
        public string eladasEKAR
        {
            set
            {
                string eEKAR = value;
                ReportParameter parTipus = new ReportParameter("eladasEKAR", eEKAR);
                allPar[16] = parTipus;
            }
        }
        public string eladasSzamla
        {
            set
            {
                string eSzamla = value;
                ReportParameter parTipus = new ReportParameter("eladasSzamla", eSzamla);
                allPar[17] = parTipus;
                reportViewer1.LocalReport.SetParameters(allPar);
                reportViewer1.RefreshReport();
            }
        }

    }
}
