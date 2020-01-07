using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.Validations
{
    class VevoNevValidation
    {
        private string VevoNev;
        public VevoNevValidation(string vevoNev)
        {
            this.VevoNev = vevoNev;
        }
        public void vevoNevValidation()
        {

            if (vevoNevIsWrong())
            {
                throw new VevoNevValidationException("A név mező nem lehet üres!");
            }
        }
        private bool vevoNevIsWrong()
        {
            if (VevoNev == string.Empty) //Nem lett kitöltve a vevő név mező
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
