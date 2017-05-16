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
    public partial class frmKalendar : Form
    {
        List<Kalendar> kalendarList = new List<Kalendar>();
        List<Radnik> radnikList = new List<Radnik>();
        string akcija = "";

        int idKalendara;
        decimal prosecniMinuliRad;
        decimal osnovaZaKalkulaciju;
        decimal brojMeseci;
        decimal raspoloziviFondCasova;
        decimal faktorBrutoNetoZarade;
        decimal faktorRezije;

        public frmKalendar()
        {
            InitializeComponent();

            dgKalendar.AllowUserToAddRows = false;
            dgKalendar.AllowUserToDeleteRows = false;
            dgKalendar.ReadOnly = true;
            dgKalendar.AutoGenerateColumns = false;
            dgKalendar.Columns.Add("raspoloziviFondCasova", "Raspoloživi fond časova");
            dgKalendar.Columns["raspoloziviFondCasova"].DataPropertyName = "RaspoloziviFondCasova";
            dgKalendar.Columns.Add("drzavniPraznici", "Državni praznici");
            dgKalendar.Columns["drzavniPraznici"].DataPropertyName = "DrzavniPraznici";
            dgKalendar.Columns.Add("godisnjiOdmor", "Godišnji odmor");
            dgKalendar.Columns["godisnjiOdmor"].DataPropertyName = "GodisnjiOdmor";
            dgKalendar.Columns.Add("placeniIzostanci", "Plaćeni izostanci");
            dgKalendar.Columns["placeniIzostanci"].DataPropertyName = "PlaceniIzostanci";
            dgKalendar.Columns.Add("bolovanje", "Bolovanje");
            dgKalendar.Columns["bolovanje"].DataPropertyName = "Bolovanje";
            dgKalendar.Columns.Add("efCasPoRadZaGodDan", "Efektivni časovi po radniku za godinu dana");
            dgKalendar.Columns["efCasPoRadZaGodDan"].DataPropertyName = "EfCasPoRadZaGodDan";
            dgKalendar.Columns.Add("raspoloziviBrojDana", "Raspoloživi broj dana");
            dgKalendar.Columns["raspoloziviBrojDana"].DataPropertyName = "RaspoloziviBrojDana";
            dgKalendar.Columns.Add("zimskiPeriod", "Zimski period");
            dgKalendar.Columns["zimskiPeriod"].DataPropertyName = "ZimskiPeriod";
            dgKalendar.Columns.Add("moguciBrojRadnihDana", "Mogući broj radnih dana");
            dgKalendar.Columns["moguciBrojRadnihDana"].DataPropertyName = "MoguciBrojRadnihDana";
            dgKalendar.Columns.Add("efektivanBrojCasova", "Efektivan broj časova");
            dgKalendar.Columns["efektivanBrojCasova"].DataPropertyName = "EfektivanBrojCasova";
            dgKalendar.Columns.Add("faktorBrutoNetoZarade", "Faktor bruto/neto zarade");
            dgKalendar.Columns["faktorBrutoNetoZarade"].DataPropertyName = "FaktorBrutoNetoZarade";
            dgKalendar.Columns.Add("faktorRezije", "Faktor režije");
            dgKalendar.Columns["faktorRezije"].DataPropertyName = "FaktorRezije";
            dgKalendar.Columns.Add("koeficientMinulogRada", "Koeficient minulog rada");
            dgKalendar.Columns["koeficientMinulogRada"].DataPropertyName = "KoeficientMinulogRada";
            dgKalendar.Columns.Add("najnizaCenaRada", "Najniža cena rada");
            dgKalendar.Columns["najnizaCenaRada"].DataPropertyName = "NajnizaCenaRada";
            dgKalendar.Columns.Add("topliObrok", "Topli obrok");
            dgKalendar.Columns["topliObrok"].DataPropertyName = "TopliObrok";
            dgKalendar.Columns.Add("regras", "Regras");
            dgKalendar.Columns["regras"].DataPropertyName = "Regras";
            dgKalendar.Columns.Add("prosecanMinuliRad", "Prosečan minuli rad");
            dgKalendar.Columns["prosecanMinuliRad"].DataPropertyName = "ProsecanMinuliRad";
            dgKalendar.Columns.Add("osnovaZaKalkulaciju", "Osnova za kalkulaciju");
            dgKalendar.Columns["osnovaZaKalkulaciju"].DataPropertyName = "OsnovaZaKalkulaciju";
            dgKalendar.Columns.Add("brojMeseci", "Broj meseci");
            dgKalendar.Columns["brojMeseci"].DataPropertyName = "BrojMeseci";
            dgKalendar.Columns.Add("nafta", "Nafta");
            dgKalendar.Columns["nafta"].DataPropertyName = "Nafta";

            dgRadnikKV.AllowUserToAddRows = false;
            dgRadnikKV.AllowUserToDeleteRows = false;
            dgRadnikKV.ReadOnly = true;
            dgRadnikKV.AutoGenerateColumns = false;

            dgRadnikNSS.AllowUserToAddRows = false;
            dgRadnikNSS.AllowUserToDeleteRows = false;
            dgRadnikNSS.ReadOnly = true;
            dgRadnikNSS.AutoGenerateColumns = false;

            dgRadnikKV.Columns.Add("kvalifikacija", "Kvalifikacija");
            dgRadnikKV.Columns["kvalifikacija"].DataPropertyName = "Kvalifikacija";
            dgRadnikKV.Columns.Add("koeficientStrucnosti", "Koeficient stručnosti");
            dgRadnikKV.Columns["koeficientStrucnosti"].DataPropertyName = "KoeficientStrucnosti";
            dgRadnikKV.Columns.Add("netoIznosZaGodDana", "Neto iznos za godinu dana");
            dgRadnikKV.Columns["netoIznosZaGodDana"].DataPropertyName = "NetoIznosZaGodDana";
            dgRadnikKV.Columns.Add("netoSatnina", "Neto satnina");
            dgRadnikKV.Columns["netoSatnina"].DataPropertyName = "NetoSatnina";
            dgRadnikKV.Columns.Add("brutoSatnina", "Bruto satnina");
            dgRadnikKV.Columns["brutoSatnina"].DataPropertyName = "BrutoSatnina";
            dgRadnikKV.Columns.Add("brutoSatninaSaRezijom", "Bruto satnina sa režijom");
            dgRadnikKV.Columns["brutoSatninaSaRezijom"].DataPropertyName = "BrutoSatninaSaRezijom";

            dgRadnikNSS.Columns.Add("kvalifikacija", "Kvalifikacija");
            dgRadnikNSS.Columns["kvalifikacija"].DataPropertyName = "Kvalifikacija";
            dgRadnikNSS.Columns.Add("koeficientStrucnosti", "Koeficient stručnosti");
            dgRadnikNSS.Columns["koeficientStrucnosti"].DataPropertyName = "KoeficientStrucnosti";
            dgRadnikNSS.Columns.Add("netoIznosZaGodDana", "Neto iznos za godinu dana");
            dgRadnikNSS.Columns["netoIznosZaGodDana"].DataPropertyName = "NetoIznosZaGodDana";
            dgRadnikNSS.Columns.Add("netoSatnina", "Neto satnina");
            dgRadnikNSS.Columns["netoSatnina"].DataPropertyName = "NetoSatnina";
            dgRadnikNSS.Columns.Add("brutoSatnina", "Bruto satnina");
            dgRadnikNSS.Columns["brutoSatnina"].DataPropertyName = "BrutoSatnina";
            dgRadnikNSS.Columns.Add("brutoSatninaSaRezijom", "Bruto satnina sa režijom");
            dgRadnikNSS.Columns["brutoSatninaSaRezijom"].DataPropertyName = "BrutoSatninaSaRezijom";

            txtDisabled();
            btnChangeEnabled();
            btnSubmitDisabled();

            prikaziKalendarDGV();
            prikaziRadnikaKVDGV();
            prikaziRadnikaNSSDGV();
        }

        private void txtDisabled()
        {
            txtRaspoloziviFondCasova.Enabled = false;
            txtDrzavniPraznici.Enabled = false;
            txtGodisnjiOdmor.Enabled = false;
            txtPlaceniIzostanci.Enabled = false;
            txtBolovanje.Enabled = false;
            txtFaktorBrutoNetoZarade.Enabled = false;
            txtFaktorRezije.Enabled = false;
            txtKoeficientMinulogRada.Enabled = false;
            txtNajnizaCenaRada.Enabled = false;
            txtTopliObrok.Enabled = false;
            txtRegras.Enabled = false;
            txtProsecanMinuliRad.Enabled = false;
            txtNafta.Enabled = false;
        }

        private void txtEnabled()
        {
            txtRaspoloziviFondCasova.Enabled = true;
            txtDrzavniPraznici.Enabled = true;
            txtGodisnjiOdmor.Enabled = true;
            txtPlaceniIzostanci.Enabled = true;
            txtBolovanje.Enabled = true;
            txtFaktorBrutoNetoZarade.Enabled = true;
            txtFaktorRezije.Enabled = true;
            txtKoeficientMinulogRada.Enabled = true;
            txtNajnizaCenaRada.Enabled = true;
            txtTopliObrok.Enabled = true;
            txtRegras.Enabled = true;
            txtProsecanMinuliRad.Enabled = true;
            txtNafta.Enabled = true;
        }

        private void btnChangeDisabled()
        {
            btnDodaj.Enabled = false;
            btnPromeni.Enabled = false;
            btnObrisi.Enabled = false;
        }

        private void btnChangeEnabled()
        {
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
            txtRaspoloziviFondCasova.Text = "";
            txtDrzavniPraznici.Text = "";
            txtGodisnjiOdmor.Text = "";
            txtPlaceniIzostanci.Text = "";
            txtBolovanje.Text = "";
            txtFaktorBrutoNetoZarade.Text = "";
            txtFaktorRezije.Text = "";
            txtKoeficientMinulogRada.Text = "";
            txtNajnizaCenaRada.Text = "";
            txtTopliObrok.Text = "";
            txtRegras.Text = "";
            txtProsecanMinuliRad.Text = "";
            txtNafta.Text = "";
        }

        private void prikaziKalendarTxt()
        {
            txtRaspoloziviFondCasova.Text = dgKalendar.SelectedRows[0].Cells["raspoloziviFondCasova"].Value.ToString();
            txtDrzavniPraznici.Text = dgKalendar.SelectedRows[0].Cells["drzavniPraznici"].Value.ToString();
            txtGodisnjiOdmor.Text = dgKalendar.SelectedRows[0].Cells["godisnjiOdmor"].Value.ToString();
            txtPlaceniIzostanci.Text = dgKalendar.SelectedRows[0].Cells["placeniIzostanci"].Value.ToString();
            txtBolovanje.Text = dgKalendar.SelectedRows[0].Cells["bolovanje"].Value.ToString();
            txtFaktorBrutoNetoZarade.Text = dgKalendar.SelectedRows[0].Cells["faktorBrutoNetoZarade"].Value.ToString();
            txtFaktorRezije.Text = dgKalendar.SelectedRows[0].Cells["faktorRezije"].Value.ToString();
            txtKoeficientMinulogRada.Text = dgKalendar.SelectedRows[0].Cells["koeficientMinulogRada"].Value.ToString();
            txtNajnizaCenaRada.Text = dgKalendar.SelectedRows[0].Cells["najnizaCenaRada"].Value.ToString();
            txtTopliObrok.Text = dgKalendar.SelectedRows[0].Cells["topliObrok"].Value.ToString();
            decimal regras = Math.Round(Convert.ToDecimal(dgKalendar.SelectedRows[0].Cells["regras"].Value) * 12, 0);
            txtRegras.Text = regras.ToString();
            txtProsecanMinuliRad.Text = dgKalendar.SelectedRows[0].Cells["prosecanMinuliRad"].Value.ToString();
            txtNafta.Text = dgKalendar.SelectedRows[0].Cells["nafta"].Value.ToString();
        }

        private void prikaziKalendarDGV()
        {
            kalendarList = Kalendar.ucitajKalendar();
            dgKalendar.DataSource = kalendarList;
            ponistiUnosTxt();
            if (kalendarList.Count > 0)
            {
                dgKalendar.Rows[0].Cells[0].Selected = false;
                dgKalendar.Rows[kalendarList.Count - 1].Selected = true;
                prikaziKalendarTxt();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (dgKalendar.Rows.Count > 0)
            {
                if (MessageBox.Show("Vec imate kalendar, da li zelite da ga promenite?",
                "Potvrda promene", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtEnabled();
                    btnSubmitEnabled();
                    btnChangeDisabled();
                    akcija = "promeni";
                }
            }
            else
            {
                ponistiUnosTxt();
                txtEnabled();
                btnSubmitEnabled();
                btnChangeDisabled();
                akcija = "dodaj";
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgKalendar.Rows.Count > 0)
            {
                if (MessageBox.Show("Da li zelite da obrisete kalendar? VAŽNO: Ovom komandom se brišu i Radnici!",
                "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (DatotekaDBEntities ctx = new DatotekaDBEntities())
                    {
                        Radnik rad = (from r in ctx.Radniks
                                      where r.Kvalifikacija == "KV"
                                      select r).FirstOrDefault();
                        rad.obrisiRadnika();
                    }
                    using (DatotekaDBEntities ctx = new DatotekaDBEntities())
                    {
                        Radnik rad = (from r in ctx.Radniks
                                      where r.Kvalifikacija == "NSS"
                                      select r).FirstOrDefault();
                        rad.obrisiRadnika();
                    }
                    prikaziRadnikaKVDGV();
                    prikaziRadnikaNSSDGV();
                    using (DatotekaDBEntities ctx = new DatotekaDBEntities())
                    {
                        Kalendar kal = (from k in ctx.Kalendars
                                        select k).FirstOrDefault();
                        kal.obrisiKalendar();
                    }
                    prikaziKalendarDGV();
                }
            }
            else
            {
                MessageBox.Show("Nema unetih podataka");
            }
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            if (dgKalendar.Rows.Count > 0)
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
                    int index = dgKalendar.SelectedRows[0].Index;
                    kalendarList[index].RaspoloziviFondCasova = Convert.ToDecimal(txtRaspoloziviFondCasova.Text);
                    kalendarList[index].DrzavniPraznici = Convert.ToDecimal(txtDrzavniPraznici.Text);
                    kalendarList[index].GodisnjiOdmor = Convert.ToDecimal(txtGodisnjiOdmor.Text);
                    kalendarList[index].PlaceniIzostanci = Convert.ToDecimal(txtPlaceniIzostanci.Text);
                    kalendarList[index].Bolovanje = Convert.ToDecimal(txtBolovanje.Text);
                    kalendarList[index].EfCasPoRadZaGodDan = kalendarList[index].RaspoloziviFondCasova - (kalendarList[index].DrzavniPraznici+ kalendarList[index].GodisnjiOdmor + kalendarList[index].PlaceniIzostanci + kalendarList[index].Bolovanje);
                    kalendarList[index].RaspoloziviBrojDana = 365 - 105;
                    kalendarList[index].ZimskiPeriod = 63;
                    kalendarList[index].MoguciBrojRadnihDana = kalendarList[index].RaspoloziviBrojDana - kalendarList[index].ZimskiPeriod;
                    kalendarList[index].EfektivanBrojCasova = kalendarList[index].MoguciBrojRadnihDana * Convert.ToDecimal(12 * 0.79);
                    kalendarList[index].FaktorBrutoNetoZarade = Convert.ToDecimal(txtFaktorBrutoNetoZarade.Text);
                    kalendarList[index].FaktorRezije = Convert.ToDecimal(txtFaktorRezije.Text);
                    kalendarList[index].KoeficientMinulogRada = Convert.ToDecimal(txtKoeficientMinulogRada.Text);
                    kalendarList[index].NajnizaCenaRada = Convert.ToDecimal(txtNajnizaCenaRada.Text);
                    kalendarList[index].TopliObrok = Convert.ToDecimal(txtTopliObrok.Text);
                    kalendarList[index].Regras = Convert.ToDecimal(txtRegras.Text) / 12;
                    kalendarList[index].ProsecanMinuliRad = Convert.ToDecimal(txtProsecanMinuliRad.Text);
                    kalendarList[index].OsnovaZaKalkulaciju = kalendarList[index].NajnizaCenaRada + kalendarList[index].TopliObrok + kalendarList[index].Regras;
                    kalendarList[index].BrojMeseci = 12;
                    kalendarList[index].Nafta = Convert.ToDecimal(txtNafta.Text);

                    kalendarList[index].azurirajKalendar();

                    idKalendara = kalendarList[index].ID_Kalendar;
                    prosecniMinuliRad = kalendarList[index].ProsecanMinuliRad;
                    osnovaZaKalkulaciju = kalendarList[index].OsnovaZaKalkulaciju;
                    brojMeseci = kalendarList[index].BrojMeseci;
                    raspoloziviFondCasova = kalendarList[index].RaspoloziviFondCasova;
                    faktorBrutoNetoZarade = kalendarList[index].FaktorBrutoNetoZarade;
                    faktorRezije = kalendarList[index].FaktorRezije;

                    PromeniRadnike();
                }
                else if (akcija == "dodaj")
                {
                    Kalendar kal = new Kalendar();
                    kal.RaspoloziviFondCasova = Convert.ToDecimal(txtRaspoloziviFondCasova.Text);
                    kal.DrzavniPraznici = Convert.ToDecimal(txtDrzavniPraznici.Text);
                    kal.GodisnjiOdmor = Convert.ToDecimal(txtGodisnjiOdmor.Text);
                    kal.PlaceniIzostanci = Convert.ToDecimal(txtPlaceniIzostanci.Text);
                    kal.Bolovanje = Convert.ToDecimal(txtBolovanje.Text);
                    kal.EfCasPoRadZaGodDan = kal.RaspoloziviFondCasova - (kal.DrzavniPraznici + kal.GodisnjiOdmor + kal.PlaceniIzostanci + kal.Bolovanje);
                    kal.RaspoloziviBrojDana = 365 - 105;
                    kal.ZimskiPeriod = 63;
                    kal.MoguciBrojRadnihDana = kal.RaspoloziviBrojDana - kal.ZimskiPeriod;
                    kal.EfektivanBrojCasova = kal.MoguciBrojRadnihDana * Convert.ToDecimal(12 * 0.79);
                    kal.FaktorBrutoNetoZarade = Convert.ToDecimal(txtFaktorBrutoNetoZarade.Text);
                    kal.FaktorRezije = Convert.ToDecimal(txtFaktorRezije.Text);
                    kal.KoeficientMinulogRada = Convert.ToDecimal(txtKoeficientMinulogRada.Text);
                    kal.NajnizaCenaRada = Convert.ToDecimal(txtNajnizaCenaRada.Text);
                    kal.TopliObrok = Convert.ToDecimal(txtTopliObrok.Text);
                    kal.Regras = Convert.ToDecimal(txtRegras.Text) / 12;
                    kal.ProsecanMinuliRad = Convert.ToDecimal(txtProsecanMinuliRad.Text);
                    kal.OsnovaZaKalkulaciju = kal.NajnizaCenaRada + kal.TopliObrok + kal.Regras;
                    kal.BrojMeseci = 12;
                    kal.Nafta = Convert.ToDecimal(txtNafta.Text);

                    kal.dodajKalendar();

                    idKalendara = kal.ID_Kalendar;
                    prosecniMinuliRad = kal.ProsecanMinuliRad;
                    osnovaZaKalkulaciju = kal.OsnovaZaKalkulaciju;
                    brojMeseci = kal.BrojMeseci;
                    raspoloziviFondCasova = kal.RaspoloziviFondCasova;
                    faktorBrutoNetoZarade = kal.FaktorBrutoNetoZarade;
                    faktorRezije = kal.FaktorRezije;

                    NapraviRadnike();
                }
                txtDisabled();
                btnSubmitDisabled();
                btnChangeEnabled();
                akcija = "";
                prikaziKalendarDGV();
                prikaziRadnikaKVDGV();
                prikaziRadnikaNSSDGV();
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

        private void dgKalendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgKalendar.CurrentRow != null)
            {
                dgKalendar.Rows[dgKalendar.CurrentRow.Index].Selected = true;
                prikaziKalendarTxt();
            }
        }

        private void dgRadnikKV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRadnikKV.CurrentRow != null)
            {
                dgRadnikKV.Rows[dgRadnikKV.CurrentRow.Index].Selected = true;
            }
        }

        private void dgRadnikNSS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRadnikNSS.CurrentRow != null)
            {
                dgRadnikNSS.Rows[dgRadnikKV.CurrentRow.Index].Selected = true;
            }
        }

        private void prikaziRadnikaKVDGV()
        {
            radnikList = Radnik.ucitajRadnikeKV();
            dgRadnikKV.DataSource = radnikList;
            if (radnikList.Count > 0)
            {
                dgRadnikKV.Rows[0].Cells[0].Selected = false;
                dgRadnikKV.Rows[radnikList.Count - 1].Selected = true;
            }
        }

        private void prikaziRadnikaNSSDGV()
        {
            radnikList = Radnik.ucitajRadnikeNSS();
            dgRadnikNSS.DataSource = radnikList;
            if (radnikList.Count > 0)
            {
                dgRadnikNSS.Rows[0].Cells[0].Selected = false;
                dgRadnikNSS.Rows[radnikList.Count - 1].Selected = true;
            }
        }

        private void PromeniRadnike()
        {
            int index1 = dgRadnikKV.SelectedRows[0].Index;
            radnikList[index1].Kvalifikacija = "KV";
            radnikList[index1].KoeficientStrucnosti = Convert.ToDecimal(2.8);
            radnikList[index1].NetoIznosZaGodDana = radnikList[index1].KoeficientStrucnosti * prosecniMinuliRad * osnovaZaKalkulaciju * brojMeseci;
            radnikList[index1].NetoSatnina = radnikList[index1].NetoIznosZaGodDana / raspoloziviFondCasova;
            radnikList[index1].BrutoSatnina = radnikList[index1].NetoSatnina * faktorBrutoNetoZarade;
            radnikList[index1].BrutoSatninaSaRezijom = radnikList[index1].BrutoSatnina * faktorRezije;

            radnikList[index1].azurirajRadnikaKV();

            int index2 = dgRadnikNSS.SelectedRows[0].Index;
            radnikList[index2].Kvalifikacija = "NSS";
            radnikList[index2].KoeficientStrucnosti = Convert.ToDecimal(1.65);
            radnikList[index2].NetoIznosZaGodDana = radnikList[index2].KoeficientStrucnosti * prosecniMinuliRad * osnovaZaKalkulaciju * brojMeseci;
            radnikList[index2].NetoSatnina = radnikList[index2].NetoIznosZaGodDana / raspoloziviFondCasova;
            radnikList[index2].BrutoSatnina = radnikList[index2].NetoSatnina * faktorBrutoNetoZarade;
            radnikList[index2].BrutoSatninaSaRezijom = radnikList[index2].BrutoSatnina * faktorRezije;

            radnikList[index2].azurirajRadnikaNSS();
        }

        private void NapraviRadnike()
        {
            Radnik rad1 = new Radnik();

            rad1.ID_Kalendar = idKalendara;

            rad1.Kvalifikacija = "KV";
            rad1.KoeficientStrucnosti = Convert.ToDecimal(2.8);
            rad1.NetoIznosZaGodDana = rad1.KoeficientStrucnosti * prosecniMinuliRad * osnovaZaKalkulaciju * brojMeseci;
            rad1.NetoSatnina = rad1.NetoIznosZaGodDana / raspoloziviFondCasova;
            rad1.BrutoSatnina = rad1.NetoSatnina * faktorBrutoNetoZarade;
            rad1.BrutoSatninaSaRezijom = rad1.BrutoSatnina * faktorRezije;

            rad1.dodajRadnika();

            Radnik rad2 = new Radnik();

            rad2.ID_Kalendar = idKalendara;

            rad2.Kvalifikacija = "NSS";
            rad2.KoeficientStrucnosti = Convert.ToDecimal(1.65);
            rad2.NetoIznosZaGodDana = rad2.KoeficientStrucnosti * prosecniMinuliRad * osnovaZaKalkulaciju * brojMeseci;
            rad2.NetoSatnina = rad2.NetoIznosZaGodDana / raspoloziviFondCasova;
            rad2.BrutoSatnina = rad2.NetoSatnina * faktorBrutoNetoZarade;
            rad2.BrutoSatninaSaRezijom = rad2.BrutoSatnina * faktorRezije;

            rad2.dodajRadnika();
        }
    }
}
