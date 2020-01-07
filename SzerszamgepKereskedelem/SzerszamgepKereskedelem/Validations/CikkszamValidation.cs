using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.Validations
{
    class CikkszamValidation
    {
        private string Cikkszam;
        public CikkszamValidation(string cikkszam)
        {
            this.Cikkszam = cikkszam;
        }
        public void cikkszamValidation()
        {

            if (cikkszamIsWrong())
            {
                throw new CikkszamValidationException("A cikkszám mező nem lehet üres!");
            }
        }
        private bool cikkszamIsWrong()
        {
            if (Cikkszam==string.Empty) //Nem lett kitöltve a cikkszám mező
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
