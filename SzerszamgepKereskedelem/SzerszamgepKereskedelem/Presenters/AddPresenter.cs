using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;
using SzerszamgepKereskedelem.ViewInterfaces;

namespace SzerszamgepKereskedelem.Presenters
{
    class AddPresenter
    {
        private szerszamgepContext db;
        private IAddView addView;
        private megrendeles newMegrendeles;
        private vevok newVevo;
        private gepek newGep;
        public AddPresenter(IAddView param)
        {
            db = new szerszamgepContext();
            newGep = new gepek();
            addView = param;
        }
        public void addMegrendeles()
        {
            
            int id = db.megrendeles.Select(m => m.id).DefaultIfEmpty(0).Max() + 1; // Ha üres a tábla, akkor az alapértelmezett érték 0
            int gepId = db.gepek.Select(m => m.id).DefaultIfEmpty(0).Max()+1;
            newGep = new gepek(gepId, "cikkii", "2222222222222", "tititip", "gyartooo");
            db.gepek.Add(newGep);
            newMegrendeles = new megrendeles(id, gepId, 1, 1, 1);//addView.megrendeles;
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
