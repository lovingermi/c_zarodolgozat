using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.ViewInterfaces
{
    interface IModifyView
    {
        string gepCikkszam { get; set; }
        string gepMegnevezes { get; set; }
        List<String> gyartok { get; set; }
        string selectedGyarto { get; set; }
    }
}
