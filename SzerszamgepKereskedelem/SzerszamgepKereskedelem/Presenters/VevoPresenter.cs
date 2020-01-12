using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        private IModifyView modifyView;
        private VevoNevValidation vevoNevValidation;
        //private int selectedVevoIdToModify;
        private vevok vevoToModify;
        public VevoPresenter(IAddView param)
        {
            db = new szerszamgepContext();
            addView = param;
        }
        public VevoPresenter(IModifyView param)
        {
            db = new szerszamgepContext();
            modifyView = param;
        }
        public void AddVevo()//add form
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
        public void DeleteVevo_2(string vevoNev)//Modify form
        {
            var selectedVevo = (from v in db.vevok where v.nev == vevoNev select v).FirstOrDefault();
            if (selectedVevo != null)
            {
                db.vevok.Remove(selectedVevo);

            }
            try
            {
                db.SaveChanges();
                modifyView.vevok = vevoRepository.getVevoNevLista();
            }
            catch (DbUpdateException)
            {
                throw new VevoPresenterException("A kiválasztott vevőhoz tartozik gép megrendelés, jelenleg nem törölhető!");
            }
        }
        public void modifyVevo() //add form
        {
            if (vevoToModify != null)
            {
                vevoToModify.nev = addView.vevoNev;
                vevoToModify.orszag = addView.vevoOrszag;
                vevoToModify.varos = addView.vevoTelepules;
                db.Entry(vevoToModify).State = EntityState.Detached;
                db.Entry(vevoToModify).State = EntityState.Modified;
            }
            try
            {
                db.SaveChanges();               
            }
            catch (DbUpdateException)
            {
                throw;// new VevoPresenterException("A kiválasztott vevőhoz tartozik gép megrendelés, jelenleg nem törölhető!");
            }
            addView.vevok = vevoRepository.getVevoNevLista();
            addView.selectedVevo = vevoToModify.nev;
        }
        public void modifyVevo_2()//Modify form
        {
            if (vevoToModify != null)
            {
                vevoToModify.nev = modifyView.selectedVevoNev;
                vevoToModify.orszag = modifyView.selectedVevoOrszag;
                vevoToModify.varos = modifyView.selectedVevoTelepules;
                db.Entry(vevoToModify).State = EntityState.Detached;
                db.Entry(vevoToModify).State = EntityState.Modified;
            }
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                throw;// new VevoPresenterException("A kiválasztott vevőhoz tartozik gép megrendelés, jelenleg nem törölhető!");
            }
            modifyView.vevok = vevoRepository.getVevoNevLista();
            modifyView.selectedVevonevCombobox = vevoToModify.nev;
        }
        public void AddVevo_2()//Modify form
        {
            vevok newVevo;
            try
            {
                vevoNevValidation = new VevoNevValidation(modifyView.selectedVevoNev);
                vevoNevValidation.vevoNevValidation();
                string nev = modifyView.selectedVevoNev;
                string orszag = modifyView.selectedVevoOrszag;
                string telepules = modifyView.selectedVevoTelepules;
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

            modifyView.vevok = vevoRepository.getVevoNevLista();
            modifyView.selectedVevonevCombobox = newVevo.nev;
        }
        public void selectVevoToModify(string vevoNev)//A módosítás elött megkeresi név alapjána a vevő Id-t
        {
            vevoToModify = (from v in db.vevok where v.nev == vevoNev select v).FirstOrDefault();
        }
    }
}
