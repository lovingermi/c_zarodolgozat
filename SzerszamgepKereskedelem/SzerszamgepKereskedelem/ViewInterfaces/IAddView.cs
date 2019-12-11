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
        gepek gepek { get; set; }
       
    }
}
