﻿using System;
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
        private VevoPresenter vevoPresenter;
        private bool vevoAdd;
        private bool vevoModify;
        public ModifyWindow(string cikkszam)
        {
            InitializeComponent();
            modifyPresenter = new ModifyPresenter(this);
            vevoPresenter = new VevoPresenter(this);
            modifyPresenter.ModifyMegrendeles(cikkszam);
        }
        public string gepCikkszam
        {
            get
            {
                return textBoxGepCikkszam.Text;
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
                return textBoxGepMegnevezes.Text;
            }
            set
            {
                textBoxGepMegnevezes.Text = value;
            }
        }

        public List<string> gyartok
        {
            set
            {
                comboBoxGyarto.DataSource = value;
            }
        }
        public string selectedGyartoTexbox
        {
            get
            {
                return textBoxGyarto.Text;
            }
            set
            {
                textBoxGyarto.Text = value;
            }
        }
        public string selectedGyarto
        {
            set
            {
                comboBoxGyarto.Text = value;
            }
        }

        public List<string> tipusok
        {
            set
            {
                comboBoxTipus.DataSource = value;
            }
        }
        public string selectedTipus
        {
            set
            {
                comboBoxTipus.Text = value;
            }
        }
        public string selectedTipusTexbox
        {
            get
            {
                return textBoxTipus.Text;
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
                return textBoxVevoNev.Text;
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
                return textBoxVevoOrszag.Text;
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
                return textBoxVevoTelepules.Text;
            }
            set
            {
                textBoxVevoTelepules.Text = value;
            }
        }
        public List<string> vevok
        {
            set
            {
                comboBoxVevoNevLista.DataSource = value;
            }
        }

        public string selectedVevonevCombobox
        {
            set
            {
                comboBoxVevoNevLista.Text = value;
            }
        }

        public List<string> beszerzesTipusLista
        {
            set
            {
                comboBoxBeszerzesTipus.DataSource = value;
            }
        }

        public string selectedBeszerzesTipus
        {
            get
            {
                return comboBoxBeszerzesTipus.Text;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    comboBoxBeszerzesTipus.Text ="";
                }
                else
                {
                    comboBoxBeszerzesTipus.Text = value;
                }
            }
        }

        public DateTime beszerzesDatum
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
            set
            {
                if (value == DateTime.MinValue)
                {
                    dateTimePickerBeszerzesDatum.Value = DateTime.Now;
                    textBoxBeszerzesDatum.Text = "";
                }
                else
                {
                    dateTimePickerBeszerzesDatum.Value = value;
                }

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
            set
            {
                comboBoxEladasTipus.DataSource = value;
            }

        }
        public string selectedEladasTipus
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
                if (textBoxEladasDatum.Text != "")
                {
                    return Convert.ToDateTime(textBoxEladasDatum.Text);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                if (value == DateTime.MinValue)
                {
                    dateTimePickerEladasDatum.Value = DateTime.Now;
                    textBoxEladasDatum.Text = "";
                }
                else
                {
                    dateTimePickerEladasDatum.Value = value;
                }

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

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            errorProviderCikkszam.Clear();
            try
            {
                modifyPresenter.saveModify();
                DialogResult = DialogResult.OK;
            }
            catch(ModifyPresenterException mpe)
            {
                errorProviderCikkszam.SetError(textBoxGepCikkszam, mpe.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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

        private void comboBoxVevoNevLista_SelectedValueChanged(object sender, EventArgs e)
        {
            string vevoNev = comboBoxVevoNevLista.Text;
            modifyPresenter.GetVevoFromNevLista(vevoNev);
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
        private void dateTimePickerBeszerzesDatum_ValueChanged(object sender, EventArgs e)
        {
              
             textBoxBeszerzesDatum.Text = dateTimePickerBeszerzesDatum.Value.ToShortDateString();   
        }

        private void dateTimePickerEladasDatum_ValueChanged(object sender, EventArgs e)
        {
             textBoxEladasDatum.Text = dateTimePickerEladasDatum.Value.ToShortDateString();
        }
        private void buttonVevoCancel_Click(object sender, EventArgs e)
        {
            errorProviderVevoModify.Clear();
            errorProviderVevoAdd.Clear();
            textBoxVevoNev.ReadOnly = true;
            textBoxVevoOrszag.ReadOnly = true;
            textBoxVevoTelepules.ReadOnly = true;
            vevoModify = false;
            vevoAdd = false;
        }

        private void buttonVevoAdd_Click(object sender, EventArgs e)
        {
            vevoAdd = true;
            vevoModify = false;
            textBoxVevoNev.ReadOnly = false;
            textBoxVevoOrszag.ReadOnly = false;
            textBoxVevoTelepules.ReadOnly = false;
            textBoxVevoNev.Text = "";
            textBoxVevoOrszag.Text = "";
            textBoxVevoTelepules.Text = "";
            comboBoxVevoNevLista.SelectedIndex = 0;
        }

        private void buttonVevoModify_Click(object sender, EventArgs e)
        {
            errorProviderVevoModify.Clear();
            vevoAdd = false;
            if (comboBoxVevoNevLista.SelectedIndex != 0)
            {
                vevoModify = true;
                textBoxVevoNev.ReadOnly = false;
                textBoxVevoOrszag.ReadOnly = false;
                textBoxVevoTelepules.ReadOnly = false;
                vevoPresenter.selectVevoToModify(textBoxVevoNev.Text);//A jelenlegi név alapján a vevő presenter megkeresi és eltárolja a vevő Id-t
            }
            else
            {
                errorProviderVevoModify.SetError(comboBoxVevoNevLista, "Nincs kiválasztva vevő!");
            }
        }

        private void buttonVevoDelete_Click(object sender, EventArgs e)
        {
            errorProviderVevoModify.Clear();
            if (comboBoxVevoNevLista.SelectedIndex != 0)
            {
                DialogResult myResult;
                myResult = MessageBox.Show("Biztos törli a kiválasztott vevőt?" + "\n" + textBoxVevoNev.Text, "Törlés megerősítés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    try
                    {
                        vevoPresenter.DeleteVevo_2(textBoxVevoNev.Text);
                        comboBoxVevoNevLista.SelectedIndex = 0;
                    }
                    catch (VevoPresenterException vpe)
                    {
                        errorProviderVevoModify.SetError(buttonVevoDelete, vpe.Message);
                    }
                }
            }
            else
            {
                errorProviderVevoModify.SetError(comboBoxVevoNevLista, "Nincs kiválasztva vevő!");
            }
        }

        private void buttonVevoSave_Click(object sender, EventArgs e)
        {
            errorProviderVevoModify.Clear();
            errorProviderVevoAdd.Clear();
            if (vevoAdd)
            {
                try
                {
                    vevoPresenter.AddVevo_2();
                    vevoAdd = false;
                    textBoxVevoNev.ReadOnly = true;
                    textBoxVevoOrszag.ReadOnly = true;
                    textBoxVevoTelepules.ReadOnly = true;
                }
                catch (VevoPresenterException vpe)
                {
                    errorProviderVevoAdd.SetError(textBoxVevoNev, vpe.Message);
                }
            }
            if (vevoModify)
            {
                vevoPresenter.modifyVevo_2();
                vevoModify = false;
                textBoxVevoNev.ReadOnly = true;
                textBoxVevoOrszag.ReadOnly = true;
                textBoxVevoTelepules.ReadOnly = true;
            }
        }
    }
}
