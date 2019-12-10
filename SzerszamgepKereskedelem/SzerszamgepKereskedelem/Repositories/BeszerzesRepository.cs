using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;

namespace SzerszamgepKereskedelem.Repositories
{
    class BeszerzesRepository
    {
        private List<beszerzesek> beszerzesekLista;
        private List<string> beszerzesTipusLista;
        private szerszamgepContext db;
        public BeszerzesRepository()
        {
            beszerzesekLista = new List<beszerzesek>();
            beszerzesTipusLista = new List<string>();
            db = new szerszamgepContext();
            beszerzesekLista = db.beszerzesek.ToList();
        }
        public beszerzesek getBeszerzesById(int id)
        {
            if (beszerzesekLista.FindIndex(b => b.id == id) < 0)
            {
                return null;
            }
            else
            {
                return beszerzesekLista.Find(b => b.id == id);
            }
        }
        public List<String> getBeszerzesTipusLista()
        {
            beszerzesTipusLista.Add("Belföldi");
            beszerzesTipusLista.Add("Import");
            beszerzesTipusLista.Add("Közösségi");
            beszerzesTipusLista.Add("Háromszögügylet");
            return beszerzesTipusLista;
        }
    }
}
