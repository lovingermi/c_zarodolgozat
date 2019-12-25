using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;

namespace SzerszamgepKereskedelem.ViewInterfaces
{
    interface IAddView
    {
        string gepCikkszam { get; }
        string gepMegnevezes { get; }
        string gepTipus { get; }
        string gepGyatro { get; }
        List<String> gyartok { set; }
        List<String> tipusok { set; }

        string vevoNev { set; }
        string vevoOrszag { set; }
        string vevoTelepules { set; }
        List<String> vevok{ set; }

        DateTime bDatum { get; }
        string bTipus { get; }
        string bEKAR { get; }
        string bSzamla { get; }
        string bVAM { get; }
        string bFuvar { get; }
        string bCMR { get; }

        DateTime eDatum { get; }
        string eTipus { get; }
        string eEKAR { get; }
        string eSzamla { get; }
    }
}
