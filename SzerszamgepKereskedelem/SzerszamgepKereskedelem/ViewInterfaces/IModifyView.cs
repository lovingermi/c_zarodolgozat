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
        string selectedGyartoTexbox { get; set; }
        List<String> tipusok { get; set; }
        string selectedTipus { get; set; }
        string selectedTipusTexbox { get; set; }

        string selectedVevoNev { get; set; }
        string selectedVevoOrszag { get; set; }
        string selectedVevoTelepules { get; set; }
        string selectedVevonevCombobox { get; set; }
        List<String> vevok { get; set; }

        List<String> beszerzesTipusLista { get; set; }
        string selectedBeszerzesTipus { get; set; }
        DateTime beszerzesDatum { get; set; }
        string beszrzesEKARSZAM { get; set; }
        string beszrzesSzamlaszam { get; set; }
        string beszrzesVAM { get; set; }
        string beszrzesFuvar { get; set; }
        string beszrzesCMR { get; set; }

        List<String> eladasTipusLista { get; set; }
        string selectedeladasTipus { get; set; }
        DateTime eladasDatum { get; set; }
        string eladasEKARSZAM { get; set; }
        string eladasSzamlaszam { get; set; }
    }
}
