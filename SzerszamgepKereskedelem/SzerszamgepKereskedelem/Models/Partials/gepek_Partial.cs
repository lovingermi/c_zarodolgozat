using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.Models
{
    public partial class gepek
    {
        public gepek(int pId, string pCikkszam, string pMegnevezes, string pTipus, string pGyarto)
        {
            id = pId;
            cikkszam = pCikkszam;
            megnevezes = pMegnevezes;
            tipus = pTipus;
            gyarto = pGyarto;
        }
       
    }
}
