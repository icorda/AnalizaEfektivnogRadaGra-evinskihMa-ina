using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    public partial class frmPosaoPocetna : Form
    {
        public frmPosaoPocetna()
        {
            InitializeComponent();

            List<VrstaPoslaZaPosao> radnikList = new List<VrstaPoslaZaPosao>();
        }

        private void btnNapred_Click(object sender, EventArgs e)
        {
            string vrstaPosla;
            string vrstaMasine;
            bool imaPomMas;
            bool valja = false;

            if (cbxPosao.Text == "Cena po satu		(Bager)")
            {
                vrstaPosla = "Cena po satu";
                vrstaMasine = "Bager";
                imaPomMas = false;
                valja = true;
            }
            else if (cbxPosao.Text == "Iskop do 2m3/m		(Bager)")
            {
                vrstaPosla = "Iskop do 2m3/m";
                vrstaMasine = "Bager";
                imaPomMas = false;
                valja = true;
            }
            else if (cbxPosao.Text == "Iskop preko 2m3/m		(Bager)")
            {
                vrstaPosla = "Iskop preko 2m3/m";
                vrstaMasine = "Bager";
                imaPomMas = false;
                valja = true;
            }
            else if (cbxPosao.Text == "Terupamne 5-10cm		(Bager)")
            {
                vrstaPosla = "Terupamne 5-10cm";
                vrstaMasine = "Bager";
                imaPomMas = true;
                valja = true;
            }
            else if (cbxPosao.Text == "Terupanje preko 10cm	(Bager)")
            {
                vrstaPosla = "Terupanje preko 10cm";
                vrstaMasine = "Bager";
                imaPomMas = true;
                valja = true;
            }
            else if (cbxPosao.Text == "Terupanje trske		(Bager)")
            {
                vrstaPosla = "Terupanje trske";
                vrstaMasine = "Bager";
                imaPomMas = true;
                valja = true;
            }
            else if (cbxPosao.Text == "Iskop izmuljenje		(Bager)")
            {
                vrstaPosla = "Iskop izmuljenje";
                vrstaMasine = "Bager";
                imaPomMas = false;
                valja = true;
            }
            else if (cbxPosao.Text == "Cena po satu		(Dozer)")
            {
                vrstaPosla = "Cena po satu";
                vrstaMasine = "Dozer";
                imaPomMas = false;
                valja = true;
            }
            else if (cbxPosao.Text == "Iskop sa trans. do 30m	(Dozer)")
            {
                vrstaPosla = "Iskop sa trans. do 30m";
                vrstaMasine = "Dozer";
                imaPomMas = false;
                valja = true;
            }
            else if (cbxPosao.Text == "Iskop sa trans. 30-50m	(Dozer)")
            {
                vrstaPosla = "Iskop sa trans. 30-50m";
                vrstaMasine = "Dozer";
                imaPomMas = false;
                valja = true;
            }
            else if (cbxPosao.Text == "Planiranje deponije		(Dozer)")
            {
                vrstaPosla = "Planiranje deponije";
                vrstaMasine = "Dozer";
                imaPomMas = false;
                valja = true;
            }
            else if (cbxPosao.Text == "Planiranje inspekcijske staze	(Dozer)")
            {
                vrstaPosla = "Planiranje inspekcijske staze";
                vrstaMasine = "Dozer";
                imaPomMas = false;
                valja = true;
            }
            else if (cbxPosao.Text == "Čišćenje terena		(Dozer)")
            {
                vrstaPosla = "Čišćenje terena";
                vrstaMasine = "Dozer";
                imaPomMas = false;
                valja = true;
            }
            else if (cbxPosao.Text == "Cena po satu		(Traktor)")
            {
                vrstaPosla = "Cena po satu";
                vrstaMasine = "Traktor";
                imaPomMas = false;
                valja = true;
            }
            else if (cbxPosao.Text == "Košenje			(Traktor)")
            {
                vrstaPosla = "Košenje";
                vrstaMasine = "Traktor";
                imaPomMas = true;
                valja = true;
            }
            else if (cbxPosao.Text == "Terupanje 5-10cm		(Traktor)")
            {
                vrstaPosla = "Terupanje 5-10cm";
                vrstaMasine = "Traktor";
                imaPomMas = true;
                valja = true;
            }
            else if (cbxPosao.Text == "Terupanje preko 10cm	(Traktor)")
            {
                vrstaPosla = "Terupanje preko 10cm";
                vrstaMasine = "Traktor";
                imaPomMas = true;
                valja = true;
            }
            else if (cbxPosao.Text == "Cena po satu		(Kamion)")
            {
                vrstaPosla = "Cena po satu";
                vrstaMasine = "Kamion";
                imaPomMas = false;
                valja = true;
            }
            else
            {
                vrstaPosla = "";
                vrstaMasine = "";
                imaPomMas = false;
                valja = false;
            }

            if (valja == true)
            {
                if (imaPomMas == false)
                {
                    using (DatotekaDBEntities ctx = new DatotekaDBEntities())
                    {
                        bool imaPraznaPomMas = (from p in ctx.PomocnaMasinas
                                                where p.NazivMasine == "NEMA"
                                                select p).Any();

                        if (imaPraznaPomMas == false)
                        {
                            Kalendar kal = (from k in ctx.Kalendars
                                            select k).FirstOrDefault();

                            PomocnaMasina pom = new PomocnaMasina();
                            {
                                pom.ID_Kalendar = kal.ID_Kalendar;

                                pom.NazivMasine = "NEMA";
                                pom.VrstaMasine = "NEMA";
                                pom.NabavnaVrednost = 0;
                                pom.VekTrajanja = 0;
                                pom.GodisnjiFondEfCasRad = 0;
                                pom.Amortizacija = 0;
                                pom.InvesticionoOdrzavanje = 0;
                                pom.TekuceOdrzavanje = 0;
                                pom.Osiguranje = 0;
                                pom.Mazivo = 1;

                                pom.dodajMasinu();
                            }
                        }
                    }
                }

                VrstaPoslaZaPosao vp = new VrstaPoslaZaPosao();
                vp.VrstaPosla = vrstaPosla;
                vp.VrstaMasine = vrstaMasine;
                vp.ImaPomMas = imaPomMas;

                vp.dodajVrstuPosla();

                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).pokreniPosaoZavrsna(vp);
                }
            }

            else
            {
                lblStatus.Text = "Niste odabrali posao!";
            }
        }
    }
}
