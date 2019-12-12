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
    class AddPresenter
    {
        private GepRepository gepRepository = new GepRepository();
        private VevoRepository vevoRepository = new VevoRepository();
        private BeszerzesRepository beszerzesRepository = new BeszerzesRepository();
        private EladasRepository eladasRepository = new EladasRepository();
        private szerszamgepContext db;
        private IAddView addView;
        public AddPresenter(IAddView param)
        {
            db = new szerszamgepContext();
            addView = param;
                     
        }
        public void addMegrendeles()
        {

            addView.gyartok = gepRepository.getGyartokLista();
            addView.tipusok = gepRepository.getTipusokLista();
            int megrendelesId = db.megrendeles.Select(m => m.id).DefaultIfEmpty(0).Max() + 1; // Ha üres a tábla, akkor az alapértelmezett érték 0
            int gepId = db.gepek.Select(g => g.id).DefaultIfEmpty(0).Max()+1;
            int beszerzesId= db.beszerzesek.Select(b => b.id).DefaultIfEmpty(0).Max() + 1;
            int eladasId= db.eladasok.Select(e => e.id).DefaultIfEmpty(0).Max() + 1;
            gepek newGep = new gepek(gepId, "cikkii", "2222222222222", "tititip", "gyartooo");
            beszerzesek beszerzes = new beszerzesek(beszerzesId, new DateTime(2019,01,01), "btipus", "ekar11", "szamla", "Vám11", "", "");
            eladasok eladas = new eladasok(eladasId, new DateTime(2019,02,02), "eladas tipus", "eszamla", "eekar");

            db.beszerzesek.Add(beszerzes);
            db.eladasok.Add(eladas);
            db.gepek.Add(newGep);
            megrendeles newMegrendeles = new megrendeles(megrendelesId, gepId, 1, beszerzesId, eladasId);//addView.megrendeles;
            db.megrendeles.Add(newMegrendeles);
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
    }
}
