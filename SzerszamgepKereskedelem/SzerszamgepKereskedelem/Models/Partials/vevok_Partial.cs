using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.Models
{
    public partial class vevok
    {
        public vevok(int pId,string pNev, string pOrszag, string pVaros, bool pAktiv)
        {
            id = pId;
            nev = pNev;
            orszag = pOrszag;
            varos = pVaros;
            aktiv = pAktiv; 
        }
    }
}
