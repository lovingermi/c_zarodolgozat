using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.Models
{
    public partial class felhasznalo
    {
        public felhasznalo(int pId, string pFelhasznalonev, string pVezeteknev, string pKeresztnev, string pJelszo, bool pModositas)
        {
            Id= pId;
            felhasznalonev = pFelhasznalonev;
            vezeteknev = pVezeteknev;
            keresztnev = pKeresztnev;
            jelszo = pJelszo;
            modositas = pModositas;
        }
        public felhasznalo()
        {

        }
    }
}
