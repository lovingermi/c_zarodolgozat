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
        DataTable dataTableFoTabla { set; }
        string query { get; }
        DateTime kezdoDatum { get; }
        DateTime zaroDatum { get; }
        int lapok { set; }
    }
}
