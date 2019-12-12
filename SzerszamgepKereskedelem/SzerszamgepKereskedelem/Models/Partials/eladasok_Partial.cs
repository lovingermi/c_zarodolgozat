using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.Models
{
    public partial class eladasok
    {
        public eladasok(int pId, DateTime pDatum, string pTipus, string pSzamla, string pEKARSzam)
        {
            id = pId;
            datum = pDatum;
            tipus = pTipus;
            szamlaszam = pSzamla;
            EKAR_Szam = pEKARSzam;
        }
    }
}
