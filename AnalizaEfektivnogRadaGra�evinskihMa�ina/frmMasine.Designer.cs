namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    partial class frmMasine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasine));
            this.dgMasina = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPrethodni = new System.Windows.Forms.Button();
            this.btnSledeci = new System.Windows.Forms.Button();
            this.txtNazivMasine = new System.Windows.Forms.TextBox();
            this.txtNabavnaVrednost = new System.Windows.Forms.TextBox();
            this.txtVekTrajanja = new System.Windows.Forms.TextBox();
            this.txtSnagaMotoraKW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxVrstaMasine = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasina)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMasina
            // 
            this.dgMasina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMasina.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgMasina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMasina.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgMasina.Location = new System.Drawing.Point(12, 172);
            this.dgMasina.Name = "dgMasina";
            this.dgMasina.Size = new System.Drawing.Size(399, 175);
            this.dgMasina.TabIndex = 104;
            this.dgMasina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBageri_CellClick);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Snaga motora KW:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Vek trajanja:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Nabavna vrednost:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Naziv mašine:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdustani.Location = new System.Drawing.Point(336, 113);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 95;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPotvrdi.Location = new System.Drawing.Point(336, 84);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 94;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnObrisi.Location = new System.Drawing.Point(336, 143);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 93;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPromeni.Location = new System.Drawing.Point(255, 143);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromeni.TabIndex = 92;
            this.btnPromeni.Text = "Promeni";
            this.btnPromeni.UseVisualStyleBackColor = true;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDodaj.Location = new System.Drawing.Point(174, 143);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 91;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPrethodni
            // 
            this.btnPrethodni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrethodni.Location = new System.Drawing.Point(12, 143);
            this.btnPrethodni.Name = "btnPrethodni";
            this.btnPrethodni.Size = new System.Drawing.Size(75, 23);
            this.btnPrethodni.TabIndex = 90;
            this.btnPrethodni.Text = "Prethodni";
            this.btnPrethodni.UseVisualStyleBackColor = true;
            this.btnPrethodni.Click += new System.EventHandler(this.btnPrethodni_Click);
            // 
            // btnSledeci
            // 
            this.btnSledeci.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSledeci.Location = new System.Drawing.Point(93, 143);
            this.btnSledeci.Name = "btnSledeci";
            this.btnSledeci.Size = new System.Drawing.Size(75, 23);
            this.btnSledeci.TabIndex = 89;
            this.btnSledeci.Text = "Sledeći";
            this.btnSledeci.UseVisualStyleBackColor = true;
            this.btnSledeci.Click += new System.EventHandler(this.btnSledeci_Click);
            // 
            // txtNazivMasine
            // 
            this.txtNazivMasine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNazivMasine.Location = new System.Drawing.Point(151, 39);
            this.txtNazivMasine.Name = "txtNazivMasine";
            this.txtNazivMasine.Size = new System.Drawing.Size(179, 20);
            this.txtNazivMasine.TabIndex = 96;
            // 
            // txtNabavnaVrednost
            // 
            this.txtNabavnaVrednost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNabavnaVrednost.Location = new System.Drawing.Point(151, 65);
            this.txtNabavnaVrednost.Name = "txtNabavnaVrednost";
            this.txtNabavnaVrednost.Size = new System.Drawing.Size(179, 20);
            this.txtNabavnaVrednost.TabIndex = 97;
            // 
            // txtVekTrajanja
            // 
            this.txtVekTrajanja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVekTrajanja.Location = new System.Drawing.Point(151, 91);
            this.txtVekTrajanja.Name = "txtVekTrajanja";
            this.txtVekTrajanja.Size = new System.Drawing.Size(179, 20);
            this.txtVekTrajanja.TabIndex = 98;
            // 
            // txtSnagaMotoraKW
            // 
            this.txtSnagaMotoraKW.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSnagaMotoraKW.Location = new System.Drawing.Point(151, 117);
            this.txtSnagaMotoraKW.Name = "txtSnagaMotoraKW";
            this.txtSnagaMotoraKW.Size = new System.Drawing.Size(179, 20);
            this.txtSnagaMotoraKW.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Vrsta mašine:";
            // 
            // cbxVrstaMasine
            // 
            this.cbxVrstaMasine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxVrstaMasine.FormattingEnabled = true;
            this.cbxVrstaMasine.Items.AddRange(new object[] {
            "Bager",
            "Dozer",
            "Traktor",
            "Kamion"});
            this.cbxVrstaMasine.Location = new System.Drawing.Point(151, 12);
            this.cbxVrstaMasine.Name = "cbxVrstaMasine";
            this.cbxVrstaMasine.Size = new System.Drawing.Size(179, 21);
            this.cbxVrstaMasine.TabIndex = 106;
            // 
            // frmMasine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 359);
            this.Controls.Add(this.cbxVrstaMasine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMasina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSnagaMotoraKW);
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
            this.Name = "frmMasine";
            this.Text = "Mašine";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.dgMasina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMasina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPrethodni;
        private System.Windows.Forms.Button btnSledeci;
        private System.Windows.Forms.TextBox txtNazivMasine;
        private System.Windows.Forms.TextBox txtNabavnaVrednost;
        private System.Windows.Forms.TextBox txtVekTrajanja;
        private System.Windows.Forms.TextBox txtSnagaMotoraKW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxVrstaMasine;
    }
}