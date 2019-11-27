using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;

namespace SzerszamgepKereskedelem.Repositories
{
    class GepRepository
    {
        private List<gepek> gepekLista;
        private szerszamgepContext db;

        public GepRepository()
        {
            gepekLista = new List<gepek>();
            db = new szerszamgepContext();
            gepekLista = db.gepek.ToList();

        }
        public gepek getGepById(int gepId)
        {

            if (gepekLista.FindIndex(g => g.id == gepId) < 0)
            {
                return null;
            }
            else
            {
                return gepekLista.Find(g => g.id == gepId);
            }
        }
    }
}
