using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzerszamgepKereskedelem.Presenters;
using SzerszamgepKereskedelem.ViewInterfaces;

namespace SzerszamgepKereskedelem.Views
{
    public partial class ModifyWindow : Form , IModifyView
    {
        private ModifyPresenter modifyPresenter;
        
        public ModifyWindow(int id)
        {
            InitializeComponent();
            modifyPresenter = new ModifyPresenter(this);
            modifyPresenter.ModifyMegrendeles(id);
        }
        public string gepCikkszam
        {
            get
            {
                return null;
            }
            set
            {
                textBoxGepCikkszam.Text = value;
            }
            
        }
        public string gepMegnevezes
        {
            get
            {
                return null;
            }
            set
            {
                textBoxGepMegnevezes.Text = value;
            }
        }

        public List<string> gyartok
        {
            get
            {
                return null;
            }
            set
            {
                comboBoxGyarto.DataSource = value;
            }
        }
        public string selectedGyartoTexbox
        {
            get
            {
                return null;
            }
            set
            {
                textBoxGyarto.Text = value;
            }
        }
        public string selectedGyarto
        {
            get
            {
                return null;
            }
            set
            {
                comboBoxGyarto.Text = value;
            }
        }

        public List<string> tipusok
        {
            get
            {
                return null;
            }
            set
            {
                comboBoxTipus.DataSource = value;
            }
        }
        public string selectedTipus
        {
            get
            {
                return null;
            }
            set
            {
                comboBoxTipus.Text = value;
            }
        }
        public string selectedTipusTexbox
        {
            get
            {
                return null;
            }
            set
            {
                textBoxTipus.Text = value;
            }
        }
        public string selectedVevoNev
        {
            get
            {
                return null;
            }
            set
            {
                textBoxVevoNev.Text = value;
                
            }
        }
        public string selectedVevoOrszag
        {
            get
            {
                return null;
            }
            set
            {
                textBoxVevoOrszag.Text = value;
            }
        }
        public string selectedVevoTelepules
        {
            get
            {
                return null;
            }
            set
            {
                textBoxVevoTelepules.Text = value;
            }
        }
        public List<string> vevok
        {
            get
            {
                return null;
            }
            set
            {
                comboBoxVevoNevLista.DataSource = value;
            }
        }

        public string selectedVevonevCombobox
        {
            get
            {
                return null;
            }
            set
            {
                comboBoxVevoNevLista.Text = value;
            }
        }

        public List<string> beszerzesTipusLista
        {
            get
            {
                return null;
            }
            set
            {
                comboBoxBeszerzesTipus.DataSource = value;
            }
        }

        public string selectedBeszerzesTipus
        {
            get
            {
                return null;
            }
            set
            {
                comboBoxBeszerzesTipus.Text = value;
            }
        }

        public DateTime beszerzesDatum
        {
            get
            {
                return dateTimePickerBeszerzesDatum.Value.Date;
            }
            set
            {
                dateTimePickerBeszerzesDatum.Value = value;
            }
            

        }

        public string beszrzesEKARSZAM
        {
            get
            {
                return textBoxBeszerzesEKAR.Text;
            }
            set
            {
                textBoxBeszerzesEKAR.Text = value;
            }
        }
        public string beszrzesSzamlaszam
        {
            get
            {
                return textBoxBeszerzesSzamlaszam.Text;
            }
            set
            {
                textBoxBeszerzesSzamlaszam.Text = value;
            }
        }
        public string beszrzesVAM
        {
            get
            {
                return textBoxBeszerzesVam.Text;
            }
            set
            {
                textBoxBeszerzesVam.Text = value;
            }
        }
        public string beszrzesFuvar
        {
            get
            {
                return textBoxBeszerzesFuvar.Text;
            }
            set
            {
                textBoxBeszerzesFuvar.Text = value;
            }
        }
        public string beszrzesCMR
        {
            get
            {
                return textBoxBeszerzesCMR.Text;
            }
            set
            {
                textBoxBeszerzesCMR.Text = value;
            }
        }

        public List<string> eladasTipusLista
        {
            get
            {
                return null;
            }
            set
            {
                comboBoxEladasTipus.DataSource = value;
            }

        }
        public string selectedeladasTipus
        {
            get
            {
                return comboBoxEladasTipus.Text;
            }
            set
            {
                comboBoxEladasTipus.Text = value;
            }
        }
        public DateTime eladasDatum
        {
            get
            {
                return dateTimePickerEladasDatum.Value.Date;
            }
            set
            {
                dateTimePickerEladasDatum.Value = value;
            }
        }
        public string eladasEKARSZAM
        {
            get
            {
                return textBoxEladasEKARSzam.Text;
            }
            set
            {
                textBoxEladasEKARSzam.Text = value;
            }
        }
        public string eladasSzamlaszam
        {
            get
            {
                return textBoxEladasSzamlaszam.Text;
            }
            set
            {
                textBoxEladasSzamlaszam.Text = value;
            }
        }
    }
}
