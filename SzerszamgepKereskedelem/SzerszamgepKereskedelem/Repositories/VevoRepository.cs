using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;

namespace SzerszamgepKereskedelem.Repositories
{
    class VevoRepository
    {
        private List<vevok> vevokLista;
        private szerszamgepContext db;

        public VevoRepository()
        {
            vevokLista = new List<vevok>();
            db = new szerszamgepContext();
            vevokLista = db.vevok.ToList();
        }
        public vevok getVevoById(int vevoId)
        {
            if (vevokLista.FindIndex(v => v.id == vevoId) < 0)
            {
                return null;
            }
            else
            {
                return vevokLista.Find(v => v.id == vevoId);
            }
        }
    }
}
