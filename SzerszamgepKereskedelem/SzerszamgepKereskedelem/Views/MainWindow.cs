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
        public MainWindow()
        {
            InitializeComponent();
            mainPresenter = new MainPresenter(this);
        }

        public DataTable dataTableFoTabla
        {
            set
            {
                dataGridViewMainTable.DataSource = value;
 
            }
        }
        /*public gepek gepek
        {
            get
            {
                return new gepek();
            }
            set
            {

            }
        }

        public megrendeles megrendeles
        {
            get
            {
                return megrendeles ;
            }
            set
            {

            }
        }
        public beszerzesek beszerzesek { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public eladasok eladasok { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }*/


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TableColumnsAndFontSetup()
        {

           // dataGridViewMainTable.DefaultCellStyle.ForeColor = Color.Blue;
            //dataGridViewMainTable.DefaultCellStyle.BackColor = Color.Beige;
            dataGridViewMainTable.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewMainTable.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            dataGridViewMainTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dataGridViewMainTable.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml(" #d6eaf8 ");//("#9CFABD");
            dataGridViewMainTable.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml( "#aed6f1 ");//("#DFEFE5");

            dataGridViewMainTable.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dataGridViewMainTable.EnableHeadersVisualStyles = false;
            dataGridViewMainTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewMainTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            dataGridViewMainTable.Columns[4].DefaultCellStyle.ForeColor = Color.Blue;
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
            dataGridViewMainTable.Columns[11].DefaultCellStyle.ForeColor = Color.Blue;

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
            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)//táblázat görgetés gyorsabb: double buffering https://10tec.com/articles/why-datagridview-slow.aspx
            {
                Type dgvType = dataGridViewMainTable.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dataGridViewMainTable, true, null);
            }
            TableColumnsAndFontSetup();
            emptyCells();

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
    }
}
