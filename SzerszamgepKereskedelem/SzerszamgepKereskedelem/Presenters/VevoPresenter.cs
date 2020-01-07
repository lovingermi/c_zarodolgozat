using System;
using System.Collections.Generic;
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
    class VevoPresenter
    {
        private VevoRepository vevoRepository = new VevoRepository();
        private szerszamgepContext db;
        private IAddView addView;
        private VevoNevValidation vevoNevValidation;
        public VevoPresenter(IAddView param)
        {
            db = new szerszamgepContext();
            addView = param;
        }
        public void AddVevo()
        {
            vevok newVevo;
            try
            {
                vevoNevValidation = new VevoNevValidation(addView.vevoNev);
                vevoNevValidation.vevoNevValidation();
                string nev = addView.vevoNev;
                string orszag = addView.vevoOrszag;
                string telepules = addView.vevoTelepules;
                int vevoId = db.vevok.Select(v => v.id).DefaultIfEmpty(0).Max() + 1;
                newVevo = new vevok(vevoId, nev, orszag, telepules, true);

            }
            catch (VevoNevValidationException vve)
            {

                throw new VevoPresenterException(vve.Message); ;
            }
            db.vevok.Add(newVevo);
            try
            {
                // Adatbázis frissítése

                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

            addView.vevok = vevoRepository.getVevoNevLista();
            addView.selectedVevo = newVevo.nev;
        }
        public void DeleteVevo(string vevoNev)
        {
            db = new szerszamgepContext();
            var selectedVevo = (from v in db.vevok where v.nev == vevoNev select v).FirstOrDefault();
            if (selectedVevo != null)
            {
                db.vevok.Remove(selectedVevo);
                
            }
            try
            {
                db.SaveChanges();
                addView.vevok = vevoRepository.getVevoNevLista();
            }
            catch (DbUpdateException)
            {
                throw new VevoPresenterException("A kiválasztott vevőhoz tartozik gép megrendelés, jelenleg nem törölhető!");
            }

        }
    }
}
