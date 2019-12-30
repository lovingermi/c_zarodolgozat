using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzerszamgepKereskedelem.Models;
using SzerszamgepKereskedelem.Presenters;
using SzerszamgepKereskedelem.ViewInterfaces;

namespace SzerszamgepKereskedelem.Views
{
    public partial class MainWindow : Form, IMainView
    {
        private MainPresenter mainPresenter;
        private int lapokSzama;
        private int aktualisLapSzam;
        public MainWindow()
        {
            InitializeComponent();
            mainPresenter = new MainPresenter(this);
            TableColumnsAndFontSetup();
            
        }
        public DataTable dataTableFoTabla
        {
            set
            {
                dataGridViewMainTable.DataSource = value;
                emptyCells();
            }
        }

        public string query
        { 
            get
            {
                return textBoxKeres.Text;
            }
        }

        public DateTime kezdoDatum
        {
            get
            {
                return dateTimePickerTol.Value;
            }
        }
        public DateTime zaroDatum
        {
            get
            {
                return dateTimePickerIg.Value;
            }
        }
        public int lapok
        {
            set
            {
                lapokSzama = value;
                textBoxOldalszam.Text = value.ToString();
                if (lapokSzama > 0)
                {
                    numericUpDownOldalszam.Maximum = lapokSzama;
                    numericUpDownOldalszam.Minimum = 1;
                }
                else
                {
                    numericUpDownOldalszam.Maximum = 0;
                }
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TableColumnsAndFontSetup()
        {

            // dataGridViewMainTable.DefaultCellStyle.ForeColor = Color.Blue;
            //dataGridViewMainTable.DefaultCellStyle.BackColor = Color.Beige;
            //dataGridViewMainTable.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewMainTable.RowTemplate.MinimumHeight = 30;
            dataGridViewMainTable.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewMainTable.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            dataGridViewMainTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dataGridViewMainTable.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml(" #d6eaf8 ");//("#9CFABD");
            dataGridViewMainTable.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml( "#aed6f1 ");//("#DFEFE5");

            dataGridViewMainTable.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dataGridViewMainTable.EnableHeadersVisualStyles = false;
            dataGridViewMainTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dataGridViewMainTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMainTable.RowHeadersVisible = false;

            dataGridViewMainTable.Columns[0].Width = 50;
            dataGridViewMainTable.Columns[0].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewMainTable.Columns[1].Width = 100;
            dataGridViewMainTable.Columns[1].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewMainTable.Columns[2].Width = 200;
            dataGridViewMainTable.Columns[2].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            

            dataGridViewMainTable.Columns[3].Width = 100;
            dataGridViewMainTable.Columns[3].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;            


            dataGridViewMainTable.Columns[4].Width = 80;
            dataGridViewMainTable.Columns[4].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[4].DefaultCellStyle.ForeColor = Color.DarkBlue;
            dataGridViewMainTable.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewMainTable.Columns[5].Width = 100;
            dataGridViewMainTable.Columns[5].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewMainTable.Columns[6].Width = 110;
            dataGridViewMainTable.Columns[6].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewMainTable.Columns[7].Width = 50;
            dataGridViewMainTable.Columns[7].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewMainTable.Columns[8].Width = 50;
            dataGridViewMainTable.Columns[8].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewMainTable.Columns[9].Width = 50;
            dataGridViewMainTable.Columns[9].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewMainTable.Columns[10].Width = 50;
            dataGridViewMainTable.Columns[10].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewMainTable.Columns[11].Width = 80;
            dataGridViewMainTable.Columns[11].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;///
            dataGridViewMainTable.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[11].DefaultCellStyle.ForeColor = Color.DarkBlue;

            dataGridViewMainTable.Columns[12].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewMainTable.Columns[13].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewMainTable.Columns[14].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[14].Width = 110;


        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (!SystemInformation.TerminalServerSession)//táblázat görgetés gyorsabb: double buffering https://10tec.com/articles/why-datagridview-slow.aspx
            {
                Type dgvType = dataGridViewMainTable.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dataGridViewMainTable, true, null);
            }
            comboBoxKeres.Text = "Teljes lista";
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {

            int id = getSelectedMegrendelesId();
            if (id > -1)
            {
                ModifyWindow modifywindow = new ModifyWindow(getSelectedMegrendelesId());
                if (modifywindow.ShowDialog() == DialogResult.OK)
                {
                    mainPresenter.LoadData();
                }
            }
            else
            {
                errorProviderModify.SetError(buttonModify, "Nincs megrendelés kiválasztva!");
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            errorProviderModify.Clear();
            int id = getSelectedMegrendelesId();
            if (id > -1)
            {
                mainPresenter.DeleteMegrendeles(getSelectedMegrendelesId());
                dataGridViewMainTable.ClearSelection();
            }
            else
            {
                errorProviderModify.SetError(buttonDelete, "Nincs megrendelés kiválasztva!");
            }
            
        }
        private int getSelectedMegrendelesId()
        {
            errorProviderModify.Clear();
            int selectedRowIndex;
            try
            {
                selectedRowIndex = dataGridViewMainTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewMainTable.Rows[selectedRowIndex];
                int megrenelesId = Convert.ToInt32(selectedRow.Cells[0].Value);
                return megrenelesId;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }
        private void emptyCells()
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridViewMainTable.Rows)
            {
                bool o7 = Convert.ToBoolean(row.Cells[7].Value);
                bool o8 = Convert.ToBoolean(row.Cells[8].Value);
                bool o9 = Convert.ToBoolean(row.Cells[9].Value);
                bool o10 = Convert.ToBoolean(row.Cells[10].Value);
                if (!o7)
                {
                    row.Cells[7].Style.BackColor = Color.Salmon;

                }
                if (!o8)
                {
                    row.Cells[8].Style.BackColor = Color.Salmon;

                }
                if (!o9)
                {
                    row.Cells[9].Style.BackColor = Color.Salmon;
                }
                if (!o10)
                {
                    row.Cells[10].Style.BackColor = Color.Salmon;
                }
                count++;
            }
        }
        private void buttonAddProjekt_Click(object sender, EventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            if (addWindow.ShowDialog() == DialogResult.OK)
            {
                mainPresenter.LoadData();               
            }            
        }
        private void textBoxkeres_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBoxKeres.Text == "Vevő")
            {
                mainPresenter.getVevo(aktualisLapSzam);
            }
            else
            if (comboBoxKeres.Text == "Cikkszám")
            {
                mainPresenter.getCikkszam(aktualisLapSzam);
            }
            else
            if (comboBoxKeres.Text == "Gyártó")
            {
                mainPresenter.getGyarto(aktualisLapSzam);
            }
        }
        private void comboBoxKeres_SelectedValueChanged(object sender, EventArgs e)
        {

            if (textBoxKeres.Text != "")
            {
                textBoxKeres.Text = "";
                
            }
            aktualisLapSzam = 0;
            getListak();
            if (comboBoxKeres.Text == "Beszerzés dátum" || comboBoxKeres.Text == "Eladás dátum")
            {
                textBoxKeres.ReadOnly = true;
                dateTimePickerTol.Enabled = true;
                dateTimePickerIg.Enabled = true;
                buttonKeres.ForeColor = Color.Green;
                buttonKeres.Enabled = true;
                
            }
            else
            {
                textBoxKeres.ReadOnly = false;
                dateTimePickerTol.Enabled = false;
                dateTimePickerIg.Enabled = false;
                buttonKeres.ForeColor = Color.Black;
                buttonKeres.Enabled = false;
            }
        }

        private void buttonKeres_Click(object sender, EventArgs e)
        {
            if (comboBoxKeres.Text == "Beszerzés dátum")
            {
                mainPresenter.getBeszerzesDatum(aktualisLapSzam);
            }
            if (comboBoxKeres.Text == "Eladás dátum")
            {
                mainPresenter.getEladasDatum(aktualisLapSzam);
            }
        }

        private void buttonLapFel_Click(object sender, EventArgs e)
        {
            if (aktualisLapSzam < lapokSzama-1)
            {
                aktualisLapSzam++;
                numericUpDownOldalszam.Value = aktualisLapSzam+1;
                getListak();


            }
        }

        private void buttonLapLe_Click(object sender, EventArgs e)
        {
            if (aktualisLapSzam >0)
            {
                aktualisLapSzam--;
                numericUpDownOldalszam.Value = aktualisLapSzam+1;
                getListak();

            }
        }
        public void getListak()
        {
            if (comboBoxKeres.Text == "Teljes lista")
            {
                mainPresenter.getAlapLista(aktualisLapSzam);
            }
            else
                if (comboBoxKeres.Text == "Vevő")
            {
                mainPresenter.getVevo(aktualisLapSzam);
            }
            else
                if (comboBoxKeres.Text == "Cikkszám")
            {
                mainPresenter.getCikkszam(aktualisLapSzam);
            }
            else
                if (comboBoxKeres.Text == "Gyártó")
            {
                mainPresenter.getGyarto(aktualisLapSzam);
            }
            if (comboBoxKeres.Text == "Beszerzés dátum")
            {
                mainPresenter.getBeszerzesDatum(aktualisLapSzam);
            }
            else
            if (comboBoxKeres.Text == "Eladás dátum")
            {
                mainPresenter.getEladasDatum(aktualisLapSzam);
            }
        }

        private void numericUpDownOldalszam_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownOldalszam.Value > 0 && numericUpDownOldalszam.Value < lapokSzama+1)
            {
                aktualisLapSzam = Convert.ToInt32(numericUpDownOldalszam.Value)-1;
                getListak();
            }
        }
    }
}
