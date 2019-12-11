using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.Models
{
    public partial class megrendeles
    {
        public megrendeles(int pId, int pGep_Id,int pVevo_Id,int pBeszerzes_Id,int pEladas_Id)
        {

            id = pId;
            gep_Id = pGep_Id;
            vevo_Id = pVevo_Id;
            beszerzes_Id = pBeszerzes_Id;
            eladas_Id = pEladas_Id;
        }
        public megrendeles()
        {

        }
    }
}
