using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using System.Data.Objects;

namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    public partial class frmPosaoZavrsna : Form
    {
        List<Posao> posloviList = Posao.ucitajPoslove();

        int idVrstePosla;
        string vrstaPosla;
        string vrstaMasine;
        string nazivMasine;
        bool imaPomMas;

        public frmPosaoZavrsna()
        {
            InitializeComponent();
        }

        public frmPosaoZavrsna(VrstaPoslaZaPosao vpp)
        {
            InitializeComponent();

            dgPosao.AllowUserToAddRows = false;
            dgPosao.AllowUserToDeleteRows = false;
            dgPosao.ReadOnly = true;
            dgPosao.AutoGenerateColumns = false;

            dgPosao.Columns.Add("vrstaPosla", "Vrsta posla");
            dgPosao.Columns["vrstaPosla"].DataPropertyName = "VrstaPosla";
            dgPosao.Columns.Add("vrstaMasine", "Vrsta mašine");
            dgPosao.Columns["vrstaMasine"].DataPropertyName = "VrstaMasine";
            dgPosao.Columns.Add("nazivMasine", "Naziv Mašine");
            dgPosao.Columns["nazivMasine"].DataPropertyName = "NazivMasine";
            dgPosao.Columns.Add("radnici", "Radnici");
            dgPosao.Columns["radnici"].DataPropertyName = "Radnici";
            dgPosao.Columns.Add("plataRukovaoca", "Plata rukovaoca-bruto");
            dgPosao.Columns["plataRukovaoca"].DataPropertyName = "PlataRukovaoca";
            dgPosao.Columns.Add("svega", "Svega");
            dgPosao.Columns["svega"].DataPropertyName = "Svega";
            dgPosao.Columns.Add("rezijskiTroskovi", "Režijski troskovi");
            dgPosao.Columns["rezijskiTroskovi"].DataPropertyName = "RezijskiTroskovi";
            dgPosao.Columns.Add("cenaPoCasuRadaBezPDVa", "Cena po času rada bez PDV-a");
            dgPosao.Columns["cenaPoCasuRadaBezPDVa"].DataPropertyName = "CenaPoCasuRadaBezPDVa";
            dgPosao.Columns.Add("cenaPoCasuRadaSaPDVom", "Cena po času rada sa PDV-om");
            dgPosao.Columns["cenaPoCasuRadaSaPDVom"].DataPropertyName = "CenaPoCasuRadaSaPDVom";

            dgPosao.Columns.Add("norma", "Norma");//
            dgPosao.Columns["norma"].DataPropertyName = "Norma";//
            dgPosao.Columns.Add("cenaPoNormiBezPDVa", "Cena po normi bez PDV-a");//
            dgPosao.Columns["cenaPoNormiBezPDVa"].DataPropertyName = "CenaPoNormiBezPDVa";//
            dgPosao.Columns.Add("cenaPoNormiSaPDVom", "Cena po normi sa PDV-om");//
            dgPosao.Columns["cenaPoNormiSaPDVom"].DataPropertyName = "CenaPoNormiSaPDVom";//

            dgPosao.Columns.Add("vrstaPomMas", "Vrsta pomoćne mašine");//
            dgPosao.Columns["vrstaPomMas"].DataPropertyName = "VrstaPomMas";//
            dgPosao.Columns.Add("nazivPomMas", "Naziv pomoćne mašine");//
            dgPosao.Columns["nazivPomMas"].DataPropertyName = "NazivPomMas";//

            prikaziPosloveDGV();

            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                VrstaPoslaZaPosao vp = (from v in ctx.VrstaPoslaZaPosaos
                                        where v.ID_VrstaPosla == vpp.ID_VrstaPosla
                                        select v).FirstOrDefault();

                idVrstePosla = vp.ID_VrstaPosla;
                vrstaPosla = vp.VrstaPosla;
                vrstaMasine = vp.VrstaMasine;
                imaPomMas = vp.ImaPomMas;

                if (vp.VrstaPosla == "Cena po satu" && vp.VrstaMasine == "Bager" && vp.ImaPomMas == false)
                {
                    List<Masina> bagerList = Masina.ucitajBagere();
                    foreach (Masina bag in bagerList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(bag.NazivMasine, bag.ID_Masina));
                        nazivMasine = bag.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    cbxPomMas.Enabled = false;
                    txtNorma.Enabled = false;
                }

                else if (vp.VrstaPosla == "Iskop do 2m3/m" && vp.VrstaMasine == "Bager" && vp.ImaPomMas == false)
                {
                    List<Masina> bageriList = Masina.ucitajBagere();
                    foreach (Masina bag in bageriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(bag.NazivMasine, bag.ID_Masina));
                        nazivMasine = bag.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    cbxPomMas.Enabled = false;
                }

                else if (vp.VrstaPosla == "Iskop preko 2m3/m" && vp.VrstaMasine == "Bager" && vp.ImaPomMas == false)
                {
                    List<Masina> bageriList = Masina.ucitajBagere();
                    foreach (Masina bag in bageriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(bag.NazivMasine, bag.ID_Masina));
                        nazivMasine = bag.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    cbxPomMas.Enabled = false;
                }

                else if (vp.VrstaPosla == "Terupamne 5-10cm" && vp.VrstaMasine == "Bager" && vp.ImaPomMas == true)
                {
                    List<Masina> bageriList = Masina.ucitajBagere();
                    foreach (Masina bag in bageriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(bag.NazivMasine, bag.ID_Masina));
                        nazivMasine = bag.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    List<PomocnaMasina> pomocneMasineList = PomocnaMasina.ucitajMasine();
                    foreach (PomocnaMasina pm in pomocneMasineList)
                    {
                        if (pm.VrstaMasine == "Tarup za bager")
                        {
                            cbxPomMas.Items.Add(new DictionaryEntry(pm.NazivMasine, pm.ID_PomocnaMasina));
                        }
                    }
                    cbxPomMas.DisplayMember = "Key";
                    cbxPomMas.ValueMember = "Value";

                    cbxPomMas.DataSource = cbxPomMas.Items;
                }

                else if (vp.VrstaPosla == "Terupanje preko 10cm" && vp.VrstaMasine == "Bager" && vp.ImaPomMas == true)
                {
                    List<Masina> bageriList = Masina.ucitajBagere();
                    foreach (Masina bag in bageriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(bag.NazivMasine, bag.ID_Masina));
                        nazivMasine = bag.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    List<PomocnaMasina> pomocneMasineList = PomocnaMasina.ucitajMasine();
                    foreach (PomocnaMasina pm in pomocneMasineList)
                    {
                        if (pm.VrstaMasine == "Tarup za bager")
                        {
                            cbxPomMas.Items.Add(new DictionaryEntry(pm.NazivMasine, pm.ID_PomocnaMasina));
                        }
                    }
                    cbxPomMas.DisplayMember = "Key";
                    cbxPomMas.ValueMember = "Value";

                    cbxPomMas.DataSource = cbxPomMas.Items;
                }

                else if (vp.VrstaPosla == "Terupanje trske" && vp.VrstaMasine == "Bager" && vp.ImaPomMas == true)
                {
                    List<Masina> bageriList = Masina.ucitajBagere();
                    foreach (Masina bag in bageriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(bag.NazivMasine, bag.ID_Masina));
                        nazivMasine = bag.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    List<PomocnaMasina> pomocneMasineList = PomocnaMasina.ucitajMasine();
                    foreach (PomocnaMasina pm in pomocneMasineList)
                    {
                        if (pm.VrstaMasine == "Tarup za bager")
                        {
                            cbxPomMas.Items.Add(new DictionaryEntry(pm.NazivMasine, pm.ID_PomocnaMasina));
                        }
                    }
                    cbxPomMas.DisplayMember = "Key";
                    cbxPomMas.ValueMember = "Value";

                    cbxPomMas.DataSource = cbxPomMas.Items;
                }

                else if (vp.VrstaPosla == "Iskop izmuljenje" && vp.VrstaMasine == "Bager" && vp.ImaPomMas == false)
                {
                    List<Masina> bageriList = Masina.ucitajBagere();
                    foreach (Masina bag in bageriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(bag.NazivMasine, bag.ID_Masina));
                        nazivMasine = bag.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    cbxPomMas.Enabled = false;
                }

                else if (vp.VrstaPosla == "Cena po satu" && vp.VrstaMasine == "Dozer" && vp.ImaPomMas == false)
                {
                    List<Masina> dozeriList = Masina.ucitajDozere();
                    foreach (Masina doz in dozeriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(doz.NazivMasine, doz.ID_Masina));
                        nazivMasine = doz.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    cbxPomMas.Enabled = false;
                    txtNorma.Enabled = false;
                }

                else if (vp.VrstaPosla == "Iskop sa trans. do 30m" && vp.VrstaMasine == "Dozer" && vp.ImaPomMas == false)
                {
                    List<Masina> dozeriList = Masina.ucitajDozere();
                    foreach (Masina doz in dozeriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(doz.NazivMasine, doz.ID_Masina));
                        nazivMasine = doz.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    cbxPomMas.Enabled = false;
                }

                else if (vp.VrstaPosla == "Iskop sa trans. 30-50m" && vp.VrstaMasine == "Dozer" && vp.ImaPomMas == false)
                {
                    List<Masina> dozeriList = Masina.ucitajDozere();
                    foreach (Masina doz in dozeriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(doz.NazivMasine, doz.ID_Masina));
                        nazivMasine = doz.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    cbxPomMas.Enabled = false;
                }

                else if (vp.VrstaPosla == "Planiranje deponije" && vp.VrstaMasine == "Dozer" && vp.ImaPomMas == false)
                {
                    List<Masina> dozeriList = Masina.ucitajDozere();
                    foreach (Masina doz in dozeriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(doz.NazivMasine, doz.ID_Masina));
                        nazivMasine = doz.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    cbxPomMas.Enabled = false;
                }

                else if (vp.VrstaPosla == "Planiranje inspekcijske staze" && vp.VrstaMasine == "Dozer" && vp.ImaPomMas == false)
                {
                    List<Masina> dozeriList = Masina.ucitajDozere();
                    foreach (Masina doz in dozeriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(doz.NazivMasine, doz.ID_Masina));
                        nazivMasine = doz.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    cbxPomMas.Enabled = false;
                }

                else if (vp.VrstaPosla == "Čišćenje terena" && vp.VrstaMasine == "Dozer" && vp.ImaPomMas == false)
                {
                    List<Masina> dozeriList = Masina.ucitajDozere();
                    foreach (Masina doz in dozeriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(doz.NazivMasine, doz.ID_Masina));
                        nazivMasine = doz.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    cbxPomMas.Enabled = false;
                }

                else if (vp.VrstaPosla == "Cena po satu" && vp.VrstaMasine == "Traktor" && vp.ImaPomMas == false)
                {
                    List<Masina> traktoriList = Masina.ucitajTraktore();
                    foreach (Masina tra in traktoriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(tra.NazivMasine, tra.ID_Masina));
                        nazivMasine = tra.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    cbxPomMas.Enabled = false;
                    txtNorma.Enabled = false;
                }

                else if (vp.VrstaPosla == "Košenje" && vp.VrstaMasine == "Traktor" && vp.ImaPomMas == true)
                {
                    List<Masina> traktoriList = Masina.ucitajTraktore();
                    foreach (Masina tra in traktoriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(tra.NazivMasine, tra.ID_Masina));
                        nazivMasine = tra.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    List<PomocnaMasina> pomocneMasineList = PomocnaMasina.ucitajMasine();
                    foreach (PomocnaMasina pm in pomocneMasineList)
                    {
                        if (pm.VrstaMasine == "Kosačica za traktor")
                        {
                            cbxPomMas.Items.Add(new DictionaryEntry(pm.NazivMasine, pm.ID_PomocnaMasina));
                        }
                    }
                    cbxPomMas.DisplayMember = "Key";
                    cbxPomMas.ValueMember = "Value";

                    cbxPomMas.DataSource = cbxPomMas.Items;
                }

                else if (vp.VrstaPosla == "Terupanje 5-10cm" && vp.VrstaMasine == "Traktor" && vp.ImaPomMas == true)
                {
                    List<Masina> traktoriList = Masina.ucitajTraktore();
                    foreach (Masina tra in traktoriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(tra.NazivMasine, tra.ID_Masina));
                        nazivMasine = tra.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    List<PomocnaMasina> pomocneMasineList = PomocnaMasina.ucitajMasine();
                    foreach (PomocnaMasina pm in pomocneMasineList)
                    {
                        if (pm.VrstaMasine == "Tarup za traktor")
                        {
                            cbxPomMas.Items.Add(new DictionaryEntry(pm.NazivMasine, pm.ID_PomocnaMasina));
                        }
                    }
                    cbxPomMas.DisplayMember = "Key";
                    cbxPomMas.ValueMember = "Value";

                    cbxPomMas.DataSource = cbxPomMas.Items;
                }

                else if (vp.VrstaPosla == "Terupanje preko 10cm" && vp.VrstaMasine == "Traktor" && vp.ImaPomMas == true)
                {
                    List<Masina> traktoriList = Masina.ucitajTraktore();
                    foreach (Masina tra in traktoriList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(tra.NazivMasine, tra.ID_Masina));
                        nazivMasine = tra.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    List<PomocnaMasina> pomocneMasineList = PomocnaMasina.ucitajMasine();
                    foreach (PomocnaMasina pm in pomocneMasineList)
                    {
                        if (pm.VrstaMasine == "Tarup za traktor")
                        {
                            cbxPomMas.Items.Add(new DictionaryEntry(pm.NazivMasine, pm.ID_PomocnaMasina));
                        }
                    }
                    cbxPomMas.DisplayMember = "Key";
                    cbxPomMas.ValueMember = "Value";

                    cbxPomMas.DataSource = cbxPomMas.Items;
                }

                else if (vp.VrstaPosla == "Cena po satu" && vp.VrstaMasine == "Kamion" && vp.ImaPomMas == false)
                {
                    List<Masina> kamioniList = Masina.ucitajKamione();
                    foreach (Masina kam in kamioniList)
                    {
                        cbxMasina.Items.Add(new DictionaryEntry(kam.NazivMasine, kam.ID_Masina));
                        nazivMasine = kam.NazivMasine;
                    }
                    cbxMasina.DisplayMember = "Key";
                    cbxMasina.ValueMember = "Value";

                    cbxMasina.DataSource = cbxMasina.Items;

                    cbxPomMas.Enabled = false;
                    txtNorma.Enabled = false;
                }

                else
                {
                    MessageBox.Show("Doslo je do greške u prenosu podataka iz VrstePoslaZaPosao u Posao!");
                }
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).pokreniPosaoPocetna();
            }
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                int idMasine;
                decimal Amortizacija;
                decimal InvesticionoOdrzavanje;
                decimal TekuceOdrzavanje;
                decimal Osiguranje;
                decimal Gorivo;
                decimal Mazivo;
                if (vrstaMasine == "Bager")
                {
                    Masina mas = (from m in ctx.Masinas
                                  where m.VrstaMasine == "Bager" && m.NazivMasine == nazivMasine
                                  select m).FirstOrDefault();
                    idMasine = mas.ID_Masina;
                    Amortizacija = mas.Amortizacija;
                    InvesticionoOdrzavanje = mas.InvesticionoOdrzavanje;
                    TekuceOdrzavanje = mas.TekuceOdrzavanje;
                    Osiguranje = mas.Osiguranje;
                    Gorivo = mas.Gorivo;
                    Mazivo = mas.Mazivo;
                }
                else if (vrstaMasine == "Dozer")
                {
                    Masina mas = (from m in ctx.Masinas
                                  where m.VrstaMasine == "Dozer" && m.NazivMasine == nazivMasine
                                  select m).FirstOrDefault();
                    idMasine = mas.ID_Masina;
                    Amortizacija = mas.Amortizacija;
                    InvesticionoOdrzavanje = mas.InvesticionoOdrzavanje;
                    TekuceOdrzavanje = mas.TekuceOdrzavanje;
                    Osiguranje = mas.Osiguranje;
                    Gorivo = mas.Gorivo;
                    Mazivo = mas.Mazivo;
                }
                else if (vrstaMasine == "Traktor")
                {
                    Masina mas = (from m in ctx.Masinas
                                  where m.VrstaMasine == "Traktor" && m.NazivMasine == nazivMasine
                                  select m).FirstOrDefault();
                    idMasine = mas.ID_Masina;
                    Amortizacija = mas.Amortizacija;
                    InvesticionoOdrzavanje = mas.InvesticionoOdrzavanje;
                    TekuceOdrzavanje = mas.TekuceOdrzavanje;
                    Osiguranje = mas.Osiguranje;
                    Gorivo = mas.Gorivo;
                    Mazivo = mas.Mazivo;
                }
                else if (vrstaMasine == "Kamion")
                {
                    Masina mas = (from m in ctx.Masinas
                                  where m.VrstaMasine == "Kamion" && m.NazivMasine == nazivMasine
                                  select m).FirstOrDefault();
                    idMasine = mas.ID_Masina;
                    Amortizacija = mas.Amortizacija;
                    InvesticionoOdrzavanje = mas.InvesticionoOdrzavanje;
                    TekuceOdrzavanje = mas.TekuceOdrzavanje;
                    Osiguranje = mas.Osiguranje;
                    Gorivo = mas.Gorivo;
                    Mazivo = mas.Mazivo;
                }
                else
                {
                    MessageBox.Show("Doslo je do greške u učitavanju mašine!");

                    idMasine = -1;
                    Amortizacija = 0;
                    InvesticionoOdrzavanje = 0;
                    TekuceOdrzavanje = 0;
                    Osiguranje = 0;
                    Gorivo = 0;
                    Mazivo = 0;
                }

                if (vrstaPosla == "Cena po satu")
                {
                    PomocnaMasina pm = (from p in ctx.PomocnaMasinas
                                        where p.NazivMasine == "NEMA"
                                        select p).FirstOrDefault();
                    string kval;
                    if (vrstaMasine != "Traktor")
                    {
                        kval = "KV";
                    }
                    else
                    {
                        kval = "NSS";
                    }

                    Radnik rad = (from r in ctx.Radniks
                                  where r.Kvalifikacija == kval
                                  select r).FirstOrDefault();
                    Posao pos = new Posao();
                    //pos.ID_Posao = idVrstePosla;//
                    pos.ID_VrstaPosla = idVrstePosla;
                    pos.VrstaPosla = vrstaPosla;
                    pos.VrstaMasine = vrstaMasine;
                    pos.NazivMasine = cbxMasina.Text;
                    pos.Radnici = cbxRadnik.Text;
                    if (cbxRadnik.Text == "Jedan radnik")
                    {
                        pos.PlataRukovaoca = rad.BrutoSatnina;
                        pos.RezijskiTroskovi = rad.BrutoSatninaSaRezijom;
                    }
                    else
                    {
                        pos.PlataRukovaoca = rad.BrutoSatnina * 2;
                        pos.RezijskiTroskovi = rad.BrutoSatninaSaRezijom * 2;
                    }
                    pos.CenaPoCasuRadaBezPDVa = pos.PlataRukovaoca + pos.RezijskiTroskovi;
                    pos.CenaPoCasuRadaSaPDVom = pos.CenaPoCasuRadaBezPDVa * Convert.ToDecimal(1.18);

                    pos.Svega = Amortizacija + InvesticionoOdrzavanje + TekuceOdrzavanje + Osiguranje + Gorivo + Mazivo + pos.PlataRukovaoca;

                    pos.Norma = 0;
                    pos.CenaPoNormiBezPDVa = 0;
                    pos.CenaPoNormiSaPDVom = 0;
                    pos.VrstaPomMas = "NEMA";
                    pos.NazivPomMas = "NEMA";
                    pos.ID_Radnik = rad.ID_Radnik;
                    pos.ID_Masina = idMasine;
                    pos.ID_PomMasina = pm.ID_PomocnaMasina;

                    pos.dodajPosao();
                }
                else if (imaPomMas == false)
                {
                    PomocnaMasina pm = (from p in ctx.PomocnaMasinas
                                        where p.NazivMasine == "NEMA"
                                        select p).FirstOrDefault();
                    string kval;
                    if (vrstaMasine != "Traktor")
                    {
                        kval = "KV";
                    }
                    else
                    {
                        kval = "NSS";
                    }

                    Radnik rad = (from r in ctx.Radniks
                                  where r.Kvalifikacija == kval
                                  select r).FirstOrDefault();
                    Posao pos = new Posao();
                    //pos.ID_Posao = idVrstePosla;//
                    pos.ID_VrstaPosla = idVrstePosla;
                    pos.VrstaPosla = vrstaPosla;
                    pos.VrstaMasine = vrstaMasine;
                    pos.NazivMasine = cbxMasina.Text;
                    pos.Radnici = cbxRadnik.Text;
                    if (cbxRadnik.Text == "Jedan radnik")
                    {
                        pos.PlataRukovaoca = rad.BrutoSatnina;
                        pos.RezijskiTroskovi = rad.BrutoSatninaSaRezijom;
                    }
                    else
                    {
                        pos.PlataRukovaoca = rad.BrutoSatnina * 2;
                        pos.RezijskiTroskovi = rad.BrutoSatninaSaRezijom * 2;
                    }
                    pos.CenaPoCasuRadaBezPDVa = pos.PlataRukovaoca + pos.RezijskiTroskovi;
                    pos.CenaPoCasuRadaSaPDVom = pos.CenaPoCasuRadaBezPDVa * Convert.ToDecimal(1.18);

                    pos.Svega = Amortizacija + InvesticionoOdrzavanje + TekuceOdrzavanje + Osiguranje + Gorivo + Mazivo + pos.PlataRukovaoca;

                    pos.Norma = Convert.ToDecimal(txtNorma.Text);
                    pos.CenaPoNormiBezPDVa = pos.CenaPoCasuRadaBezPDVa / pos.Norma;
                    pos.CenaPoNormiSaPDVom = pos.CenaPoCasuRadaSaPDVom / pos.Norma;
                    pos.VrstaPomMas = "NEMA";
                    pos.NazivPomMas = "NEMA";
                    pos.ID_Radnik = rad.ID_Radnik;
                    pos.ID_Masina = idMasine;
                    pos.ID_PomMasina = pm.ID_PomocnaMasina;

                    pos.dodajPosao();
                }
                else if (imaPomMas == true)
                {
                    PomocnaMasina pm = (from p in ctx.PomocnaMasinas
                                        where p.NazivMasine == cbxPomMas.Text
                                        select p).FirstOrDefault();
                    string kval;
                    if (vrstaMasine != "Traktor")
                    {
                        kval = "KV";
                    }
                    else
                    {
                        kval = "NSS";
                    }

                    Radnik rad = (from r in ctx.Radniks
                                  where r.Kvalifikacija == kval
                                  select r).FirstOrDefault();
                    Posao pos = new Posao();
                    //pos.ID_Posao = idVrstePosla;//
                    pos.ID_VrstaPosla = idVrstePosla;
                    pos.VrstaPosla = vrstaPosla;
                    pos.VrstaMasine = vrstaMasine;
                    pos.NazivMasine = cbxMasina.Text;
                    pos.Radnici = cbxRadnik.Text;
                    if (cbxRadnik.Text == "Jedan radnik")
                    {
                        pos.PlataRukovaoca = rad.BrutoSatnina;
                        pos.RezijskiTroskovi = rad.BrutoSatninaSaRezijom;
                    }
                    else
                    {
                        pos.PlataRukovaoca = rad.BrutoSatnina * 2;
                        pos.RezijskiTroskovi = rad.BrutoSatninaSaRezijom * 2;
                    }
                    pos.CenaPoCasuRadaBezPDVa = pos.PlataRukovaoca + pos.RezijskiTroskovi;
                    pos.CenaPoCasuRadaSaPDVom = pos.CenaPoCasuRadaBezPDVa * Convert.ToDecimal(1.18);

                    pos.Svega = (Amortizacija + pm.Amortizacija) + (InvesticionoOdrzavanje + pm.InvesticionoOdrzavanje) + (TekuceOdrzavanje + pm.TekuceOdrzavanje) + (Osiguranje + pm.Osiguranje) + Gorivo + (Mazivo * pm.Mazivo) + pos.PlataRukovaoca;

                    pos.Norma = Convert.ToDecimal(txtNorma.Text);
                    pos.CenaPoNormiBezPDVa = pos.CenaPoCasuRadaBezPDVa / pos.Norma;
                    pos.CenaPoNormiSaPDVom = pos.CenaPoCasuRadaSaPDVom / pos.Norma;
                    pos.VrstaPomMas = pm.VrstaMasine;
                    pos.NazivPomMas = pm.NazivMasine;
                    pos.ID_Radnik = rad.ID_Radnik;
                    pos.ID_Masina = idMasine;
                    pos.ID_PomMasina = pm.ID_PomocnaMasina;

                    pos.dodajPosao();
                }
                else
                {
                    MessageBox.Show("Doslo je do greške u transferu podataka!");
                }
            }

            prikaziPosloveDGV();
        }

        private void prikaziPosloveDGV()
        {
            posloviList = Posao.ucitajPoslove();
            dgPosao.DataSource = posloviList;
            if (posloviList.Count > 0)
            {
                dgPosao.Rows[0].Cells[0].Selected = false;
                dgPosao.Rows[posloviList.Count - 1].Selected = true;
            }
        }

        private void dgPosao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPosao.CurrentRow != null)
            {
                dgPosao.Rows[dgPosao.CurrentRow.Index].Selected = true;
            }
        }

        private void btnSledeci_Click(object sender, EventArgs e)
        {
            if (dgPosao.Rows.Count > 0)
            {
                int index = dgPosao.SelectedRows[0].Index;
                if (index < dgPosao.Rows.Count - 1)
                {
                    dgPosao.Rows[index].Selected = false;
                    dgPosao.Rows[index + 1].Selected = true;
                    prikaziPosaoTxt();
                }
            }
        }

        private void btnPrethodni_Click(object sender, EventArgs e)
        {
            if (dgPosao.Rows.Count > 0)
            {
                int index = dgPosao.SelectedRows[0].Index;
                if (index > 0)
                {
                    dgPosao.Rows[index].Selected = false;
                    dgPosao.Rows[index - 1].Selected = true;
                    prikaziPosaoTxt();
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgPosao.Rows.Count > 0)
            {
                if (MessageBox.Show("Da li zelite da obrisete odabrani posao?",
                "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    posloviList[dgPosao.SelectedRows[0].Index].obrisiPosao();

                    using (DatotekaDBEntities ctx = new DatotekaDBEntities())
                    {
                        VrstaPoslaZaPosao vp = (from v in ctx.VrstaPoslaZaPosaos
                                                where v.ID_VrstaPosla == idVrstePosla
                                                select v).FirstOrDefault();
                        vp.obrisiVrstuPosla();
                    }

                    prikaziPosloveDGV();
                }
            }
            else
            {
                MessageBox.Show("Nema unetih podataka");
            }
        }

        private void prikaziPosaoTxt()
        {
            if (dgPosao.SelectedRows.Count > 0)
            {
                cbxMasina.Text = dgPosao.SelectedRows[0].Cells["nazivMasine"].Value.ToString();
                cbxRadnik.Text = dgPosao.SelectedRows[0].Cells["radnici"].Value.ToString();
                cbxPomMas.Text = dgPosao.SelectedRows[0].Cells["nazivPomMas"].Value.ToString();
                txtNorma.Text = dgPosao.SelectedRows[0].Cells["norma"].Value.ToString();
            }
        }
    }
}
