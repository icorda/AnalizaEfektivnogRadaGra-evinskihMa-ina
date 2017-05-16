namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    partial class frmPomocneMasine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPomocneMasine));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxVrstaMasine = new System.Windows.Forms.ComboBox();
            this.dgPomocnaMasina = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVekTrajanja = new System.Windows.Forms.TextBox();
            this.txtNabavnaVrednost = new System.Windows.Forms.TextBox();
            this.txtNazivMasine = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPrethodni = new System.Windows.Forms.Button();
            this.btnSledeci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPomocnaMasina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 126;
            this.label1.Text = "Vrsta mašine:";
            // 
            // cbxVrstaMasine
            // 
            this.cbxVrstaMasine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxVrstaMasine.FormattingEnabled = true;
            this.cbxVrstaMasine.Items.AddRange(new object[] {
            "Tarup za bager",
            "Tarup za traktor",
            "Kosačica za traktor"});
            this.cbxVrstaMasine.Location = new System.Drawing.Point(152, 12);
            this.cbxVrstaMasine.Name = "cbxVrstaMasine";
            this.cbxVrstaMasine.Size = new System.Drawing.Size(179, 21);
            this.cbxVrstaMasine.TabIndex = 125;
            // 
            // dgPomocnaMasina
            // 
            this.dgPomocnaMasina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPomocnaMasina.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgPomocnaMasina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPomocnaMasina.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgPomocnaMasina.Location = new System.Drawing.Point(13, 145);
            this.dgPomocnaMasina.Name = "dgPomocnaMasina";
            this.dgPomocnaMasina.Size = new System.Drawing.Size(399, 202);
            this.dgPomocnaMasina.TabIndex = 124;
            this.dgPomocnaMasina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPomocneMasine_CellClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "Vek trajanja:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 122;
            this.label3.Text = "Nabavna vrednost:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Naziv mašine:";
            // 
            // txtVekTrajanja
            // 
            this.txtVekTrajanja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVekTrajanja.Location = new System.Drawing.Point(152, 91);
            this.txtVekTrajanja.Name = "txtVekTrajanja";
            this.txtVekTrajanja.Size = new System.Drawing.Size(179, 20);
            this.txtVekTrajanja.TabIndex = 120;
            // 
            // txtNabavnaVrednost
            // 
            this.txtNabavnaVrednost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNabavnaVrednost.Location = new System.Drawing.Point(152, 65);
            this.txtNabavnaVrednost.Name = "txtNabavnaVrednost";
            this.txtNabavnaVrednost.Size = new System.Drawing.Size(179, 20);
            this.txtNabavnaVrednost.TabIndex = 119;
            // 
            // txtNazivMasine
            // 
            this.txtNazivMasine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNazivMasine.Location = new System.Drawing.Point(152, 39);
            this.txtNazivMasine.Name = "txtNazivMasine";
            this.txtNazivMasine.Size = new System.Drawing.Size(179, 20);
            this.txtNazivMasine.TabIndex = 118;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdustani.Location = new System.Drawing.Point(337, 86);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 117;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPotvrdi.Location = new System.Drawing.Point(337, 57);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 116;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnObrisi.Location = new System.Drawing.Point(337, 116);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 115;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPromeni.Location = new System.Drawing.Point(256, 116);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromeni.TabIndex = 114;
            this.btnPromeni.Text = "Promeni";
            this.btnPromeni.UseVisualStyleBackColor = true;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDodaj.Location = new System.Drawing.Point(175, 116);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 113;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPrethodni
            // 
            this.btnPrethodni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrethodni.Location = new System.Drawing.Point(13, 116);
            this.btnPrethodni.Name = "btnPrethodni";
            this.btnPrethodni.Size = new System.Drawing.Size(75, 23);
            this.btnPrethodni.TabIndex = 112;
            this.btnPrethodni.Text = "Prethodni";
            this.btnPrethodni.UseVisualStyleBackColor = true;
            this.btnPrethodni.Click += new System.EventHandler(this.btnPrethodni_Click);
            // 
            // btnSledeci
            // 
            this.btnSledeci.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSledeci.Location = new System.Drawing.Point(94, 116);
            this.btnSledeci.Name = "btnSledeci";
            this.btnSledeci.Size = new System.Drawing.Size(75, 23);
            this.btnSledeci.TabIndex = 111;
            this.btnSledeci.Text = "Sledeći";
            this.btnSledeci.UseVisualStyleBackColor = true;
            this.btnSledeci.Click += new System.EventHandler(this.btnSledeci_Click);
            // 
            // frmPomocneMasine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxVrstaMasine);
            this.Controls.Add(this.dgPomocnaMasina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVekTrajanja);
            this.Controls.Add(this.txtNabavnaVrednost);
            this.Controls.Add(this.txtNazivMasine);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnPrethodni);
            this.Controls.Add(this.btnSledeci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPomocneMasine";
            this.Text = "Pomoćne Mašine";
            ((System.ComponentModel.ISupportInitialize)(this.dgPomocnaMasina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxVrstaMasine;
        private System.Windows.Forms.DataGridView dgPomocnaMasina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVekTrajanja;
        private System.Windows.Forms.TextBox txtNabavnaVrednost;
        private System.Windows.Forms.TextBox txtNazivMasine;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPrethodni;
        private System.Windows.Forms.Button btnSledeci;
    }
}