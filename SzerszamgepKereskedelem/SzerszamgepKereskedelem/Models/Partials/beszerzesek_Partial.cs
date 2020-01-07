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
        public string szamlaUresE(beszerzesek beszerzes)
        {
            if (string.IsNullOrEmpty(beszerzes.szamla))
            {
                return "\u2718";
            }
            else
            {
                return "\u2713";
            }
        }
        public string vamUresE(beszerzesek beszerzes)
        {
            if (string.IsNullOrEmpty(beszerzes.VAM))
            {
                return "\u2718";
            }
            else
            {
                return "\u2713";
            }
        }
        public string fuvarUresE(beszerzesek beszerzes)
        {
            if (string.IsNullOrEmpty(beszerzes.fuvar))
            {
                return "\u2718";
            }
            else
            {
                return "\u2713";
            }
        }
        public string cmrUresE(beszerzesek beszerzes)
        {
            if (string.IsNullOrEmpty(beszerzes.CMR))
            {
                return "\u2718";
            }
            else

            {
                return "\u2713";
            }

        }
    }
}
