﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;
using SzerszamgepKereskedelem.Repositories;
using SzerszamgepKereskedelem.Validations;
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
        private vevok selectedVevo;
        private CikkszamValidation cikkszamValidation;
        //private VevoNevValidation vevoNevValidation;
        public AddPresenter(IAddView param)
        {
            db = new szerszamgepContext();
            addView = param;

        }
        public void addMegrendeles()
        {

            addView.gyartok = gepRepository.getGyartokLista();
            addView.tipusok = gepRepository.getTipusokLista();
            addView.vevok = vevoRepository.getVevoNevLista();
            addView.bTipusLista = beszerzesRepository.getBeszerzesTipusLista();
            addView.eTipusLista = eladasRepository.getEladasTipusLista();

        }
        public void saveMegrendeles()
        {
            int megrendelesId = db.megrendeles.Select(m => m.id).DefaultIfEmpty(0).Max() + 1; // Ha üres a tábla, akkor az alapértelmezett érték 0
            int gepId = db.gepek.Select(g => g.id).DefaultIfEmpty(0).Max() + 1;
            int beszerzesId = db.beszerzesek.Select(b => b.id).DefaultIfEmpty(0).Max() + 1;
            int eladasId = db.eladasok.Select(e => e.id).DefaultIfEmpty(0).Max() + 1;

            //---------------gépek---------------
            string cikkszam;
            try
            {
                cikkszamValidation = new CikkszamValidation(addView.gepCikkszam);//Cikkszám ellenőrzés 
                cikkszamValidation.cikkszamValidation();
                cikkszam = addView.gepCikkszam;
            }
            catch (CikkszamValidationException cve)
            {
                throw new AddPresenterException(cve.Message);
            }
            string megnevezes = addView.gepMegnevezes;
            string gyarto = addView.gepGyatro;
            string tipus = addView.gepTipus;
            gepek newGep = new gepek(gepId, cikkszam, megnevezes, tipus, gyarto);
            //-------------vevő------------------
            int vevoId;
            if (selectedVevo != null)//ha van kiválasztott vevő
            {
                vevoId = selectedVevo.id;
            }
            else
            {
                vevoId = -1; //ha nincs kiválasztott vevő, a vevő táblából az üres rekordra mutat;
            }
            //----------beszerzés------------------
            DateTime bDatum = addView.bDatum;
            string bTipus = addView.bTipus;
            string bEKAR = addView.bEKAR;
            string bSzamla = addView.bSzamla;
            string bVAM = addView.bVAM;
            string bFuvar = addView.bFuvar;
            string bCMR = addView.bCMR;
            beszerzesek beszerzes = new beszerzesek(beszerzesId, bDatum, bTipus, bEKAR, bSzamla, bVAM, bFuvar, bCMR);
            //----------eladás------------------
            DateTime edatum = addView.eDatum;
            string eTipus = addView.eTipus;
            string eSzamla = addView.eSzamla;
            string eEKAR = addView.eEKAR;
            eladasok eladas = new eladasok(eladasId, edatum, eTipus, eSzamla, eEKAR);

            db.beszerzesek.Add(beszerzes);
            db.eladasok.Add(eladas);
            db.gepek.Add(newGep);

            //megrendeles newMegrendeles; 
            megrendeles newMegrendeles = new megrendeles(megrendelesId, gepId, vevoId, beszerzesId, eladasId);
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
        public void GetVevoFromNevLista(string vevoNev)
        {
            selectedVevo = (from v in db.vevok where v.nev == vevoNev select v).FirstOrDefault();
            if (selectedVevo != null)
            {
                addView.vevoNev = selectedVevo.nev;
                addView.vevoOrszag = selectedVevo.orszag;
                addView.vevoTelepules = selectedVevo.varos;
            }
            else
            {
                addView.vevoNev = "";
                addView.vevoOrszag = "";
                addView.vevoTelepules = "";
            }
        }
        /*public void AddVevo()
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

                throw new AddPresenterException(vve.Message); ;
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
        }*/
    }    
}
