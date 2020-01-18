using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;
using SzerszamgepKereskedelem.ViewInterfaces;

namespace SzerszamgepKereskedelem.Presenters
{
    class ReportPresenter
    {
        private megrendeles selectedMegrendeles;
        private gepek selectedGep;
        private beszerzesek selectedBeszerzes;
        private eladasok selectedEladas;
        private vevok selectedVevo;
        private szerszamgepContext db;
        private IReportView reportView;
        public ReportPresenter(IReportView param)
        {
            db = new szerszamgepContext();
            reportView = param;
        }
        public void getSelectedMegrendeles(string cikkszam)// Kiválasztot megrendeléshez tartozó gép cikkszám
        {

            selectedGep = db.gepek.SingleOrDefault(m => m.cikkszam == (cikkszam));//Cikkszám alapján gép megkeresése az adatbázisban
            selectedMegrendeles = db.megrendeles.SingleOrDefault(m => m.gep_Id == selectedGep.id);//Gép id alapján megrendelés megkeresése az adatbázisban
            selectedBeszerzes = db.beszerzesek.Find(selectedMegrendeles.beszerzes_Id);
            selectedEladas = db.eladasok.Find(selectedMegrendeles.eladas_Id);
            selectedVevo = db.vevok.Find(selectedMegrendeles.vevo_Id);
            reportView.gepCikkszam = selectedGep.cikkszam;
            reportView.gepMegnevezes = selectedGep.megnevezes;
            reportView.gepGyarto = selectedGep.gyarto;
            reportView.gepTipus = selectedGep.tipus;
        }
    }
}
