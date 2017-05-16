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
    public partial class frmPomocneMasine : Form
    {
        List<PomocnaMasina> pomocneMasineList = new List<PomocnaMasina>();
        string akcija = "";

        int idKalendara;
        decimal efektivanBrojCasova;

        public frmPomocneMasine()
        {
            InitializeComponent();

            dgPomocnaMasina.AllowUserToAddRows = false;
            dgPomocnaMasina.AllowUserToDeleteRows = false;
            dgPomocnaMasina.ReadOnly = true;
            dgPomocnaMasina.AutoGenerateColumns = false;

            dgPomocnaMasina.Columns.Add("vrstaMasine", "Vrsta mašine");
            dgPomocnaMasina.Columns["vrstaMasine"].DataPropertyName = "VrstaMasine";
            dgPomocnaMasina.Columns.Add("nazivMasine", "Naziv mašine");
            dgPomocnaMasina.Columns["nazivMasine"].DataPropertyName = "NazivMasine";
            dgPomocnaMasina.Columns.Add("nabavnaVrednost", "Nabavna vrednost");
            dgPomocnaMasina.Columns["nabavnaVrednost"].DataPropertyName = "NabavnaVrednost";
            dgPomocnaMasina.Columns.Add("vekTrajanja", "Vek trajanja");
            dgPomocnaMasina.Columns["vekTrajanja"].DataPropertyName = "VekTrajanja";
            dgPomocnaMasina.Columns.Add("godisnjiFondEfCasRad", "Godišnji fond efektivnih časova rada");
            dgPomocnaMasina.Columns["godisnjiFondEfCasRad"].DataPropertyName = "GodisnjiFondEfCasRad";
            dgPomocnaMasina.Columns.Add("amortizacija", "Amortizacija");
            dgPomocnaMasina.Columns["amortizacija"].DataPropertyName = "Amortizacija";
            dgPomocnaMasina.Columns.Add("investicionoOdrzavanje", "Investiciono Održavanje");
            dgPomocnaMasina.Columns["investicionoOdrzavanje"].DataPropertyName = "InvesticionoOdrzavanje";
            dgPomocnaMasina.Columns.Add("tekuceOdrzavanje", "Tekuće Održavanje");
            dgPomocnaMasina.Columns["tekuceOdrzavanje"].DataPropertyName = "TekuceOdrzavanje";
            dgPomocnaMasina.Columns.Add("osiguranje", "Osiguranje");
            dgPomocnaMasina.Columns["osiguranje"].DataPropertyName = "Osiguranje";
            dgPomocnaMasina.Columns.Add("mazivo", "Mazivo");
            dgPomocnaMasina.Columns["mazivo"].DataPropertyName = "Mazivo";

            txtDisabled();
            btnChangeEnabled();
            btnSubmitDisabled();

            prikaziMasineDGV();

            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                Kalendar kal = (from k in ctx.Kalendars
                                select k).FirstOrDefault();

                idKalendara = kal.ID_Kalendar;
                efektivanBrojCasova = kal.EfektivanBrojCasova;
            }
        }

        private void txtDisabled()
        {
            txtNazivMasine.Enabled = false;
            cbxVrstaMasine.Enabled = false;
            txtNabavnaVrednost.Enabled = false;
            txtVekTrajanja.Enabled = false;
        }

        private void txtEnabled()
        {
            txtNazivMasine.Enabled = true;
            cbxVrstaMasine.Enabled = true;
            txtNabavnaVrednost.Enabled = true;
            txtVekTrajanja.Enabled = true;
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
            txtNazivMasine.Text = "";
            cbxVrstaMasine.Text = "";
            txtNabavnaVrednost.Text = "";
            txtVekTrajanja.Text = "";
        }

        private void prikaziMasinuTxt()
        {
            if (dgPomocnaMasina.SelectedRows.Count > 0)
            {
                txtNazivMasine.Text = dgPomocnaMasina.SelectedRows[0].Cells["nazivMasine"].Value.ToString();
                cbxVrstaMasine.Text = dgPomocnaMasina.SelectedRows[0].Cells["vrstaMasine"].Value.ToString();
                txtNabavnaVrednost.Text = dgPomocnaMasina.SelectedRows[0].Cells["nabavnaVrednost"].Value.ToString();
                txtVekTrajanja.Text = dgPomocnaMasina.SelectedRows[0].Cells["vekTrajanja"].Value.ToString();
            }
        }

        private void prikaziMasineDGV()
        {
            pomocneMasineList = PomocnaMasina.ucitajMasine();
            dgPomocnaMasina.DataSource = pomocneMasineList;
            ponistiUnosTxt();
            if (pomocneMasineList.Count > 0)
            {
                dgPomocnaMasina.Rows[0].Cells[0].Selected = false;
                dgPomocnaMasina.Rows[pomocneMasineList.Count - 1].Selected = true;
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
            if (dgPomocnaMasina.Rows.Count > 0)
            {
                if (dgPomocnaMasina.SelectedRows.Count == 0)
                {
                    dgPomocnaMasina.Rows[0].Selected = true;
                }
                
                int index = dgPomocnaMasina.SelectedRows[0].Index;
                if (index > 0)
                {
                    dgPomocnaMasina.Rows[index].Selected = false;
                    dgPomocnaMasina.Rows[index - 1].Selected = true;
                    prikaziMasinuTxt();
                }
            }
        }

        private void btnSledeci_Click(object sender, EventArgs e)
        {
            if (dgPomocnaMasina.Rows.Count > 0)
            {
                if (dgPomocnaMasina.SelectedRows.Count == 0)
                {
                    dgPomocnaMasina.Rows[0].Selected = true;
                }
                
                int index = dgPomocnaMasina.SelectedRows[0].Index;
                if (index < dgPomocnaMasina.Rows.Count - 1)
                {
                    dgPomocnaMasina.Rows[index].Selected = false;
                    dgPomocnaMasina.Rows[index + 1].Selected = true;
                    prikaziMasinuTxt();
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgPomocnaMasina.Rows.Count > 0)
            {
                if (MessageBox.Show("Da li zelite da obrisete odabranu masinu?",
                "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    pomocneMasineList[dgPomocnaMasina.SelectedRows[0].Index].obrisiMasinu();
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
            if (dgPomocnaMasina.Rows.Count > 0)
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
                    int index = dgPomocnaMasina.SelectedRows[0].Index;
                    pomocneMasineList[index].ID_Kalendar = idKalendara;

                    pomocneMasineList[index].NazivMasine = txtNazivMasine.Text;
                    pomocneMasineList[index].VrstaMasine = cbxVrstaMasine.Text;
                    pomocneMasineList[index].NabavnaVrednost = Convert.ToDecimal(txtNabavnaVrednost.Text);
                    pomocneMasineList[index].VekTrajanja = Convert.ToDecimal(txtVekTrajanja.Text);
                    pomocneMasineList[index].GodisnjiFondEfCasRad = efektivanBrojCasova;
                    pomocneMasineList[index].Amortizacija = pomocneMasineList[index].NabavnaVrednost / pomocneMasineList[index].VekTrajanja / pomocneMasineList[index].GodisnjiFondEfCasRad;
                    pomocneMasineList[index].InvesticionoOdrzavanje = pomocneMasineList[index].Amortizacija * Convert.ToDecimal(0.6);
                    pomocneMasineList[index].TekuceOdrzavanje = pomocneMasineList[index].InvesticionoOdrzavanje * Convert.ToDecimal(0.1);
                    pomocneMasineList[index].Osiguranje = Convert.ToDecimal(0.001 / 100) * pomocneMasineList[index].NabavnaVrednost;
                    pomocneMasineList[index].Mazivo = 2;

                    pomocneMasineList[index].azurirajMasinu();
                }

                else if (akcija == "dodaj")
                {
                    PomocnaMasina pom = new PomocnaMasina();
                    pom.ID_Kalendar = idKalendara;

                    pom.NazivMasine = txtNazivMasine.Text;
                    pom.VrstaMasine = cbxVrstaMasine.Text;
                    pom.NabavnaVrednost = Convert.ToDecimal(txtNabavnaVrednost.Text);
                    pom.VekTrajanja = Convert.ToDecimal(txtVekTrajanja.Text);
                    pom.GodisnjiFondEfCasRad = efektivanBrojCasova;
                    pom.Amortizacija = pom.NabavnaVrednost / pom.VekTrajanja / pom.GodisnjiFondEfCasRad;
                    pom.InvesticionoOdrzavanje = pom.Amortizacija * Convert.ToDecimal(0.6);
                    pom.TekuceOdrzavanje = pom.InvesticionoOdrzavanje * Convert.ToDecimal(0.1);
                    pom.Osiguranje = Convert.ToDecimal(0.001 / 100) * pom.NabavnaVrednost;
                    pom.Mazivo = 2;

                    pom.dodajMasinu();
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

        private void dgPomocneMasine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPomocnaMasina.CurrentRow != null)
            {
                dgPomocnaMasina.Rows[dgPomocnaMasina.CurrentRow.Index].Selected = true;
                prikaziMasinuTxt();
            }
        }
    }
}
