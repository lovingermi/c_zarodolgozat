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
            this.dataGridViewMainTable = new System.Windows.Forms.DataGridView();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAddProjekt = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProviderModify = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonLapFel = new System.Windows.Forms.Button();
            this.buttonLapLe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModify)).BeginInit();
            this.SuspendLayout();
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
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonModify.ForeColor = System.Drawing.Color.Black;
            this.buttonModify.Image = ((System.Drawing.Image)(resources.GetObject("buttonModify.Image")));
            this.buttonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModify.Location = new System.Drawing.Point(22, 101);
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
            this.buttonAddProjekt.Location = new System.Drawing.Point(22, 48);
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
            this.buttonDelete.Location = new System.Drawing.Point(22, 151);
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
            this.buttonExit.Location = new System.Drawing.Point(1195, 579);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonExit.Size = new System.Drawing.Size(168, 44);
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
            this.buttonPrint.Location = new System.Drawing.Point(193, 150);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPrint.Size = new System.Drawing.Size(155, 45);
            this.buttonPrint.TabIndex = 32;
            this.buttonPrint.Text = "Nyomtatás";
            this.buttonPrint.UseCompatibleTextRendering = true;
            this.buttonPrint.UseVisualStyleBackColor = false;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveToFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveToFile.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveToFile.Image")));
            this.buttonSaveToFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveToFile.Location = new System.Drawing.Point(193, 100);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonSaveToFile.Size = new System.Drawing.Size(155, 45);
            this.buttonSaveToFile.TabIndex = 31;
            this.buttonSaveToFile.Text = "Mentés fájlba";
            this.buttonSaveToFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveToFile.UseCompatibleTextRendering = true;
            this.buttonSaveToFile.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonSaveToFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.buttonModify);
            this.panel1.Controls.Add(this.buttonAddProjekt);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Location = new System.Drawing.Point(12, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 220);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonKeres);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePickerIg);
            this.panel2.Controls.Add(this.dateTimePickerTol);
            this.panel2.Controls.Add(this.textBoxKeres);
            this.panel2.Controls.Add(this.comboBoxKeres);
            this.panel2.Location = new System.Drawing.Point(415, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 151);
            this.panel2.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(228, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Dátum szerint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(29, 78);
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
            this.buttonKeres.Location = new System.Drawing.Point(222, 98);
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
            this.label3.Location = new System.Drawing.Point(333, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "-ig";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(329, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "-tól";
            // 
            // dateTimePickerIg
            // 
            this.dateTimePickerIg.Enabled = false;
            this.dateTimePickerIg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIg.Location = new System.Drawing.Point(222, 72);
            this.dateTimePickerIg.Name = "dateTimePickerIg";
            this.dateTimePickerIg.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerIg.TabIndex = 40;
            // 
            // dateTimePickerTol
            // 
            this.dateTimePickerTol.Enabled = false;
            this.dateTimePickerTol.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTol.Location = new System.Drawing.Point(222, 46);
            this.dateTimePickerTol.Name = "dateTimePickerTol";
            this.dateTimePickerTol.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerTol.TabIndex = 39;
            // 
            // textBoxKeres
            // 
            this.textBoxKeres.Location = new System.Drawing.Point(27, 95);
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
            this.comboBoxKeres.Location = new System.Drawing.Point(27, 46);
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
            this.label1.Location = new System.Drawing.Point(578, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Keresés";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1375, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // errorProviderModify
            // 
            this.errorProviderModify.ContainerControl = this;
            // 
            // buttonLapFel
            // 
            this.buttonLapFel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLapFel.Image = ((System.Drawing.Image)(resources.GetObject("buttonLapFel.Image")));
            this.buttonLapFel.Location = new System.Drawing.Point(653, 383);
            this.buttonLapFel.Name = "buttonLapFel";
            this.buttonLapFel.Size = new System.Drawing.Size(60, 45);
            this.buttonLapFel.TabIndex = 36;
            this.buttonLapFel.UseVisualStyleBackColor = true;
            this.buttonLapFel.Click += new System.EventHandler(this.buttonLapFel_Click);
            // 
            // buttonLapLe
            // 
            this.buttonLapLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLapLe.Image = ((System.Drawing.Image)(resources.GetObject("buttonLapLe.Image")));
            this.buttonLapLe.Location = new System.Drawing.Point(565, 383);
            this.buttonLapLe.Name = "buttonLapLe";
            this.buttonLapLe.Size = new System.Drawing.Size(60, 45);
            this.buttonLapLe.TabIndex = 37;
            this.buttonLapLe.UseVisualStyleBackColor = true;
            this.buttonLapLe.Click += new System.EventHandler(this.buttonLapLe_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1375, 663);
            this.Controls.Add(this.buttonLapLe);
            this.Controls.Add(this.buttonLapFel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewMainTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMainTable;
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
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProviderModify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerIg;
        private System.Windows.Forms.DateTimePicker dateTimePickerTol;
        private System.Windows.Forms.Button buttonKeres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLapFel;
        private System.Windows.Forms.Button buttonLapLe;
    }
}