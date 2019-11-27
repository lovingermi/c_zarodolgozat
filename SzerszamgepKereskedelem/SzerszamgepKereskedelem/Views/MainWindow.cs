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
    public partial class MainWindow : Form, IMainView
    {
        private MainPresenter presenter;
        public MainWindow()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }

        public DataTable dataTableFoTabla
        {
            set
            {
                dataGridViewMainTable.DataSource = value;  
            }
        }
        public gepek gepek
        {
            get
            {
                return new gepek();
            }
            set
            {

            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TableColumnsAndFontSetup()
        {

            dataGridViewMainTable.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#9CFABD");
            dataGridViewMainTable.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#DFEFE5");

            dataGridViewMainTable.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
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
            //dataGridViewFoTabla.Columns[4].DefaultCellStyle.Format = "c0";
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
            TableColumnsAndFontSetup();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            ModifyWindow modifywindow = new ModifyWindow();
            if (modifywindow.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
