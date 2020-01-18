using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.ViewInterfaces
{
    interface IReportView
    {
        string gepCikkszam { set; }
        string gepMegnevezes { set; }
        string gepGyarto { set; }
        string gepTipus { set; }
    }
}
