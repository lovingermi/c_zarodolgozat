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
            this.dataGridViewMainTable = new System.Windows.Forms.DataGridView();
            this.groupBoxMűveletek = new System.Windows.Forms.GroupBox();
            this.buttonListaTorles = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAddProjekt = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainTable)).BeginInit();
            this.groupBoxMűveletek.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMainTable
            // 
            this.dataGridViewMainTable.AllowUserToAddRows = false;
            this.dataGridViewMainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainTable.Location = new System.Drawing.Point(11, 40);
            this.dataGridViewMainTable.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMainTable.Name = "dataGridViewMainTable";
            this.dataGridViewMainTable.ReadOnly = true;
            this.dataGridViewMainTable.RowTemplate.Height = 24;
            this.dataGridViewMainTable.Size = new System.Drawing.Size(1378, 273);
            this.dataGridViewMainTable.TabIndex = 1;
            // 
            // groupBoxMűveletek
            // 
            this.groupBoxMűveletek.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxMűveletek.Controls.Add(this.buttonListaTorles);
            this.groupBoxMűveletek.Controls.Add(this.buttonModify);
            this.groupBoxMűveletek.Controls.Add(this.buttonAddProjekt);
            this.groupBoxMűveletek.Controls.Add(this.buttonDelete);
            this.groupBoxMűveletek.Location = new System.Drawing.Point(12, 381);
            this.groupBoxMűveletek.Name = "groupBoxMűveletek";
            this.groupBoxMűveletek.Size = new System.Drawing.Size(251, 168);
            this.groupBoxMűveletek.TabIndex = 29;
            this.groupBoxMűveletek.TabStop = false;
            this.groupBoxMűveletek.Text = "Műveletek";
            // 
            // buttonListaTorles
            // 
            this.buttonListaTorles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonListaTorles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonListaTorles.Location = new System.Drawing.Point(28, 130);
            this.buttonListaTorles.Name = "buttonListaTorles";
            this.buttonListaTorles.Size = new System.Drawing.Size(197, 30);
            this.buttonListaTorles.TabIndex = 3;
            this.buttonListaTorles.Text = "Lista törlés";
            this.buttonListaTorles.UseVisualStyleBackColor = false;
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonModify.Location = new System.Drawing.Point(28, 55);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(197, 30);
            this.buttonModify.TabIndex = 2;
            this.buttonModify.Text = "Módosítás";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonAddProjekt
            // 
            this.buttonAddProjekt.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAddProjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddProjekt.Location = new System.Drawing.Point(28, 19);
            this.buttonAddProjekt.Name = "buttonAddProjekt";
            this.buttonAddProjekt.Size = new System.Drawing.Size(197, 30);
            this.buttonAddProjekt.TabIndex = 0;
            this.buttonAddProjekt.Text = "Hozzáadás";
            this.buttonAddProjekt.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(28, 93);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(197, 30);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1200, 519);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(197, 30);
            this.buttonExit.TabIndex = 30;
            this.buttonExit.Text = "Kilépés";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 561);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxMűveletek);
            this.Controls.Add(this.dataGridViewMainTable);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainTable)).EndInit();
            this.groupBoxMűveletek.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMainTable;
        private System.Windows.Forms.GroupBox groupBoxMűveletek;
        private System.Windows.Forms.Button buttonListaTorles;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAddProjekt;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
    }
}