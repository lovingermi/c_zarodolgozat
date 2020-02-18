using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;
using SzerszamgepKereskedelem.Repositories;
using SzerszamgepKereskedelem.Validations;
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
        private CikkszamValidation cikkszamValidation;
        public ModifyPresenter(IModifyView param)
        {
            db = new szerszamgepContext();
            modifyView = param;
        }
        
        public void ModifyMegrendeles(string cikkszam)// Kiválasztot megrendeléshez tartozó gép cikkszám
        {
            //db = new szerszamgepContext();
            modifyGep = db.gepek.SingleOrDefault(m => m.cikkszam==(cikkszam));//Cikkszám alapján gép megkeresése az adatbázisban
            modifyMegrendeles = db.megrendeles.SingleOrDefault(m => m.gep_Id == modifyGep.id);//Gép id alapján megrendelés megkeresése az adatbázisban
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
            //db = new szerszamgepContext();
            try
            {
                cikkszamValidation = new CikkszamValidation(modifyView.gepCikkszam);//Cikkszám ellenőrzés 
                cikkszamValidation.cikkszamValidation();
                modifyGep.cikkszam = modifyView.gepCikkszam;
                modifyGep.megnevezes = modifyView.gepMegnevezes;
                modifyGep.gyarto = modifyView.selectedGyartoTexbox;
                modifyGep.tipus = modifyView.selectedTipusTexbox;
                db.Entry(modifyGep).State = EntityState.Detached;
                db.Entry(modifyGep).State = EntityState.Modified;

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
                // Adatbázis frissítése
                db.SaveChanges();
            }
            catch (CikkszamValidationException cve)
            {
                throw new ModifyPresenterException(cve.Message);
            }
            catch (DbUpdateException)
            {

                throw new ModifyPresenterException("Ez a cikkszám már létezik az adatbázisban!");//Még átnézni

            }
            catch (Exception)
            {
                throw new ModifyPresenterException("Nem sikerült a változásokat elmenteni.");
            }
        }
        public void GetVevoFromNevLista(string vevoNev)
        {
            /*var context = ((IObjectContextAdapter)db).ObjectContext;
            var refreshableObjects = (from entry in context.ObjectStateManager.GetObjectStateEntries(
                                                       EntityState.Added
                                                       | EntityState.Deleted
                                                       | EntityState.Modified
                                                       | EntityState.Unchanged)
                                      where entry.EntityKey != null
                                      select entry.Entity).ToList();

            context.Refresh(RefreshMode.StoreWins, refreshableObjects);*/
            var context = ((IObjectContextAdapter)db).ObjectContext;//adatbázis frissítése az aktuális vevő adatok megjelenítéséhez
            var refreshableObjects = db.ChangeTracker.Entries().Select(c => c.Entity).ToList();
            context.Refresh(RefreshMode.StoreWins, refreshableObjects);
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
