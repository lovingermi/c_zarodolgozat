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

        string vevoNev { get; set; }
        string vevoOrszag { get; set; }
        string vevoTelepules { get; set; }
        List<String> vevok{ set; }
        string selectedVevo { set; }

        List<String> bTipusLista { set; }
        DateTime bDatum { get; }
        string bTipus { get; }
        string bEKAR { get; }
        string bSzamla { get; }
        string bVAM { get; }
        string bFuvar { get; }
        string bCMR { get; }

        List<String> eTipusLista { set; }
        DateTime eDatum { get; }
        string eTipus { get; }
        string eEKAR { get; }
        string eSzamla { get; }
    }
}
