namespace CRUD
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbParolaDaCercare = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btRicerca = new System.Windows.Forms.Button();
            this.lblFiltri = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btElimina = new System.Windows.Forms.Button();
            this.btModifica = new System.Windows.Forms.Button();
            this.LvStruct = new System.Windows.Forms.ListView();
            this.chNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btInserisci = new System.Windows.Forms.Button();
            this.btSalvaSuFile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbParolaDaCercare);
            this.panel1.Controls.Add(this.lblFiltro);
            this.panel1.Controls.Add(this.btRicerca);
            this.panel1.Controls.Add(this.lblFiltri);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 124);
            this.panel1.TabIndex = 0;
            // 
            // tbParolaDaCercare
            // 
            this.tbParolaDaCercare.Location = new System.Drawing.Point(65, 44);
            this.tbParolaDaCercare.Name = "tbParolaDaCercare";
            this.tbParolaDaCercare.Size = new System.Drawing.Size(100, 20);
            this.tbParolaDaCercare.TabIndex = 6;
            this.tbParolaDaCercare.TextChanged += new System.EventHandler(this.tbParolaDaCercare_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(8, 48);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(50, 13);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Content :";
            // 
            // btRicerca
            // 
            this.btRicerca.Location = new System.Drawing.Point(183, 43);
            this.btRicerca.Name = "btRicerca";
            this.btRicerca.Size = new System.Drawing.Size(75, 23);
            this.btRicerca.TabIndex = 4;
            this.btRicerca.Text = "Ricerca";
            this.btRicerca.UseVisualStyleBackColor = true;
            this.btRicerca.Click += new System.EventHandler(this.btRicerca_Click);
            // 
            // lblFiltri
            // 
            this.lblFiltri.AutoSize = true;
            this.lblFiltri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltri.Location = new System.Drawing.Point(4, 4);
            this.lblFiltri.Name = "lblFiltri";
            this.lblFiltri.Size = new System.Drawing.Size(117, 20);
            this.lblFiltri.TabIndex = 0;
            this.lblFiltri.Text = "Filtri di ricerca  :";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btElimina);
            this.pnlButtons.Controls.Add(this.btModifica);
            this.pnlButtons.Location = new System.Drawing.Point(706, 215);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(83, 60);
            this.pnlButtons.TabIndex = 1;
            // 
            // btElimina
            // 
            this.btElimina.Location = new System.Drawing.Point(3, 32);
            this.btElimina.Name = "btElimina";
            this.btElimina.Size = new System.Drawing.Size(75, 23);
            this.btElimina.TabIndex = 3;
            this.btElimina.Text = "Elimina";
            this.btElimina.UseVisualStyleBackColor = true;
            this.btElimina.Click += new System.EventHandler(this.btElimina_Click);
            // 
            // btModifica
            // 
            this.btModifica.Location = new System.Drawing.Point(3, 3);
            this.btModifica.Name = "btModifica";
            this.btModifica.Size = new System.Drawing.Size(75, 23);
            this.btModifica.TabIndex = 2;
            this.btModifica.Text = "Modifica";
            this.btModifica.UseVisualStyleBackColor = true;
            this.btModifica.Click += new System.EventHandler(this.btModifica_Click);
            // 
            // LvStruct
            // 
            this.LvStruct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNum,
            this.chContent});
            this.LvStruct.FullRowSelect = true;
            this.LvStruct.HideSelection = false;
            this.LvStruct.Location = new System.Drawing.Point(22, 181);
            this.LvStruct.Name = "LvStruct";
            this.LvStruct.Size = new System.Drawing.Size(677, 239);
            this.LvStruct.TabIndex = 0;
            this.LvStruct.UseCompatibleStateImageBehavior = false;
            this.LvStruct.View = System.Windows.Forms.View.Details;
            this.LvStruct.SelectedIndexChanged += new System.EventHandler(this.LvStruct_SelectedIndexChanged);
            // 
            // chNum
            // 
            this.chNum.Text = "N*";
            // 
            // chContent
            // 
            this.chContent.Text = "Content";
            // 
            // btInserisci
            // 
            this.btInserisci.Location = new System.Drawing.Point(709, 186);
            this.btInserisci.Name = "btInserisci";
            this.btInserisci.Size = new System.Drawing.Size(75, 23);
            this.btInserisci.TabIndex = 1;
            this.btInserisci.Text = "Inserisci";
            this.btInserisci.UseVisualStyleBackColor = true;
            this.btInserisci.Click += new System.EventHandler(this.btInserisci_Click);
            // 
            // btSalvaSuFile
            // 
            this.btSalvaSuFile.Location = new System.Drawing.Point(709, 281);
            this.btSalvaSuFile.Name = "btSalvaSuFile";
            this.btSalvaSuFile.Size = new System.Drawing.Size(75, 23);
            this.btSalvaSuFile.TabIndex = 2;
            this.btSalvaSuFile.Text = "Salva su File";
            this.btSalvaSuFile.UseVisualStyleBackColor = true;
            this.btSalvaSuFile.Click += new System.EventHandler(this.btSalvaFile_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalvaSuFile);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btInserisci);
            this.Controls.Add(this.LvStruct);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.ListView LvStruct;
        private System.Windows.Forms.Button btRicerca;
        private System.Windows.Forms.Label lblFiltri;
        private System.Windows.Forms.Button btElimina;
        private System.Windows.Forms.Button btModifica;
        private System.Windows.Forms.Button btInserisci;
        private System.Windows.Forms.ColumnHeader chNum;
        private System.Windows.Forms.ColumnHeader chContent;
        private System.Windows.Forms.TextBox tbParolaDaCercare;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btSalvaSuFile;
    }
}

