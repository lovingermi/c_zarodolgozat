using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.Models
{
    public partial class beszerzesek
    {
        public beszerzesek(int pId, DateTime pDatum, string pbeszerzes_Tipus, string pEKAR_Szam, string pszamla, string pVAM, string pFuvar, string pCMR)
        {
            id = pId;
            datum = pDatum;
            beszerzes_Tipus = pbeszerzes_Tipus;
            EKAR_Szam = pEKAR_Szam;
            szamla = pszamla;
            VAM = pVAM;
            fuvar = pFuvar;
            CMR = pCMR;
        }
        public bool szamlaUresE(beszerzesek beszerzes)
        {
            if (string.IsNullOrEmpty(beszerzes.szamla))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool vamUresE(beszerzesek beszerzes)
        {
            if (string.IsNullOrEmpty(beszerzes.VAM))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool fuvarUresE(beszerzesek beszerzes)
        {
            if (string.IsNullOrEmpty(beszerzes.fuvar))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool cmrUresE(beszerzesek beszerzes)
        {
            if (string.IsNullOrEmpty(beszerzes.CMR))
            {
                return false;
            }
            else

            {
                return true;
            }

        }
    }
}
