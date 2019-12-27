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
        List<String> gyartok { set; }
        string selectedGyarto { set; }
        string selectedGyartoTexbox { get; set; }
        List<String> tipusok { set; }
        string selectedTipus { set; }
        string selectedTipusTexbox { get; set; }

        string selectedVevoNev { get; set; }
        string selectedVevoOrszag { get; set; }
        string selectedVevoTelepules { get; set; }
        string selectedVevonevCombobox { set; }
        List<String> vevok { set; }

        List<String> beszerzesTipusLista { set; }
        string selectedBeszerzesTipus { get; set; }
        DateTime beszerzesDatum { get; set; }
        string beszrzesEKARSZAM { get; set; }
        string beszrzesSzamlaszam { get; set; }
        string beszrzesVAM { get; set; }
        string beszrzesFuvar { get; set; }
        string beszrzesCMR { get; set; }

        List<String> eladasTipusLista { set; }
        string selectedEladasTipus { get; set; }
        DateTime eladasDatum { get; set; }
        string eladasEKARSZAM { get; set; }
        string eladasSzamlaszam { get; set; }
    }
}
