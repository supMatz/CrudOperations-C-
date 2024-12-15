namespace CRUD
{
    partial class FrmStruct
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
            this.lblProva = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAnnulla = new System.Windows.Forms.Button();
            this.btSalva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProva
            // 
            this.lblProva.AutoSize = true;
            this.lblProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProva.Location = new System.Drawing.Point(12, 9);
            this.lblProva.Name = "lblProva";
            this.lblProva.Size = new System.Drawing.Size(138, 20);
            this.lblProva.TabIndex = 0;
            this.lblProva.Text = "Inserisci / Modifica";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(69, 71);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(100, 20);
            this.tbContent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Content :";
            // 
            // btAnnulla
            // 
            this.btAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnnulla.Location = new System.Drawing.Point(301, 185);
            this.btAnnulla.Name = "btAnnulla";
            this.btAnnulla.Size = new System.Drawing.Size(82, 65);
            this.btAnnulla.TabIndex = 3;
            this.btAnnulla.Text = "Annulla";
            this.btAnnulla.UseVisualStyleBackColor = true;
            this.btAnnulla.Click += new System.EventHandler(this.btAnnulla_Click);
            // 
            // btSalva
            // 
            this.btSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalva.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSalva.Location = new System.Drawing.Point(389, 185);
            this.btSalva.Name = "btSalva";
            this.btSalva.Size = new System.Drawing.Size(82, 65);
            this.btSalva.TabIndex = 4;
            this.btSalva.Text = "Salva";
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click);
            // 
            // FrmStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 253);
            this.Controls.Add(this.btSalva);
            this.Controls.Add(this.btAnnulla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.lblProva);
            this.Name = "FrmStruct";
            this.Text = "FrmStruct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProva;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAnnulla;
        private System.Windows.Forms.Button btSalva;
    }
}