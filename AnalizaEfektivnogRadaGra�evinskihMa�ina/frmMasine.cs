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
    public partial class frmMasine : Form
    {
        List<Masina> masineList = new List<Masina>();
        string akcija = "";

        int idKalendara;
        decimal efektivanBrojCasova;
        decimal nafta;

        public frmMasine()
        {
            InitializeComponent();

            dgMasina.AllowUserToAddRows = false;
            dgMasina.AllowUserToDeleteRows = false;
            dgMasina.ReadOnly = true;
            dgMasina.AutoGenerateColumns = false;

            dgMasina.Columns.Add("vrstaMasine", "Vrsta mašine");
            dgMasina.Columns["vrstaMasine"].DataPropertyName = "VrstaMasine";
            dgMasina.Columns.Add("nazivMasine", "Naziv mašine");
            dgMasina.Columns["nazivMasine"].DataPropertyName = "NazivMasine";
            dgMasina.Columns.Add("nabavnaVrednost", "Nabavna vrednost");
            dgMasina.Columns["nabavnaVrednost"].DataPropertyName = "NabavnaVrednost";
            dgMasina.Columns.Add("vekTrajanja", "Vek trajanja");
            dgMasina.Columns["vekTrajanja"].DataPropertyName = "VekTrajanja";
            dgMasina.Columns.Add("godisnjiFondEfCasRad", "Godišnji fond efektivnih časova rada");
            dgMasina.Columns["godisnjiFondEfCasRad"].DataPropertyName = "GodisnjiFondEfCasRad";
            dgMasina.Columns.Add("snagaMotoraKW", "Snaga motora KW");
            dgMasina.Columns["snagaMotoraKW"].DataPropertyName = "SnagaMotoraKW";
            dgMasina.Columns.Add("snagaMotoraKS", "Snaga motora KS");
            dgMasina.Columns["snagaMotoraKS"].DataPropertyName = "SnagaMotoraKS";
            dgMasina.Columns.Add("amortizacija", "Amortizacija");
            dgMasina.Columns["amortizacija"].DataPropertyName = "Amortizacija";
            dgMasina.Columns.Add("investicionoOdrzavanje", "Investiciono Održavanje");
            dgMasina.Columns["investicionoOdrzavanje"].DataPropertyName = "InvesticionoOdrzavanje";
            dgMasina.Columns.Add("tekuceOdrzavanje", "Tekuće Održavanje");
            dgMasina.Columns["tekuceOdrzavanje"].DataPropertyName = "TekuceOdrzavanje";
            dgMasina.Columns.Add("osiguranje", "Osiguranje");
            dgMasina.Columns["osiguranje"].DataPropertyName = "Osiguranje";
            dgMasina.Columns.Add("gorivo", "Gorivo");
            dgMasina.Columns["gorivo"].DataPropertyName = "Gorivo";
            dgMasina.Columns.Add("mazivo", "Mazivo");
            dgMasina.Columns["mazivo"].DataPropertyName = "Mazivo";

            txtDisabled();
            btnChangeEnabled();
            btnSubmitDisabled();

            prikaziMasineDGV();

            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                Kalendar kal = (from k in ctx.Kalendars
                                select k).FirstOrDefault();

                idKalendara = kal.ID_Kalendar;
                nafta = kal.Nafta;
                efektivanBrojCasova = kal.EfektivanBrojCasova;
            }
        }

        private void txtDisabled()
        {
            cbxVrstaMasine.Enabled = false;
            txtNazivMasine.Enabled = false;
            txtNabavnaVrednost.Enabled = false;
            txtVekTrajanja.Enabled = false;
            txtSnagaMotoraKW.Enabled = false;
        }

        private void txtEnabled()
        {
            cbxVrstaMasine.Enabled = true;
            txtNazivMasine.Enabled = true;
            txtNabavnaVrednost.Enabled = true;
            txtVekTrajanja.Enabled = true;
            txtSnagaMotoraKW.Enabled = true;
        }

        private void btnChangeDisabled()
        {
            btnPrethodni.Enabled = false;
            btnSledeci.Enabled = false;
            btnDodaj.Enabled = false;
            btnPromeni.Enabled = false;
            btnObrisi.Enabled = false;
        }

        private void btnChangeEnabled()
        {
            btnPrethodni.Enabled = true;
            btnSledeci.Enabled = true;
            btnDodaj.Enabled = true;
            btnPromeni.Enabled = true;
            btnObrisi.Enabled = true;
        }

        private void btnSubmitDisabled()
        {
            btnPotvrdi.Enabled = false;
            btnOdustani.Enabled = false;
        }

        private void btnSubmitEnabled()
        {
            btnPotvrdi.Enabled = true;
            btnOdustani.Enabled = true;
        }

        private void ponistiUnosTxt()
        {
            cbxVrstaMasine.Text = "";
            txtNazivMasine.Text = "";
            txtNabavnaVrednost.Text = "";
            txtVekTrajanja.Text = "";
            txtSnagaMotoraKW.Text = "";
        }

        private void prikaziMasinuTxt()
        {
            if (dgMasina.SelectedRows.Count > 0)
            {
                cbxVrstaMasine.Text = dgMasina.SelectedRows[0].Cells["vrstaMasine"].Value.ToString();
                txtNazivMasine.Text = dgMasina.SelectedRows[0].Cells["nazivMasine"].Value.ToString();
                txtNabavnaVrednost.Text = dgMasina.SelectedRows[0].Cells["nabavnaVrednost"].Value.ToString();
                txtVekTrajanja.Text = dgMasina.SelectedRows[0].Cells["vekTrajanja"].Value.ToString();
                txtSnagaMotoraKW.Text = dgMasina.SelectedRows[0].Cells["snagaMotoraKW"].Value.ToString();
            }
        }

        private void prikaziMasineDGV()
        {
            masineList = Masina.ucitajMasine();
            dgMasina.DataSource = masineList;
            ponistiUnosTxt();
            if (masineList.Count > 0)
            {
                dgMasina.Rows[0].Cells[0].Selected = false;
                dgMasina.Rows[masineList.Count - 1].Selected = true;
                prikaziMasinuTxt();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ponistiUnosTxt();
            txtEnabled();
            btnSubmitEnabled();
            btnChangeDisabled();
            akcija = "dodaj";
        }

        private void btnPrethodni_Click(object sender, EventArgs e)
        {
            if (dgMasina.Rows.Count > 0)
            {
                if (dgMasina.SelectedRows.Count == 0)
                {
                    dgMasina.Rows[0].Selected = true;
                }
                
                int index = dgMasina.SelectedRows[0].Index;
                if (index > 0)
                {
                    dgMasina.Rows[index].Selected = false;
                    dgMasina.Rows[index - 1].Selected = true;
                    prikaziMasinuTxt();
                }
            }
        }

        private void btnSledeci_Click(object sender, EventArgs e)
        {
            if (dgMasina.Rows.Count > 0)
            {
                if (dgMasina.SelectedRows.Count == 0)
                {
                    dgMasina.Rows[0].Selected = true;
                }
                
                int index = dgMasina.SelectedRows[0].Index;
                if (index < dgMasina.Rows.Count - 1)
                {
                    dgMasina.Rows[index].Selected = false;
                    dgMasina.Rows[index + 1].Selected = true;
                    prikaziMasinuTxt();
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgMasina.Rows.Count > 0)
            {
                if (MessageBox.Show("Da li zelite da obrisete odabranu masinu?",
                "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    masineList[dgMasina.SelectedRows[0].Index].obrisiMasinu();
                    prikaziMasineDGV();
                }
            }
            else
            {
                MessageBox.Show("Nema unetih podataka");
            }
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            if (dgMasina.Rows.Count > 0)
            {
                txtEnabled();
                btnSubmitEnabled();
                btnChangeDisabled();
                akcija = "promeni";
            }
            else
            {
                MessageBox.Show("Nema unetih podataka");
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                if (akcija == "promeni")
                {
                    int index = dgMasina.SelectedRows[0].Index;
                    masineList[index].ID_Kalendar = idKalendara;

                    masineList[index].VrstaMasine = cbxVrstaMasine.Text;
                    masineList[index].NazivMasine = txtNazivMasine.Text;
                    masineList[index].NabavnaVrednost = Convert.ToDecimal(txtNabavnaVrednost.Text);
                    masineList[index].VekTrajanja = Convert.ToDecimal(txtVekTrajanja.Text);
                    masineList[index].GodisnjiFondEfCasRad = efektivanBrojCasova;
                    masineList[index].SnagaMotoraKW = Convert.ToDecimal(txtSnagaMotoraKW.Text);
                    masineList[index].SnagaMotoraKS = Math.Round(masineList[index].SnagaMotoraKW / Convert.ToDecimal(0.73549875), 0);
                    masineList[index].Amortizacija = masineList[index].NabavnaVrednost / masineList[index].VekTrajanja / masineList[index].GodisnjiFondEfCasRad;
                    masineList[index].InvesticionoOdrzavanje = masineList[index].Amortizacija * Convert.ToDecimal(0.6);
                    masineList[index].TekuceOdrzavanje = masineList[index].InvesticionoOdrzavanje * Convert.ToDecimal(0.1);
                    masineList[index].Osiguranje = Convert.ToDecimal(0.001 / 100) * masineList[index].NabavnaVrednost;
                    masineList[index].Gorivo = masineList[index].SnagaMotoraKS * Convert.ToDecimal(0.12 * 1.25) * nafta;
                    masineList[index].Mazivo = masineList[index].Gorivo * Convert.ToDecimal(0.1);

                    masineList[index].azurirajMasinu();
                }

                else if (akcija == "dodaj")
                {
                    Masina mas = new Masina();
                    mas.ID_Kalendar = idKalendara;
                    
                    mas.VrstaMasine = cbxVrstaMasine.Text;
                    mas.NazivMasine = txtNazivMasine.Text;
                    mas.NabavnaVrednost = Convert.ToDecimal(txtNabavnaVrednost.Text);
                    mas.VekTrajanja = Convert.ToDecimal(txtVekTrajanja.Text);
                    mas.GodisnjiFondEfCasRad = efektivanBrojCasova;
                    mas.SnagaMotoraKW = Convert.ToDecimal(txtSnagaMotoraKW.Text);
                    mas.SnagaMotoraKS = Math.Round(mas.SnagaMotoraKW / Convert.ToDecimal(0.73549875), 0);
                    mas.Amortizacija = mas.NabavnaVrednost / mas.VekTrajanja / mas.GodisnjiFondEfCasRad;
                    mas.InvesticionoOdrzavanje = mas.Amortizacija * Convert.ToDecimal(0.6);
                    mas.TekuceOdrzavanje = mas.InvesticionoOdrzavanje * Convert.ToDecimal(0.1);
                    mas.Osiguranje = Convert.ToDecimal(0.001 / 100) * mas.NabavnaVrednost;
                    mas.Gorivo = mas.SnagaMotoraKS * Convert.ToDecimal(0.12 * 1.25) * nafta;
                    mas.Mazivo = mas.Gorivo * Convert.ToDecimal(0.1);

                    mas.dodajMasinu();
                }
                txtDisabled();
                btnSubmitDisabled();
                btnChangeEnabled();
                akcija = "";
                prikaziMasineDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            txtDisabled();
            btnSubmitDisabled();
            btnChangeEnabled();
        }

        private void dgBageri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMasina.CurrentRow != null)
            {
                dgMasina.Rows[dgMasina.CurrentRow.Index].Selected = true;
                prikaziMasinuTxt();
            }
        }
    }
}
