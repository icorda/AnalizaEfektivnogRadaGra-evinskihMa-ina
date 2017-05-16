namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    partial class frmPosaoPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosaoPocetna));
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNapred = new System.Windows.Forms.Button();
            this.cbxPosao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(279, 65);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 24;
            // 
            // btnNapred
            // 
            this.btnNapred.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNapred.Location = new System.Drawing.Point(282, 39);
            this.btnNapred.Name = "btnNapred";
            this.btnNapred.Size = new System.Drawing.Size(69, 23);
            this.btnNapred.TabIndex = 23;
            this.btnNapred.Text = ">";
            this.btnNapred.UseVisualStyleBackColor = true;
            this.btnNapred.Click += new System.EventHandler(this.btnNapred_Click);
            // 
            // cbxPosao
            // 
            this.cbxPosao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxPosao.FormattingEnabled = true;
            this.cbxPosao.Items.AddRange(new object[] {
            "Cena po satu\t\t(Bager)",
            "Iskop do 2m3/m\t\t(Bager)",
            "Iskop preko 2m3/m\t\t(Bager)",
            "Terupamne 5-10cm\t\t(Bager)",
            "Terupanje preko 10cm\t(Bager)",
            "Terupanje trske\t\t(Bager)",
            "Iskop izmuljenje\t\t(Bager)",
            "Cena po satu\t\t(Dozer)",
            "Iskop sa trans. do 30m\t(Dozer)",
            "Iskop sa trans. 30-50m\t(Dozer)",
            "Planiranje deponije\t\t(Dozer)",
            "Planiranje inspekcijske staze\t(Dozer)",
            "Čišćenje terena\t\t(Dozer)",
            "Cena po satu\t\t(Traktor)",
            "Košenje\t\t\t(Traktor)",
            "Terupanje 5-10cm\t\t(Traktor)",
            "Terupanje preko 10cm\t(Traktor)",
            "Cena po satu\t\t(Kamion)"});
            this.cbxPosao.Location = new System.Drawing.Point(107, 12);
            this.cbxPosao.Name = "cbxPosao";
            this.cbxPosao.Size = new System.Drawing.Size(421, 21);
            this.cbxPosao.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Izaberite posao:";
            // 
            // frmPosaoPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 92);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNapred);
            this.Controls.Add(this.cbxPosao);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPosaoPocetna";
            this.Text = "Posao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNapred;
        private System.Windows.Forms.ComboBox cbxPosao;
        private System.Windows.Forms.Label label1;
    }
}