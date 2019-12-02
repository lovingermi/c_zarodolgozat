using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;

namespace SzerszamgepKereskedelem.ViewInterfaces
{
    interface IMainView
    {
        //List<gepek> gepekLista { set; }
        DataTable dataTableFoTabla { set; }
        gepek gepek { get; set; }
        megrendeles megrendeles { get; set; }
        beszerzesek beszerzesek { get; set; }
        eladasok eladasok { get; set; }
        string teszt { get; set; }

    }
}
