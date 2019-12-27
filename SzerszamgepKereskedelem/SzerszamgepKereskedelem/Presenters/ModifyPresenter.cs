using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;
using SzerszamgepKereskedelem.Repositories;
using SzerszamgepKereskedelem.ViewInterfaces;

namespace SzerszamgepKereskedelem.Presenters
{
    class ModifyPresenter
    {
        private GepRepository gepRepository = new GepRepository();
        private VevoRepository vevoRepository = new VevoRepository();
        private BeszerzesRepository beszerzesRepository = new BeszerzesRepository();
        private EladasRepository eladasRepository = new EladasRepository();
        private szerszamgepContext db;
        private IModifyView modifyView;
        private megrendeles modifyMegrendeles;
        private gepek modifyGep;
        private beszerzesek modifyBeszerzes;
        private eladasok modifyEladas;
        private vevok modifyVevo;
        public ModifyPresenter(IModifyView param)
        {
            db = new szerszamgepContext();
            modifyView = param;
        }
        
        public void ModifyMegrendeles(int id)
        {
            modifyMegrendeles = db.megrendeles.Find(id);
            modifyGep = db.gepek.Find(modifyMegrendeles.gep_Id);
            modifyBeszerzes = db.beszerzesek.Find(modifyMegrendeles.beszerzes_Id);
            modifyEladas = db.eladasok.Find(modifyMegrendeles.eladas_Id);
            modifyVevo = db.vevok.Find(modifyMegrendeles.vevo_Id);
            modifyView.gepCikkszam = modifyGep.cikkszam;
            modifyView.gepMegnevezes = modifyGep.megnevezes;
            modifyView.gyartok = gepRepository.getGyartokLista();
            modifyView.selectedGyarto = modifyGep.gyarto;
            modifyView.selectedGyartoTexbox = modifyGep.gyarto;
            modifyView.tipusok = gepRepository.getTipusokLista();
            modifyView.selectedTipus = modifyGep.tipus;
            modifyView.selectedTipusTexbox = modifyGep.tipus;

            modifyView.selectedVevoNev = modifyVevo.nev;
            modifyView.selectedVevoOrszag = modifyVevo.orszag;
            modifyView.selectedVevoTelepules = modifyVevo.varos;
            modifyView.vevok = vevoRepository.getVevoNevLista();
            modifyView.selectedVevonevCombobox = modifyVevo.nev;
            

            modifyView.beszerzesTipusLista = beszerzesRepository.getBeszerzesTipusLista();
            modifyView.selectedBeszerzesTipus = modifyBeszerzes.beszerzes_Tipus;
            modifyView.beszerzesDatum = modifyBeszerzes.datum;
            modifyView.beszrzesCMR = modifyBeszerzes.CMR;
            modifyView.beszrzesEKARSZAM = modifyBeszerzes.EKAR_Szam;
            modifyView.beszrzesFuvar = modifyBeszerzes.fuvar;
            modifyView.beszrzesSzamlaszam = modifyBeszerzes.szamla;
            modifyView.beszrzesVAM = modifyBeszerzes.VAM;

            modifyView.eladasTipusLista = eladasRepository.getEladasTipusLista();
            modifyView.selectedEladasTipus = modifyEladas.tipus;
            modifyView.eladasDatum = modifyEladas.datum;
            modifyView.eladasEKARSZAM = modifyEladas.EKAR_Szam;
            modifyView.eladasSzamlaszam = modifyEladas.szamlaszam;
        }
        public void saveModify()
        {
            //-----------------gépek------------------
            modifyGep.cikkszam = modifyView.gepCikkszam;
            modifyGep.megnevezes = modifyView.gepMegnevezes;
            modifyGep.gyarto = modifyView.selectedGyartoTexbox;
            modifyGep.tipus = modifyView.selectedTipusTexbox;
            db.Entry(modifyGep).State = EntityState.Detached;
            db.Entry(modifyGep).State = EntityState.Modified;

            //---------------vevők--------------------------
            /*modifyVevo.nev = modifyView.selectedVevoNev;
            modifyVevo.orszag = modifyView.selectedVevoOrszag;
            modifyVevo.varos = modifyView.selectedVevoTelepules;
            db.Entry(modifyVevo).State = EntityState.Detached;
            db.Entry(modifyVevo).State = EntityState.Modified;*/

            //--------------beszerzések----------------------
            modifyBeszerzes.datum = modifyView.beszerzesDatum;
            modifyBeszerzes.beszerzes_Tipus = modifyView.selectedBeszerzesTipus;
            modifyBeszerzes.EKAR_Szam = modifyView.beszrzesEKARSZAM;
            modifyBeszerzes.szamla = modifyView.beszrzesSzamlaszam;
            modifyBeszerzes.VAM = modifyView.beszrzesVAM;
            modifyBeszerzes.fuvar = modifyView.beszrzesFuvar;
            modifyBeszerzes.CMR = modifyView.beszrzesCMR;
            db.Entry(modifyBeszerzes).State = EntityState.Detached;
            db.Entry(modifyBeszerzes).State = EntityState.Modified;

            //--------------eladások------------------------
            modifyEladas.datum = modifyView.eladasDatum;
            modifyEladas.tipus = modifyView.selectedEladasTipus;
            modifyEladas.szamlaszam = modifyView.eladasSzamlaszam;
            modifyEladas.EKAR_Szam = modifyView.eladasEKARSZAM;
            db.Entry(modifyEladas).State = EntityState.Detached;
            db.Entry(modifyEladas).State = EntityState.Modified;

            //--------------megrendeles------------------------
            vevok selectedVevo = (from v in db.vevok where v.nev == modifyView.selectedVevoNev select v).FirstOrDefault();
            modifyMegrendeles.vevo_Id = selectedVevo.id;
            db.Entry(modifyMegrendeles).State = EntityState.Detached;
            db.Entry(modifyMegrendeles).State = EntityState.Modified;
            try
            {
                // Adatbázis frissítése
                db.SaveChanges();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void GetVevoFromNevLista(string vevoNev)
        {
            vevok selectedVevo = (from v in db.vevok where v.nev == vevoNev select v).FirstOrDefault();
            if (selectedVevo != null)
            {
                modifyView.selectedVevoNev = selectedVevo.nev;
                modifyView.selectedVevoOrszag = selectedVevo.orszag;
                modifyView.selectedVevoTelepules = selectedVevo.varos;

            }
            else
            {
                modifyView.selectedVevoNev = "";
                modifyView.selectedVevoOrszag = "";
                modifyView.selectedVevoTelepules = "";

            }

        }
    }
}
