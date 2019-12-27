﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzerszamgepKereskedelem.Models;
using SzerszamgepKereskedelem.Presenters;
using SzerszamgepKereskedelem.ViewInterfaces;

namespace SzerszamgepKereskedelem.Views
{
    public partial class AddWindow : Form, IAddView
    {
        private AddPresenter addPresenter;
        public AddWindow()
        {
            InitializeComponent();
            addPresenter = new AddPresenter(this);
            addPresenter.addMegrendeles();
        }

        public string gepCikkszam
        {
            get
            {
                // error provider
                return textBoxGepCikkszam.Text;
            }
        }

        public string gepMegnevezes
        {
            get
            {
                return textBoxGepMegnevezes.Text;
            }
        }

        public List<string> gyartok
        {
            set
            {
                comboBoxGyarto.DataSource = value;
            }
        }

        public List<string> tipusok
        {
            set
            {
                comboBoxTipus.DataSource = value;
            }
        }

        public string gepTipus
        {
            get
            {
                return textBoxTipus.Text;
            }
        }
        public string gepGyatro
        {
            get
            {
                return textBoxGyarto.Text;
            }
        }

        public List<string> vevok
        {
            set
            {
                comboBoxVevoNevLista.DataSource = value;
            }
        }

        public string vevoNev
        {
            set
            {
                textBoxVevoNev.Text = value;
            }
        }
        public string vevoOrszag
        {
            set
            {
                textBoxVevoOrszag.Text = value;
            }
        }
        public string vevoTelepules
        {
            set
            {
                textBoxVevoTelepules.Text = value;
            }
        }

        public string bTipus
        {
            get
            {
                return comboBoxBeszerzesTipus.Text;
            }
        }

        public DateTime bDatum
        {
            get
            {
                if (textBoxBeszerzesDatum.Text != "")
                {
                    return Convert.ToDateTime(textBoxBeszerzesDatum.Text);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
        }

        public string bEKAR
        {
            get
            {
                return textBoxBeszerzesEKAR.Text;
            }
        }

        public string bSzamla
        {
            get
            {
                return textBoxBeszerzesSzamlaszam.Text;
            }
        }

        public string bVAM
        {
            get
            {
                return textBoxBeszerzesVam.Text;
            }
        }

        public string bFuvar
        {
            get
            {
                return textBoxBeszerzesFuvar.Text;
            }
        }
        public string bCMR
        {
            get
            {
                return textBoxBeszerzesCMR.Text;
            }
        }
        public DateTime eDatum
        {
            get
            {
                if (textBoxEladasDatum.Text != "")
                {
                    return Convert.ToDateTime(textBoxEladasDatum.Text);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
        }
        public string eTipus
        {
            get
            {
                return comboBoxEladasTipus.Text;
            }
        }

        public string eEKAR
        {
            get
            {
                return textBoxEladasEKARSzam.Text;
            }
        }

        public string eSzamla
        {
            get
            {
                return textBoxEladasSzamlaszam.Text;
            }
        }

        public List<string> bTipusLista
        {
            set
            {
                comboBoxBeszerzesTipus.DataSource = value;
            }
        }

        public List<string> eTipusLista
        {
            set
            {
                comboBoxEladasTipus.DataSource = value;
            }
        }

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            addPresenter.saveMegrendeles();
            DialogResult = DialogResult.OK;
        }
        private void comboBoxVevoNevLista_SelectedValueChanged(object sender, EventArgs e)
        {
            string vevoNev = comboBoxVevoNevLista.Text;
            addPresenter.GetVevoFromNevLista(vevoNev);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dateTimePickerBeszerzesDatum_CloseUp(object sender, EventArgs e)
        {
            textBoxBeszerzesDatum.Text = dateTimePickerBeszerzesDatum.Value.ToShortDateString();
        }

        private void dateTimePickerEladasDatum_CloseUp(object sender, EventArgs e)
        {
            textBoxEladasDatum.Text = dateTimePickerEladasDatum.Value.ToShortDateString();
        }

        private void comboBoxGyarto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxGyarto.SelectedIndex != 0)//-------Kérem válasszon-------
            {
                textBoxGyarto.Text = comboBoxGyarto.Text;
            }
            else
            {
                textBoxGyarto.Text = "";
            }

        }

        private void comboBoxTipus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxTipus.SelectedIndex != 0)//-------Kérem válasszon-------
            {
                textBoxTipus.Text = comboBoxTipus.Text;
            }
            else
            {
                textBoxTipus.Text = "";
            }
        }
    }
}
