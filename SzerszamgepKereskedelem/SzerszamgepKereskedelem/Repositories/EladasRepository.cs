using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;

namespace SzerszamgepKereskedelem.Repositories
{
    class EladasRepository
    {
        private List<eladasok> eladasokLista;
        private szerszamgepContext db;
        public EladasRepository()
        {
            eladasokLista = new List<eladasok>();
            db = new szerszamgepContext();
            eladasokLista = db.eladasok.ToList();
        }
        public eladasok getEladasById(int eladasId)
        {
            if (eladasokLista.FindIndex(e => e.id == eladasId) < 0)
            {
                return null;
            }
            else
            {
                return eladasokLista.Find(e => e.id == eladasId);
            }
        }
    }
}

