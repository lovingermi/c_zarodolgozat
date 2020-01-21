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
        string beszDatum { set; }
        string beszTipus { set; }
        string beszEKAR { set; }
        string beszSzamla { set; }
        string VAMHatarozat { set; }
        string beszFuvar { set; }
        string beszCMR { set; }
        string vevoNev { set; }
        string vevoOrszag { set; }
        string vevoTelepules { set; }
        string eladasDatum { set; }
        string eladasTipus { set; }
        string eladasEKAR { set; }
        string eladasSzamla { set; }

    }
}
