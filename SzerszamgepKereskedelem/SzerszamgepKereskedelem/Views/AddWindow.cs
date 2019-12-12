using System;
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
        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            //addPresenter.addMegrendeles();
            DialogResult = DialogResult.OK;
        }

       
    }
}
