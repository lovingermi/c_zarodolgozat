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
    }
}
