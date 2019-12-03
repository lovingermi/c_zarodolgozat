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
            modifyView.gepCikkszam = gep.cikkszam;
            modifyView.gepMegnevezes = gep.megnevezes;
            modifyView.gyartok = gepRepository.getGyartokLista();
            modifyView.selectedGyarto = gep.gyarto;
        }
    }
}
