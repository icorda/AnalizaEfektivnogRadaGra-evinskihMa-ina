namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUnosKalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUnosMasina = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUnosPomocnaMasina = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUnosPosao = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPregledKalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPregledPoslovi = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPocetna = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.pregledToolStripMenuItem,
            this.mniPocetna});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniUnosKalendar,
            this.mniUnosMasina,
            this.mniUnosPomocnaMasina,
            this.mniUnosPosao});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // mniUnosKalendar
            // 
            this.mniUnosKalendar.Name = "mniUnosKalendar";
            this.mniUnosKalendar.Size = new System.Drawing.Size(166, 22);
            this.mniUnosKalendar.Text = "Kalendar";
            this.mniUnosKalendar.Click += new System.EventHandler(this.mniUnosKalendar_Click);
            // 
            // mniUnosMasina
            // 
            this.mniUnosMasina.Name = "mniUnosMasina";
            this.mniUnosMasina.Size = new System.Drawing.Size(166, 22);
            this.mniUnosMasina.Text = "Mašina";
            this.mniUnosMasina.Click += new System.EventHandler(this.mniUnosMasina_Click);
            // 
            // mniUnosPomocnaMasina
            // 
            this.mniUnosPomocnaMasina.Name = "mniUnosPomocnaMasina";
            this.mniUnosPomocnaMasina.Size = new System.Drawing.Size(166, 22);
            this.mniUnosPomocnaMasina.Text = "Pomoćna Mašina";
            this.mniUnosPomocnaMasina.Click += new System.EventHandler(this.mniUnosPomocnaMasina_Click);
            // 
            // mniUnosPosao
            // 
            this.mniUnosPosao.Name = "mniUnosPosao";
            this.mniUnosPosao.Size = new System.Drawing.Size(166, 22);
            this.mniUnosPosao.Text = "Posao";
            this.mniUnosPosao.Click += new System.EventHandler(this.mniUnosPosao_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPregledKalendar,
            this.mniPregledPoslovi});
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.pregledToolStripMenuItem.Text = "Pregled";
            // 
            // mniPregledKalendar
            // 
            this.mniPregledKalendar.Name = "mniPregledKalendar";
            this.mniPregledKalendar.Size = new System.Drawing.Size(120, 22);
            this.mniPregledKalendar.Text = "Kalendar";
            this.mniPregledKalendar.Click += new System.EventHandler(this.mniPregledKalendar_Click);
            // 
            // mniPregledPoslovi
            // 
            this.mniPregledPoslovi.Name = "mniPregledPoslovi";
            this.mniPregledPoslovi.Size = new System.Drawing.Size(120, 22);
            this.mniPregledPoslovi.Text = "Poslovi";
            this.mniPregledPoslovi.Click += new System.EventHandler(this.mniPregledPoslovi_Click);
            // 
            // mniPocetna
            // 
            this.mniPocetna.Name = "mniPocetna";
            this.mniPocetna.Size = new System.Drawing.Size(62, 20);
            this.mniPocetna.Text = "Početna";
            this.mniPocetna.Click += new System.EventHandler(this.mniPocetna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(651, 468);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Analiza efektivnog rada građevinskih mašina";
            this.TransparencyKey = System.Drawing.Color.White;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniUnosKalendar;
        private System.Windows.Forms.ToolStripMenuItem mniUnosMasina;
        private System.Windows.Forms.ToolStripMenuItem mniUnosPomocnaMasina;
        private System.Windows.Forms.ToolStripMenuItem mniUnosPosao;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniPregledKalendar;
        private System.Windows.Forms.ToolStripMenuItem mniPregledPoslovi;
        private System.Windows.Forms.ToolStripMenuItem mniPocetna;
    }
}

