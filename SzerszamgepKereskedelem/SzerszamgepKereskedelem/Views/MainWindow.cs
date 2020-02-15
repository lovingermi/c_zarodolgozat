using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzerszamgepKereskedelem.Presenters;
using SzerszamgepKereskedelem.ViewInterfaces;


namespace SzerszamgepKereskedelem.Views
{
    public partial class MainWindow : Form, IMainView, IReportView
    {
        private ReportParameter[] allPar = new ReportParameter[18];
        private ReportPresenter reportPresenter;
        private MainPresenter mainPresenter;
        private int lapokSzama;
        private int aktualisLapSzam;
        private bool ASC = true;//rendezéshez
        private bool felhasznaloJogosultsag;
        private int userId;
        public MainWindow(string felhasznaloNev, bool fJogosultsag, int uId)//Sikeres bejelentkezésnél a felhasználónév paraméterként megérkezik
        {
            InitializeComponent();
            mainPresenter = new MainPresenter(this);
            reportPresenter = new ReportPresenter(this);
            TableColumnsAndFontSetup();
            this.Text += String.Format("{0,200}", felhasznaloNev);
            felhasznaloJogosultsag = fJogosultsag;//bejelentkezés alapján felhasználó jogosultság meghatározva
            userId = uId;
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
            // this.reportViewerMain.RefreshReport();
            if (felhasznaloJogosultsag)
            {
                buttonAddProjekt.Enabled = true;
                buttonDelete.Enabled = true;
                buttonModify.Enabled = true;
            }
            else
            {
                buttonAddProjekt.Enabled = false;
                buttonDelete.Enabled = false;
                buttonModify.Enabled = false;
            }
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            int selectedRowIndex;
            string cikkszam = getSelectedMegrendelesCikkszam();
            if (cikkszam!=string.Empty)
            {
                selectedRowIndex = dataGridViewMainTable.SelectedCells[0].RowIndex;
                ModifyWindow modifywindow = new ModifyWindow(getSelectedMegrendelesCikkszam());
                if (modifywindow.ShowDialog() == DialogResult.OK)
                {
                    getListak();//mainPresenter.LoadData();
                    dataGridViewMainTable.Rows[selectedRowIndex].Selected = true;
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
                comboBoxKeres.SelectedIndex = 0;
                getListak();//frissüljön a tábla
                               
                if (ASC)
                {
                    aktualisLapSzam = lapokSzama - 1;
                    numericUpDownOldalszam.Value = aktualisLapSzam + 1;
                    int lastRowIndex = dataGridViewMainTable.Rows.Count - 1;
                    dataGridViewMainTable.Rows[lastRowIndex].Selected = true;
                }
                else
                {
                    aktualisLapSzam = 0;
                    numericUpDownOldalszam.Value = aktualisLapSzam + 1;
                    dataGridViewMainTable.Rows[0].Selected = true;
                }
                
            }
            else
            {
                getListak();//Ha csak a vevő adatok lettek módosítva akkor is frissüljön a tábla
            }
        }
        private void textBoxkeres_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBoxKeres.Text == "Vevő")
            {
                mainPresenter.getVevo(aktualisLapSzam, ASC);
            }
            else
            if (comboBoxKeres.Text == "Cikkszám")
            {
                mainPresenter.getCikkszam(aktualisLapSzam, ASC);
            }
            else
            if (comboBoxKeres.Text == "Gyártó")
            {
                mainPresenter.getGyarto(aktualisLapSzam, ASC);
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
                mainPresenter.getBeszerzesDatum(aktualisLapSzam, ASC);
            }
            if (comboBoxKeres.Text == "Eladás dátum")
            {
                mainPresenter.getEladasDatum(aktualisLapSzam, ASC);
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
                mainPresenter.getAlapLista(aktualisLapSzam,ASC);
            }
            else
                if (comboBoxKeres.Text == "Vevő")
            {
                mainPresenter.getVevo(aktualisLapSzam,ASC);
            }
            else
                if (comboBoxKeres.Text == "Cikkszám")
            {
                mainPresenter.getCikkszam(aktualisLapSzam,ASC);
            }
            else
                if (comboBoxKeres.Text == "Gyártó")
            {
                mainPresenter.getGyarto(aktualisLapSzam,ASC);
            }
            if (comboBoxKeres.Text == "Beszerzés dátum")
            {
                mainPresenter.getBeszerzesDatum(aktualisLapSzam,ASC);
            }
            else
            if (comboBoxKeres.Text == "Eladás dátum")
            {
                mainPresenter.getEladasDatum(aktualisLapSzam,ASC);
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

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            errorProviderModify.Clear();
            string cikkszam = getSelectedMegrendelesCikkszam();
            if (cikkszam != string.Empty)
            {
                ReportWindow reportWindow = new ReportWindow(getSelectedMegrendelesCikkszam());
                reportWindow.Show();
            }
            else
            {
                errorProviderModify.SetError(buttonPrint, "Nincs megrendelés kiválasztva!");
            }
        }

        private void radioButtonASC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonASC.Checked)
            {
                ASC = true;
            }
            else
            {
                ASC = false;
            }
            getListak();
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            errorProviderModify.Clear();
            string cikkszam = getSelectedMegrendelesCikkszam();//Kiválasztott megrendelés cikkszáma
            
            if (cikkszam != string.Empty)
            {
                
                reportPresenter.getSelectedMegrendeles(cikkszam);//Report1.rdlc paraméterek feltöltése a kiválasztott megrendelés adataival
                SaveFileDialog svg = new SaveFileDialog();
                svg.Title = "Állomány mentése PDF formátumban";
                svg.Filter = "PDF(*.pdf) | *.pdf|Word Doc (*.docx)|*.docx";
                if (svg.ShowDialog() == DialogResult.OK)
                {
                    if (svg.FileName != "")
                    {
                        Warning[] warnings;
                        string[] streamids;
                        string mimeType;
                        string encoding;
                        string filenameExtension;
                        switch (svg.FilterIndex)
                        {
                            case 1:
                            {
                                    
                                    byte[] bytes = reportViewerMain.LocalReport.Render(
                                        "PDF", null, out mimeType, out encoding, out filenameExtension,
                                        out streamids, out warnings);
                                    using (FileStream stream = new FileStream(svg.FileName + ".pdf", FileMode.Create))
                                    {
                                        stream.Write(bytes, 0, bytes.Length);
                                    }
                                    break;
                            }
                            case 2:
                            {
                                    byte[] bytes = reportViewerMain.LocalReport.Render(
                                        "WORD", null, out mimeType, out encoding, out filenameExtension,
                                        out streamids, out warnings);
                                    using (FileStream stream = new FileStream(svg.FileName + ".doc", FileMode.Create))
                                    {
                                        stream.Write(bytes, 0, bytes.Length);
                                    }
                                    break;
                            }

                        }

                    }
                }
            }
            else
            {
                errorProviderModify.SetError(buttonSaveToFile, "Nincs megrendelés kiválasztva!");
            }
        }
        #region Riport paraméterek fájlba mentéshez
        public string gepCikkszam
        {
            set
            {
                string cikkszam = value;
                // create parameters array
                ReportParameter parCikkszam = new ReportParameter("cikkszam", cikkszam);
                allPar[0] = parCikkszam; //assign parameters to parameter array
            }
        }
        
        public string gepMegnevezes
        {
            set
            {
                string megnevezes = value;
                ReportParameter parMegnevezes = new ReportParameter("megnevezes", megnevezes);
                allPar[1] = parMegnevezes;
            }
        }

        public string gepGyarto
        {
            set
            {
                string gyarto = value;
                ReportParameter parGyarto = new ReportParameter("gyarto", gyarto);
                allPar[2] = parGyarto;
            }
        }
        public string gepTipus
        {
            set
            {
                string tipus = value;
                ReportParameter parTipus = new ReportParameter("tipus", tipus);
                allPar[3] = parTipus;
            }
        }

        public string beszDatum
        {
            set
            {
                string bDatum = value;
                ReportParameter parTipus = new ReportParameter("beszDatum", bDatum);
                allPar[4] = parTipus;
            }

        }

        public string beszEKAR
        {
            set
            {
                string bEKAR = value;
                ReportParameter parTipus = new ReportParameter("beszEKAR", bEKAR);
                allPar[5] = parTipus;
            }
        }

        public string beszTipus
        {
            set
            {
                string bTipus = value;
                ReportParameter parTipus = new ReportParameter("beszTipus", bTipus);
                allPar[6] = parTipus;
            }
        }

        public string beszSzamla
        {
            set
            {
                string bSzamla = value;
                ReportParameter parTipus = new ReportParameter("beszSzamla", bSzamla);
                allPar[7] = parTipus;
            }
        }

        public string VAMHatarozat
        {
            set
            {
                string VAMHAT = value;
                ReportParameter parTipus = new ReportParameter("beszVAM", VAMHAT);
                allPar[8] = parTipus;

            }
        }

        public string beszFuvar
        {
            set
            {
                string fuvar = value;
                ReportParameter parTipus = new ReportParameter("beszFuvar", fuvar);
                allPar[9] = parTipus;
            }
        }
        public string beszCMR
        {
            set
            {
                string bCMR = value;
                ReportParameter parTipus = new ReportParameter("beszCMR", bCMR);
                allPar[10] = parTipus;
            }

        }

        public string vevoNev
        {
            set
            {
                string vNev = value;
                ReportParameter parTipus = new ReportParameter("vevoNev", vNev);
                allPar[11] = parTipus;
            }
        }
        public string vevoOrszag
        {
            set
            {
                string vOrszag = value;
                ReportParameter parTipus = new ReportParameter("vevoOrszag", vOrszag);
                allPar[12] = parTipus;
            }
        }
        public string vevoTelepules
        {
            set
            {
                string vTelepules = value;
                ReportParameter parTipus = new ReportParameter("vevoTelepules", vTelepules);
                allPar[13] = parTipus;

            }

        }

        public string eladasDatum
        {
            set
            {
                string eDatum = value;
                ReportParameter parTipus = new ReportParameter("eladasDatum", eDatum);
                allPar[14] = parTipus;
            }
        }
        public string eladasTipus
        {
            set
            {
                string eTipus = value;
                ReportParameter parTipus = new ReportParameter("eladasTipus", eTipus);
                allPar[15] = parTipus;
            }
        }
        public string eladasEKAR
        {
            set
            {
                string eEKAR = value;
                ReportParameter parTipus = new ReportParameter("eladasEKAR", eEKAR);
                allPar[16] = parTipus;
            }
        }
        public string eladasSzamla
        {
            set
            {
                string eSzamla = value;
                ReportParameter parTipus = new ReportParameter("eladasSzamla", eSzamla);
                allPar[17] = parTipus;
                reportViewerMain.LocalReport.SetParameters(allPar);
                reportViewerMain.RefreshReport();
            }
        }
        #endregion

        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogCSV = new SaveFileDialog();
            saveFileDialogCSV.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            saveFileDialogCSV.Title = "Állomány mentése CSV formátumban";
            if (saveFileDialogCSV.ShowDialog() == DialogResult.OK)
            {
                List<string> megrendelesLista = mainPresenter.exportCSV();
                using (StreamWriter sr = new StreamWriter(File.Create(saveFileDialogCSV.FileName + ".csv"), Encoding.UTF8))
                {
                    foreach (var item in megrendelesLista)
                    {
                        sr.WriteLine(item);
                    }
                    sr.Close();
                }
            }
        }

        private void sajatAdatokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserWindow userWindow = new UserWindow(userId);
            if (userWindow.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}

