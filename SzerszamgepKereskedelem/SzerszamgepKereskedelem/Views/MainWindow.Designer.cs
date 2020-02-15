namespace SzerszamgepKereskedelem.Views
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAddProjekt = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonDESC = new System.Windows.Forms.RadioButton();
            this.radioButtonASC = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonKeres = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerIg = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTol = new System.Windows.Forms.DateTimePicker();
            this.textBoxKeres = new System.Windows.Forms.TextBox();
            this.comboBoxKeres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewerMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sajatAdatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UjFelhasznalo = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProviderModify = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonLapFel = new System.Windows.Forms.Button();
            this.buttonLapLe = new System.Windows.Forms.Button();
            this.numericUpDownOldalszam = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOldalszam = new System.Windows.Forms.TextBox();
            this.dataGridViewMainTable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOldalszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonModify.ForeColor = System.Drawing.Color.Black;
            this.buttonModify.Image = ((System.Drawing.Image)(resources.GetObject("buttonModify.Image")));
            this.buttonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModify.Location = new System.Drawing.Point(743, 111);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonModify.Size = new System.Drawing.Size(155, 44);
            this.buttonModify.TabIndex = 2;
            this.buttonModify.Text = "Módosítás";
            this.buttonModify.UseCompatibleTextRendering = true;
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonAddProjekt
            // 
            this.buttonAddProjekt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddProjekt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddProjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddProjekt.ForeColor = System.Drawing.Color.Black;
            this.buttonAddProjekt.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddProjekt.Image")));
            this.buttonAddProjekt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProjekt.Location = new System.Drawing.Point(743, 58);
            this.buttonAddProjekt.Name = "buttonAddProjekt";
            this.buttonAddProjekt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAddProjekt.Size = new System.Drawing.Size(155, 45);
            this.buttonAddProjekt.TabIndex = 0;
            this.buttonAddProjekt.Text = "Hozzáadás";
            this.buttonAddProjekt.UseCompatibleTextRendering = true;
            this.buttonAddProjekt.UseVisualStyleBackColor = false;
            this.buttonAddProjekt.Click += new System.EventHandler(this.buttonAddProjekt_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(743, 159);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonDelete.Size = new System.Drawing.Size(155, 44);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseCompatibleTextRendering = true;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(913, 159);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonExit.Size = new System.Drawing.Size(155, 44);
            this.buttonExit.TabIndex = 30;
            this.buttonExit.Text = "Kilépés";
            this.buttonExit.UseCompatibleTextRendering = true;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrint.ForeColor = System.Drawing.Color.Black;
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrint.Location = new System.Drawing.Point(573, 158);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPrint.Size = new System.Drawing.Size(155, 45);
            this.buttonPrint.TabIndex = 32;
            this.buttonPrint.Text = "Nyomtatás";
            this.buttonPrint.UseCompatibleTextRendering = true;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveToFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveToFile.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveToFile.Image")));
            this.buttonSaveToFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveToFile.Location = new System.Drawing.Point(573, 110);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonSaveToFile.Size = new System.Drawing.Size(155, 45);
            this.buttonSaveToFile.TabIndex = 31;
            this.buttonSaveToFile.Text = "Mentés fájlba";
            this.buttonSaveToFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveToFile.UseCompatibleTextRendering = true;
            this.buttonSaveToFile.UseVisualStyleBackColor = false;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonExport);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonSaveToFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.buttonModify);
            this.panel1.Controls.Add(this.buttonAddProjekt);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.reportViewerMain);
            this.panel1.Location = new System.Drawing.Point(255, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 220);
            this.panel1.TabIndex = 34;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExport.Image = ((System.Drawing.Image)(resources.GetObject("buttonExport.Image")));
            this.buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExport.Location = new System.Drawing.Point(573, 58);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonExport.Size = new System.Drawing.Size(155, 45);
            this.buttonExport.TabIndex = 41;
            this.buttonExport.Text = "Exportálás";
            this.buttonExport.UseCompatibleTextRendering = true;
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioButtonDESC);
            this.panel2.Controls.Add(this.radioButtonASC);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonKeres);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePickerIg);
            this.panel2.Controls.Add(this.dateTimePickerTol);
            this.panel2.Controls.Add(this.textBoxKeres);
            this.panel2.Controls.Add(this.comboBoxKeres);
            this.panel2.Location = new System.Drawing.Point(99, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 145);
            this.panel2.TabIndex = 35;
            // 
            // radioButtonDESC
            // 
            this.radioButtonDESC.AutoSize = true;
            this.radioButtonDESC.Location = new System.Drawing.Point(22, 103);
            this.radioButtonDESC.Name = "radioButtonDESC";
            this.radioButtonDESC.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDESC.TabIndex = 47;
            this.radioButtonDESC.Text = "Csökkenő";
            this.radioButtonDESC.UseVisualStyleBackColor = true;
            // 
            // radioButtonASC
            // 
            this.radioButtonASC.AutoSize = true;
            this.radioButtonASC.Checked = true;
            this.radioButtonASC.Location = new System.Drawing.Point(22, 56);
            this.radioButtonASC.Name = "radioButtonASC";
            this.radioButtonASC.Size = new System.Drawing.Size(69, 17);
            this.radioButtonASC.TabIndex = 46;
            this.radioButtonASC.TabStop = true;
            this.radioButtonASC.Text = "Növekvő";
            this.radioButtonASC.UseVisualStyleBackColor = true;
            this.radioButtonASC.CheckedChanged += new System.EventHandler(this.radioButtonASC_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(307, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Dátum szerint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(103, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Megnevezés szerint";
            // 
            // buttonKeres
            // 
            this.buttonKeres.Enabled = false;
            this.buttonKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKeres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKeres.Location = new System.Drawing.Point(301, 105);
            this.buttonKeres.Name = "buttonKeres";
            this.buttonKeres.Size = new System.Drawing.Size(100, 28);
            this.buttonKeres.TabIndex = 43;
            this.buttonKeres.Text = "Keres";
            this.buttonKeres.UseCompatibleTextRendering = true;
            this.buttonKeres.UseVisualStyleBackColor = true;
            this.buttonKeres.Click += new System.EventHandler(this.buttonKeres_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(412, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "-ig";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(408, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "-tól";
            // 
            // dateTimePickerIg
            // 
            this.dateTimePickerIg.Enabled = false;
            this.dateTimePickerIg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIg.Location = new System.Drawing.Point(301, 79);
            this.dateTimePickerIg.Name = "dateTimePickerIg";
            this.dateTimePickerIg.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerIg.TabIndex = 40;
            // 
            // dateTimePickerTol
            // 
            this.dateTimePickerTol.Enabled = false;
            this.dateTimePickerTol.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTol.Location = new System.Drawing.Point(301, 53);
            this.dateTimePickerTol.Name = "dateTimePickerTol";
            this.dateTimePickerTol.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerTol.TabIndex = 39;
            // 
            // textBoxKeres
            // 
            this.textBoxKeres.Location = new System.Drawing.Point(106, 102);
            this.textBoxKeres.Name = "textBoxKeres";
            this.textBoxKeres.Size = new System.Drawing.Size(121, 20);
            this.textBoxKeres.TabIndex = 38;
            this.textBoxKeres.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxkeres_KeyUp);
            // 
            // comboBoxKeres
            // 
            this.comboBoxKeres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeres.FormattingEnabled = true;
            this.comboBoxKeres.Items.AddRange(new object[] {
            "Teljes lista",
            "Cikkszám",
            "Gyártó",
            "Vevő",
            "Beszerzés dátum",
            "Eladás dátum"});
            this.comboBoxKeres.Location = new System.Drawing.Point(106, 53);
            this.comboBoxKeres.Name = "comboBoxKeres";
            this.comboBoxKeres.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKeres.TabIndex = 37;
            this.comboBoxKeres.SelectedValueChanged += new System.EventHandler(this.comboBoxKeres_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(283, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Keresés";
            // 
            // reportViewerMain
            // 
            this.reportViewerMain.DocumentMapWidth = 8;
            this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SzerszamgepKereskedelem.Report1.rdlc";
            this.reportViewerMain.Location = new System.Drawing.Point(988, 15);
            this.reportViewerMain.Name = "reportViewerMain";
            this.reportViewerMain.ServerReport.BearerToken = null;
            this.reportViewerMain.Size = new System.Drawing.Size(80, 37);
            this.reportViewerMain.TabIndex = 41;
            this.reportViewerMain.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kilepesToolStripMenuItem,
            this.felhasználóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilepesToolStripMenuItem.Text = "Kilépés";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // felhasználóToolStripMenuItem
            // 
            this.felhasználóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sajatAdatokToolStripMenuItem,
            this.UjFelhasznalo});
            this.felhasználóToolStripMenuItem.Name = "felhasználóToolStripMenuItem";
            this.felhasználóToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.felhasználóToolStripMenuItem.Text = "Felhasználó";
            // 
            // sajatAdatokToolStripMenuItem
            // 
            this.sajatAdatokToolStripMenuItem.Name = "sajatAdatokToolStripMenuItem";
            this.sajatAdatokToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.sajatAdatokToolStripMenuItem.Text = "Adatok megtekintése";
            this.sajatAdatokToolStripMenuItem.Click += new System.EventHandler(this.sajatAdatokToolStripMenuItem_Click);
            // 
            // UjFelhasznalo
            // 
            this.UjFelhasznalo.Name = "UjFelhasznalo";
            this.UjFelhasznalo.Size = new System.Drawing.Size(209, 22);
            this.UjFelhasznalo.Text = "Új felhasználó létrehozása";
            this.UjFelhasznalo.Click += new System.EventHandler(this.UjFelhasznalo_Click);
            // 
            // errorProviderModify
            // 
            this.errorProviderModify.ContainerControl = this;
            // 
            // buttonLapFel
            // 
            this.buttonLapFel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLapFel.Image = ((System.Drawing.Image)(resources.GetObject("buttonLapFel.Image")));
            this.buttonLapFel.Location = new System.Drawing.Point(804, 378);
            this.buttonLapFel.Name = "buttonLapFel";
            this.buttonLapFel.Size = new System.Drawing.Size(50, 40);
            this.buttonLapFel.TabIndex = 36;
            this.buttonLapFel.UseVisualStyleBackColor = true;
            this.buttonLapFel.Click += new System.EventHandler(this.buttonLapFel_Click);
            // 
            // buttonLapLe
            // 
            this.buttonLapLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLapLe.Image = ((System.Drawing.Image)(resources.GetObject("buttonLapLe.Image")));
            this.buttonLapLe.Location = new System.Drawing.Point(593, 378);
            this.buttonLapLe.Name = "buttonLapLe";
            this.buttonLapLe.Size = new System.Drawing.Size(50, 40);
            this.buttonLapLe.TabIndex = 37;
            this.buttonLapLe.UseVisualStyleBackColor = true;
            this.buttonLapLe.Click += new System.EventHandler(this.buttonLapLe_Click);
            // 
            // numericUpDownOldalszam
            // 
            this.numericUpDownOldalszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownOldalszam.Location = new System.Drawing.Point(662, 387);
            this.numericUpDownOldalszam.Name = "numericUpDownOldalszam";
            this.numericUpDownOldalszam.Size = new System.Drawing.Size(48, 26);
            this.numericUpDownOldalszam.TabIndex = 38;
            this.numericUpDownOldalszam.ValueChanged += new System.EventHandler(this.numericUpDownOldalszam_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(716, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 26);
            this.label6.TabIndex = 39;
            this.label6.Text = "/";
            // 
            // textBoxOldalszam
            // 
            this.textBoxOldalszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOldalszam.Location = new System.Drawing.Point(741, 388);
            this.textBoxOldalszam.Name = "textBoxOldalszam";
            this.textBoxOldalszam.ReadOnly = true;
            this.textBoxOldalszam.Size = new System.Drawing.Size(48, 26);
            this.textBoxOldalszam.TabIndex = 40;
            this.textBoxOldalszam.Text = " ";
            // 
            // dataGridViewMainTable
            // 
            this.dataGridViewMainTable.AllowUserToAddRows = false;
            this.dataGridViewMainTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewMainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainTable.Location = new System.Drawing.Point(12, 31);
            this.dataGridViewMainTable.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMainTable.MultiSelect = false;
            this.dataGridViewMainTable.Name = "dataGridViewMainTable";
            this.dataGridViewMainTable.ReadOnly = true;
            this.dataGridViewMainTable.RowTemplate.Height = 24;
            this.dataGridViewMainTable.Size = new System.Drawing.Size(1333, 334);
            this.dataGridViewMainTable.TabIndex = 1;
            this.dataGridViewMainTable.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewMainTable_RowPostPaint);
            this.dataGridViewMainTable.Sorted += new System.EventHandler(this.dataGridViewMainTable_Sorted);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1364, 879);
            this.Controls.Add(this.textBoxOldalszam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownOldalszam);
            this.Controls.Add(this.buttonLapLe);
            this.Controls.Add(this.buttonLapFel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewMainTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szerszámgépek";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOldalszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAddProjekt;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxKeres;
        private System.Windows.Forms.ComboBox comboBoxKeres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProviderModify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerIg;
        private System.Windows.Forms.DateTimePicker dateTimePickerTol;
        private System.Windows.Forms.Button buttonKeres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOldalszam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownOldalszam;
        private System.Windows.Forms.Button buttonLapLe;
        private System.Windows.Forms.Button buttonLapFel;
        private System.Windows.Forms.DataGridView dataGridViewMainTable;
        private System.Windows.Forms.RadioButton radioButtonDESC;
        private System.Windows.Forms.RadioButton radioButtonASC;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMain;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.ToolStripMenuItem felhasználóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sajatAdatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UjFelhasznalo;
    }
}