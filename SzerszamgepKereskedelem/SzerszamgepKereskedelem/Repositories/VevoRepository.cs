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
        private List<string> vevoNevLista;
        private szerszamgepContext db;

        public VevoRepository()
        {
            
            vevoNevLista = new List<string>();
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
        public List<string> getVevoNevLista()
        {

            foreach (var item in vevokLista)
            {
                if (item.nev != "")
                {
                    vevoNevLista.Add(item.nev);
                }
            }
            vevoNevLista = vevoNevLista.Distinct().OrderBy(t => t).ToList();
            vevoNevLista.Insert(0, "-------Kérem válasszon-------");
            return vevoNevLista;
        }
    }
}
