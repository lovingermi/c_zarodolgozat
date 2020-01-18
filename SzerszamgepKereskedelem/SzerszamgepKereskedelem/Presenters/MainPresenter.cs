using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;
using SzerszamgepKereskedelem.Repositories;
using SzerszamgepKereskedelem.ViewInterfaces;

namespace SzerszamgepKereskedelem.Presenters
{
    class MainPresenter
    {
        
        private DataTable dataTableFoTabla = new DataTable();
        private GepRepository gepRepository = new GepRepository();
        private VevoRepository vevoRepository = new VevoRepository();
        private BeszerzesRepository beszerzesRepository = new BeszerzesRepository();
        private EladasRepository eladasRepository = new EladasRepository();
        private szerszamgepContext db;
        private IMainView mainView;
        private IQueryable query;
        private double sorokSzama;//Aktuális lekérdezés sorainak száma
        //private int aktualisLap;
        public MainPresenter(IMainView param)
        {
            
            db = new szerszamgepContext();
            mainView = param;
            sorokSzama = db.megrendeles.Count();
            query = db.megrendeles.OrderBy(x => x.id).OrderBy(x => x.id).Skip(0).Take(10);
            CreateDataTable();
            getLekerdezesLapokszama(sorokSzama);
            LoadData();
        }
        public void CreateDataTable()
        {
            
            dataTableFoTabla.Columns.Add("Ssz", typeof(int));
            dataTableFoTabla.Columns.Add("Gép cikkszám", typeof(string));
            dataTableFoTabla.Columns.Add("Megnevezés", typeof(string));
            dataTableFoTabla.Columns.Add("Vevő", typeof(string));
            dataTableFoTabla.Columns.Add("Besz. Dátum", typeof(DateTime));
            dataTableFoTabla.Columns.Add("Besz. Típus", typeof(string));
            dataTableFoTabla.Columns.Add("Besz. EKAR szám", typeof(string));
            dataTableFoTabla.Columns.Add("Számla", typeof(string));
            dataTableFoTabla.Columns.Add("Vám", typeof(string));
            dataTableFoTabla.Columns.Add("Fuvar", typeof(string));
            dataTableFoTabla.Columns.Add("CMR", typeof(string));
            dataTableFoTabla.Columns.Add("El. Dátum", typeof(DateTime));
            dataTableFoTabla.Columns.Add("Eladás típusa", typeof(string));
            dataTableFoTabla.Columns.Add("Számlaszám", typeof(string));
            dataTableFoTabla.Columns.Add("El. EKAR", typeof(string));
        }
        public void getLekerdezesLapokszama(double sorokSzama)//Az aktuális lekérdezés sorainak oldalakra bontása tizessével
        {
            double lapok = Math.Ceiling(sorokSzama / 10);//A sorok alapján oldalakra bontás (tizessével) és felkerekítés (8 sor = 1 oldal).
            mainView.lapok = Convert.ToInt32(lapok);// Main form felé elküldeve a lapok száma          
        }
        
        public void LoadData()//Az aktuális lekérdezés oldalakra bontott megjelenítése .Skip(aktualisLapSzam * 10).Take(10);
        {
            db = new szerszamgepContext();
            dataTableFoTabla.Clear();
            int sorszam=1;
            foreach (megrendeles megrendeles in query) 
            {
                gepek gep = gepRepository.getGepById(megrendeles.gep_Id);
                vevok vevo = vevoRepository.getVevoById(megrendeles.vevo_Id);
                beszerzesek beszerzes = beszerzesRepository.getBeszerzesById(megrendeles.beszerzes_Id);
                eladasok eladas = eladasRepository.getEladasById(megrendeles.eladas_Id);
                dataTableFoTabla.Rows.Add(
                    megrendeles.id,//(aktualisLap*10+sorszam),
                    gep.cikkszam,
                    gep.megnevezes,
                    vevo.nev,
                    beszerzes.datum,
                    beszerzes.beszerzes_Tipus,
                    beszerzes.EKAR_Szam,
                    beszerzes.szamlaUresE(beszerzes),
                    beszerzes.vamUresE(beszerzes),
                    beszerzes.fuvarUresE(beszerzes),
                    beszerzes.cmrUresE(beszerzes),
                    eladas.datum,
                    eladas.tipus,
                    eladas.szamlaszam,
                    eladas.EKAR_Szam);
                sorszam++;
            }
            
            mainView.dataTableFoTabla = dataTableFoTabla;
        }
        public void DeleteMegrendeles(string cikkszam)//Kiválasztott megrendelés gép cikkszám
        {
            db = new szerszamgepContext();

            var gep = db.gepek.SingleOrDefault(m => m.cikkszam==(cikkszam));//Ide kellene try ctatch !!!//Cikkszám alapján gép megkeresése az adatbázisban
            var tmegrendeles = db.megrendeles.SingleOrDefault(m => m.gep_Id == gep.id);//Gép id alapján megrendelés megkeresése az adatbázisban
            var beszerzes = db.beszerzesek.Find(tmegrendeles.beszerzes_Id);
            var eladas = db.eladasok.Find(tmegrendeles.eladas_Id);

            if (tmegrendeles != null)
            {               
                db.megrendeles.Remove(tmegrendeles);
                db.gepek.Remove(gep);
                db.beszerzesek.Remove(beszerzes);
                db.eladasok.Remove(eladas);               
            }
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                throw;
            }

            getLekerdezesLapokszama(sorokSzama);
            LoadData();
        }
        public void getCikkszam(int aktualisLapSzam, bool ASC)
        {

            string cikkszam = mainView.query;
            sorokSzama = db.megrendeles.Where(m => m.gepek.cikkszam.Contains(cikkszam)).Count();
            getLekerdezesLapokszama(sorokSzama);
            if (ASC)
            {
                query = db.megrendeles.Where(m => m.gepek.cikkszam.Contains(cikkszam)).OrderBy(x => x.gepek.cikkszam).Skip(aktualisLapSzam * 10).Take(10);
            }
            else
            {
                query = db.megrendeles.Where(m => m.gepek.cikkszam.Contains(cikkszam)).OrderByDescending(x => x.gepek.cikkszam).Skip(aktualisLapSzam * 10).Take(10);
            }
            
            //aktualisLap = aktualisLapSzam;
            LoadData();
        }
        public void getVevo(int aktualisLapSzam, bool ASC)
        {

            string vevoNev = mainView.query;
            sorokSzama = db.megrendeles.Where(m => m.vevok.nev.Contains(vevoNev)).Count();
            getLekerdezesLapokszama(sorokSzama);
            if (ASC)
            {
                query = db.megrendeles.Where(m => m.vevok.nev.Contains(vevoNev)).OrderBy(x => x.vevok.nev).Skip(aktualisLapSzam * 10).Take(10);
            }
            else
            {
                query = db.megrendeles.Where(m => m.vevok.nev.Contains(vevoNev)).OrderByDescending(x => x.vevok.nev).Skip(aktualisLapSzam * 10).Take(10);
            }
            //aktualisLap = aktualisLapSzam;
            LoadData();
        }
        public void getGyarto(int aktualisLapSzam, bool ASC)
        {

            string gyarto = mainView.query;
            sorokSzama = db.megrendeles.Where(m => m.gepek.gyarto.Contains(gyarto)).Count();
            getLekerdezesLapokszama(sorokSzama);
            if (ASC)
            {
                query = db.megrendeles.Where(m => m.gepek.gyarto.Contains(gyarto)).OrderBy(x => x.gepek.gyarto).Skip(aktualisLapSzam * 10).Take(10);
            }
            else
            {
                query = db.megrendeles.Where(m => m.gepek.gyarto.Contains(gyarto)).OrderByDescending(x => x.gepek.gyarto).Skip(aktualisLapSzam * 10).Take(10);
            }
            //aktualisLap = aktualisLapSzam;
            LoadData();
        }
        public void getAlapLista(int aktualisLapSzam, bool ASC)
        {
            sorokSzama = db.megrendeles.Count();
            getLekerdezesLapokszama(sorokSzama);
            if (ASC)
            {
                query = db.megrendeles.OrderBy(x => x.id).Skip(aktualisLapSzam * 10).Take(10);
            }
            else
            {
                query = db.megrendeles.OrderByDescending(x => x.id).Skip(aktualisLapSzam * 10).Take(10);
            }
            
            //aktualisLap = aktualisLapSzam;
            LoadData();
            
        }
        public void getBeszerzesDatum(int aktualisLapSzam, bool ASC)
        {
            DateTime kezdoDatum = mainView.kezdoDatum;
            DateTime zaroDatum = mainView.zaroDatum;
            sorokSzama = db.megrendeles.Where(m => m.beszerzesek.datum >= kezdoDatum && m.beszerzesek.datum <= zaroDatum).Count();
            getLekerdezesLapokszama(sorokSzama);
            if (ASC)
            {
                query = db.megrendeles.Where(m => m.beszerzesek.datum >= kezdoDatum && m.beszerzesek.datum <= zaroDatum).OrderBy(x => x.beszerzesek.datum).
                Skip(aktualisLapSzam * 10).Take(10);
            }
            else
            {
                query = db.megrendeles.Where(m => m.beszerzesek.datum >= kezdoDatum && m.beszerzesek.datum <= zaroDatum).OrderByDescending(x => x.beszerzesek.datum).
                Skip(aktualisLapSzam * 10).Take(10);
            }
            //aktualisLap = aktualisLapSzam;
            LoadData();
        }
        public void getEladasDatum(int aktualisLapSzam, bool ASC)
        {

            DateTime kezdoDatum = mainView.kezdoDatum;
            DateTime zaroDatum = mainView.zaroDatum;
            sorokSzama = db.megrendeles.Where(m => m.eladasok.datum >= kezdoDatum && m.eladasok.datum <= zaroDatum).Count();
            getLekerdezesLapokszama(sorokSzama);
            if (ASC)
            {
                query = db.megrendeles.Where(m => m.eladasok.datum >= kezdoDatum && m.eladasok.datum <= zaroDatum).OrderBy(x => x.eladasok.datum).
                Skip(aktualisLapSzam * 10).Take(10);
            }
            else
            {
                query = db.megrendeles.Where(m => m.eladasok.datum >= kezdoDatum && m.eladasok.datum <= zaroDatum).OrderByDescending(x => x.eladasok.datum).
                Skip(aktualisLapSzam * 10).Take(10);
            }
            //aktualisLap = aktualisLapSzam;
            LoadData();
        }
    }
}
