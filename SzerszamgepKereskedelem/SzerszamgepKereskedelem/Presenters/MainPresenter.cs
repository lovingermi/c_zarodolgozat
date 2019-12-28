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
        public MainPresenter(IMainView param)
        {
            mainView = param;
            db = new szerszamgepContext();
            CreateDataTable();
            query = db.megrendeles;
            LoadData();
            
        }
        public void CreateDataTable()
        {
            
            dataTableFoTabla.Columns.Add("id", typeof(int));
            dataTableFoTabla.Columns.Add("Gép cikkszám", typeof(string));
            dataTableFoTabla.Columns.Add("Megnevezés", typeof(string));
            dataTableFoTabla.Columns.Add("Vevő", typeof(string));
            dataTableFoTabla.Columns.Add("Besz. Dátum", typeof(DateTime));
            dataTableFoTabla.Columns.Add("Besz. Típus", typeof(string));
            dataTableFoTabla.Columns.Add("Besz. EKAR szám", typeof(string));
            dataTableFoTabla.Columns.Add("Számla", typeof(bool));
            dataTableFoTabla.Columns.Add("Vám", typeof(bool));
            dataTableFoTabla.Columns.Add("Fuvar", typeof(bool));
            dataTableFoTabla.Columns.Add("CMR", typeof(bool));
            dataTableFoTabla.Columns.Add("El. Dátum", typeof(DateTime));
            dataTableFoTabla.Columns.Add("Eladás típusa", typeof(string));
            dataTableFoTabla.Columns.Add("Számlaszám", typeof(string));
            dataTableFoTabla.Columns.Add("El. EKAR", typeof(string));
        }
        public void LoadData()
        {
            dataTableFoTabla.Clear();
            db = new szerszamgepContext();
            foreach (megrendeles megrendeles in query)//.OrderBy(x => x.id).Skip(10).Take(10) gombhoz!!! db.megrendeles
            {
                
                gepek gep =gepRepository.getGepById(megrendeles.gep_Id);
                vevok vevo = vevoRepository.getVevoById(megrendeles.vevo_Id);
                beszerzesek beszerzes = beszerzesRepository.getBeszerzesById(megrendeles.beszerzes_Id);
                eladasok eladas = eladasRepository.getEladasById(megrendeles.eladas_Id);
                dataTableFoTabla.Rows.Add(
                    megrendeles.id,
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
            }
            
            mainView.dataTableFoTabla = dataTableFoTabla;
        }
        public void DeleteMegrendeles(int id)
        {
            db = new szerszamgepContext();
            var tmegrendeles = db.megrendeles.Find(id);
            var gep = db.gepek.Find(tmegrendeles.gep_Id);
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

            LoadData();
        }
        public void getCikkszam()
        {

            string cikkszam = mainView.query;
            query = db.megrendeles.Where(m => m.gepek.cikkszam.Contains(cikkszam)).OrderBy(x => x.gepek.cikkszam);
            LoadData();
        }
        public void getVevo()
        {

            string vevoNev = mainView.query;
            query = db.megrendeles.Where(m => m.vevok.nev.Contains(vevoNev)).OrderBy(x => x.vevok.nev);
            LoadData();
        }
    }
}
