using System;
using System.Collections.Generic;
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
        public ModifyPresenter(IModifyView param)
        {
            db = new szerszamgepContext();
            modifyView = param;
        }
        
        public void ModifyMegrendeles(int id)
        {
            var megrendeles = db.megrendeles.Find(id);
            var gep = db.gepek.Find(megrendeles.gep_Id);
            var beszerzes = db.beszerzesek.Find(megrendeles.beszerzes_Id);
            var eladas = db.eladasok.Find(megrendeles.eladas_Id);
            var vevo = db.vevok.Find(megrendeles.vevo_Id);
            modifyView.gepCikkszam = gep.cikkszam;
            modifyView.gepMegnevezes = gep.megnevezes;
            modifyView.gyartok = gepRepository.getGyartokLista();
            modifyView.selectedGyarto = gep.gyarto;
            modifyView.selectedGyartoTexbox = gep.gyarto;
            modifyView.tipusok = gepRepository.getTipusokLista();
            modifyView.selectedTipus = gep.tipus;
            modifyView.selectedTipusTexbox = gep.tipus;

            modifyView.selectedVevoNev = vevo.nev;
            modifyView.selectedVevoOrszag = vevo.orszag;
            modifyView.selectedVevoTelepules = vevo.varos;
            modifyView.vevok = vevoRepository.getVevoNevLista();
            modifyView.selectedVevonevCombobox = vevo.nev;

            modifyView.beszerzesTipusLista = beszerzesRepository.getBeszerzesTipusLista();
            modifyView.selectedBeszerzesTipus = beszerzes.beszerzes_Tipus;
            modifyView.beszerzesDatum = beszerzes.datum;
            modifyView.beszrzesCMR = beszerzes.CMR;
            modifyView.beszrzesEKARSZAM = beszerzes.EKAR_Szam;
            modifyView.beszrzesFuvar = beszerzes.fuvar;
            modifyView.beszrzesSzamlaszam = beszerzes.szamla;
            modifyView.beszrzesVAM = beszerzes.VAM;

            modifyView.eladasTipusLista = eladasRepository.getEladasTipusLista();
            modifyView.selectedeladasTipus = eladas.tipus;
            modifyView.eladasDatum = eladas.datum;
            modifyView.eladasEKARSZAM = eladas.EKAR_Szam;
            modifyView.eladasSzamlaszam = eladas.szamlaszam;
        }
    }
}
