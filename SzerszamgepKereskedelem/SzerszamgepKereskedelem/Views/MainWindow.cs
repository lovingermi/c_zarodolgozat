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
                dataGridViewMainTable.ClearSelection();
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
            dataGridViewMainTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMainTable.RowTemplate.MinimumHeight = 30;
            dataGridViewMainTable.DefaultCellStyle.SelectionForeColor = Color.Black;  
            dataGridViewMainTable.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#e5e7e9");// ColorTranslator.FromHtml(" #1e7bd1");//#4c6cf3


            dataGridViewMainTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

            dataGridViewMainTable.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml(" #d6eaf8 ");//("#9CFABD");
            dataGridViewMainTable.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml( "#aed6f1 ");//("#DFEFE5");

            dataGridViewMainTable.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dataGridViewMainTable.EnableHeadersVisualStyles = false;
            dataGridViewMainTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
            dataGridViewMainTable.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[7].DefaultCellStyle.Font= new Font("Segoe UI", 14, FontStyle.Bold );

            dataGridViewMainTable.Columns[8].Width = 50;
            dataGridViewMainTable.Columns[8].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[8].DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            dataGridViewMainTable.Columns[9].Width = 50;
            dataGridViewMainTable.Columns[9].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[9].DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            dataGridViewMainTable.Columns[10].Width = 50;
            dataGridViewMainTable.Columns[10].HeaderCell.Style.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewMainTable.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMainTable.Columns[10].DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);

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

            string cikkszam = getSelectedMegrendelesCikkszam();
            if (cikkszam!=string.Empty)
            {
                ModifyWindow modifywindow = new ModifyWindow(getSelectedMegrendelesCikkszam());
                if (modifywindow.ShowDialog() == DialogResult.OK)
                {
                    mainPresenter.LoadData();
                    getListak();
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
            string cikkszam = getSelectedMegrendelesCikkszam();
            if (cikkszam != string.Empty)
            {
                DialogResult myResult;//Törlés megerősítés
                myResult = MessageBox.Show("Biztos törli a kijelölt megrendelést?" + "\n"+"Cikszám: "+cikkszam , "Törlés megerősítés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    mainPresenter.DeleteMegrendeles(getSelectedMegrendelesCikkszam());
                }
                else
                {
                    //No delete
                }

            }
            else
            {
                errorProviderModify.SetError(buttonDelete, "Nincs megrendelés kiválasztva!");
            }
            
        }
        private string getSelectedMegrendelesCikkszam()
        {
            errorProviderModify.Clear();
            int selectedRowIndex;
            try
            {
                selectedRowIndex = dataGridViewMainTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewMainTable.Rows[selectedRowIndex];
                string megrenelesCikkszam =(selectedRow.Cells[1].Value).ToString();
                return megrenelesCikkszam;
            }
            catch (Exception)
            {
                return string.Empty;
            }
            
        }
 
        private void emptyCells()
        {
            
            foreach (DataGridViewRow row in dataGridViewMainTable.Rows)
            {

                string o7 = Convert.ToString(row.Cells[7].Value);
                string o8 = Convert.ToString(row.Cells[8].Value);
                string o9 = Convert.ToString(row.Cells[9].Value);
                string o10 = Convert.ToString(row.Cells[10].Value);
                if (o7 == "\u2713")
                {
                    row.Cells[7].Style.ForeColor = Color.Green;
                    row.Cells[7].Style.SelectionForeColor=Color.Green;
                }
                else
                {
                    row.Cells[7].Style.ForeColor = Color.Red;
                    row.Cells[7].Style.SelectionForeColor = Color.Red;
                }
                if (o8 == "\u2713")
                {
                    row.Cells[8].Style.ForeColor = Color.Green;
                    row.Cells[8].Style.SelectionForeColor = Color.Green;
                }
                else
                {
                    row.Cells[8].Style.ForeColor = Color.Red;
                    row.Cells[8].Style.SelectionForeColor = Color.Red;
                }
                if (o9 == "\u2713")
                {
                    row.Cells[9].Style.ForeColor = Color.Green;
                    row.Cells[9].Style.SelectionForeColor = Color.Green;
                }
                else
                {
                    row.Cells[9].Style.ForeColor = Color.Red;
                    row.Cells[9].Style.SelectionForeColor = Color.Red;
                }
                if (o10 == "\u2713")
                {
                    row.Cells[10].Style.ForeColor = Color.Green;
                    row.Cells[10].Style.SelectionForeColor = Color.Green;
                }
                else
                {
                    row.Cells[10].Style.ForeColor = Color.Red;
                    row.Cells[10].Style.SelectionForeColor = Color.Red;
                }
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

        private void dataGridViewMainTable_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dataGridViewMainTable.Rows[e.RowIndex].Selected)
            {
                using (Pen pen = new Pen(Color.Red))
                {
                    int penWidth = 2;

                    pen.Width = penWidth;

                    int x = e.RowBounds.Left + (penWidth / 2);
                    int y = e.RowBounds.Top + (penWidth / 2);
                    int width = e.RowBounds.Width - penWidth;
                    int height = e.RowBounds.Height - penWidth;

                    e.Graphics.DrawRectangle(pen, x, y, width, height);
                }
            }
        }

        private void dataGridViewMainTable_Sorted(object sender, EventArgs e)
        {
            emptyCells();
        }
    }
}
