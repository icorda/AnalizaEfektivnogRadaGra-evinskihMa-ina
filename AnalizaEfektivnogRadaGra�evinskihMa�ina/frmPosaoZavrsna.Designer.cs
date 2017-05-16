namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    partial class frmPosaoZavrsna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosaoZavrsna));
            this.dgPosao = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNorma = new System.Windows.Forms.TextBox();
            this.cbxRadnik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPomMas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.cbxMasina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrethodni = new System.Windows.Forms.Button();
            this.btnSledeci = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPosao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPosao
            // 
            this.dgPosao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPosao.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgPosao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPosao.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgPosao.Location = new System.Drawing.Point(12, 148);
            this.dgPosao.Name = "dgPosao";
            this.dgPosao.Size = new System.Drawing.Size(539, 217);
            this.dgPosao.TabIndex = 59;
            this.dgPosao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPosao_CellClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Norma:";
            // 
            // txtNorma
            // 
            this.txtNorma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNorma.Location = new System.Drawing.Point(164, 93);
            this.txtNorma.Name = "txtNorma";
            this.txtNorma.Size = new System.Drawing.Size(387, 20);
            this.txtNorma.TabIndex = 57;
            // 
            // cbxRadnik
            // 
            this.cbxRadnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxRadnik.FormattingEnabled = true;
            this.cbxRadnik.Items.AddRange(new object[] {
            "Jedan radnik",
            "Dva radnika"});
            this.cbxRadnik.Location = new System.Drawing.Point(164, 39);
            this.cbxRadnik.Name = "cbxRadnik";
            this.cbxRadnik.Size = new System.Drawing.Size(387, 21);
            this.cbxRadnik.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Izaberi broj radnika:";
            // 
            // cbxPomMas
            // 
            this.cbxPomMas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxPomMas.FormattingEnabled = true;
            this.cbxPomMas.Location = new System.Drawing.Point(164, 66);
            this.cbxPomMas.Name = "cbxPomMas";
            this.cbxPomMas.Size = new System.Drawing.Size(387, 21);
            this.cbxPomMas.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Izaberi pomoćnu mašinu:";
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIzracunaj.Location = new System.Drawing.Point(482, 119);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(69, 23);
            this.btnIzracunaj.TabIndex = 52;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNazad.Location = new System.Drawing.Point(164, 119);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(69, 23);
            this.btnNazad.TabIndex = 51;
            this.btnNazad.Text = "<";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // cbxMasina
            // 
            this.cbxMasina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxMasina.FormattingEnabled = true;
            this.cbxMasina.Location = new System.Drawing.Point(164, 12);
            this.cbxMasina.Name = "cbxMasina";
            this.cbxMasina.Size = new System.Drawing.Size(387, 21);
            this.cbxMasina.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Izaberi mašinu:";
            // 
            // btnPrethodni
            // 
            this.btnPrethodni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrethodni.Location = new System.Drawing.Point(239, 119);
            this.btnPrethodni.Name = "btnPrethodni";
            this.btnPrethodni.Size = new System.Drawing.Size(75, 23);
            this.btnPrethodni.TabIndex = 92;
            this.btnPrethodni.Text = "Prethodni";
            this.btnPrethodni.UseVisualStyleBackColor = true;
            this.btnPrethodni.Click += new System.EventHandler(this.btnPrethodni_Click);
            // 
            // btnSledeci
            // 
            this.btnSledeci.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSledeci.Location = new System.Drawing.Point(320, 119);
            this.btnSledeci.Name = "btnSledeci";
            this.btnSledeci.Size = new System.Drawing.Size(75, 23);
            this.btnSledeci.TabIndex = 91;
            this.btnSledeci.Text = "Sledeći";
            this.btnSledeci.UseVisualStyleBackColor = true;
            this.btnSledeci.Click += new System.EventHandler(this.btnSledeci_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnObrisi.Location = new System.Drawing.Point(401, 119);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 94;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmPosaoZavrsna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(567, 377);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPrethodni);
            this.Controls.Add(this.btnSledeci);
            this.Controls.Add(this.dgPosao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNorma);
            this.Controls.Add(this.cbxRadnik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPomMas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.cbxMasina);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPosaoZavrsna";
            this.Text = "Posao";
            ((System.ComponentModel.ISupportInitialize)(this.dgPosao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPosao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNorma;
        private System.Windows.Forms.ComboBox cbxRadnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPomMas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.ComboBox cbxMasina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrethodni;
        private System.Windows.Forms.Button btnSledeci;
        private System.Windows.Forms.Button btnObrisi;
    }
}