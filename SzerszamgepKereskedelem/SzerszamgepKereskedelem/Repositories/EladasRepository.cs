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
        private List<string> eladasTipusLista;
        private szerszamgepContext db;
        public EladasRepository()
        {
            eladasokLista = new List<eladasok>();
            eladasTipusLista = new List<string>();
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
        public List<String> getEladasTipusLista()
        {
            eladasTipusLista.Add("Belföldi");
            eladasTipusLista.Add("Export");
            eladasTipusLista.Add("Közösségi");
            eladasTipusLista.Add("Háromszögügylet");
            return eladasTipusLista;
        }
    }
}

