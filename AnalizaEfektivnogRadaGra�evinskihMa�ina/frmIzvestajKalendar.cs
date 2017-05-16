using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    public partial class frmIzvestajKalendar : Form
    {
        decimal raspoloziviFondCasova;
        decimal drzavniPraznici;
        decimal godisnjiOdmor;
        decimal placeniIzostanci;
        decimal bolovanje;
        decimal efCasPoRadZaGodDan;
        decimal raspoloziviBrojDana;
        decimal zimskiPeriod;
        decimal moguciBrojRadnihDana;
        decimal efektivanBrojCasova;
        decimal faktorBrutoNetoZarade;
        decimal faktorRezije;
        decimal koeficientMinulogRada;
        decimal najnizaCenaRada;
        decimal topliObrok;
        decimal regras;
        decimal prosecanMinuliRad;
        decimal osnovaZaKalkulaciju;
        decimal brojMeseci;
        decimal nafta;

        decimal koeficientStrucnostiKV;
        decimal netoIznosZaGodinuDanaKV;
        decimal netoSatninaKV;
        decimal brutoSatninaKV;
        decimal brutoSatninaSaRezijomKV;

        decimal koeficientStrucnostiNSS;
        decimal netoIznosZaGodinuDanaNSS;
        decimal netoSatninaNSS;
        decimal brutoSatninaNSS;
        decimal brutoSatninaSaRezijomNSS;

        public frmIzvestajKalendar()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                Kalendar kal = (from k in ctx.Kalendars
                                select k).FirstOrDefault();

                raspoloziviFondCasova = kal.RaspoloziviFondCasova;
                drzavniPraznici = kal.DrzavniPraznici;
                godisnjiOdmor = kal.GodisnjiOdmor;
                placeniIzostanci = kal.PlaceniIzostanci;
                bolovanje = kal.Bolovanje;
                efCasPoRadZaGodDan = kal.EfCasPoRadZaGodDan;
                raspoloziviBrojDana = kal.RaspoloziviBrojDana;
                zimskiPeriod = kal.ZimskiPeriod;
                moguciBrojRadnihDana = kal.MoguciBrojRadnihDana;
                efektivanBrojCasova = kal.EfektivanBrojCasova;
                faktorBrutoNetoZarade = kal.FaktorBrutoNetoZarade;
                faktorRezije = kal.FaktorRezije;
                koeficientMinulogRada = kal.KoeficientMinulogRada;
                najnizaCenaRada = kal.NajnizaCenaRada;
                topliObrok = kal.TopliObrok;
                regras = kal.Regras;
                prosecanMinuliRad = kal.ProsecanMinuliRad;
                osnovaZaKalkulaciju = kal.OsnovaZaKalkulaciju;
                brojMeseci = kal.BrojMeseci;
                nafta = kal.Nafta;

                Radnik rad1 = (from r in ctx.Radniks
                               where r.Kvalifikacija == "KV"
                               select r).FirstOrDefault();

                koeficientStrucnostiKV = rad1.KoeficientStrucnosti;
                netoIznosZaGodinuDanaKV = rad1.NetoIznosZaGodDana;
                netoSatninaKV = rad1.NetoSatnina;
                brutoSatninaKV = rad1.BrutoSatnina;
                brutoSatninaSaRezijomKV = rad1.BrutoSatninaSaRezijom;

                Radnik rad2 = (from r in ctx.Radniks
                               where r.Kvalifikacija == "NSS"
                               select r).FirstOrDefault();

                koeficientStrucnostiNSS = rad2.KoeficientStrucnosti;
                netoIznosZaGodinuDanaNSS = rad2.NetoIznosZaGodDana;
                netoSatninaNSS = rad2.NetoSatnina;
                brutoSatninaNSS = rad2.BrutoSatnina;
                brutoSatninaSaRezijomNSS = rad2.BrutoSatninaSaRezijom;

                Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)xla.ActiveSheet;

                xla.Visible = true;

                ws.Cells[1, 2] = "VDP  ''Srednji Banat''";
                ws.Cells[2, 2] = "PJ melioracije, odeljenje tehničke pripreme";
                ws.Cells[3, 2] = "Zrenjanin";

                ws.Cells[5, 2] = "Cena nafte";
                ws.Cells[5, 3] = "=";
                ws.Cells[5, 4] = nafta;

                ws.Cells[7, 1] = "1";
                ws.Cells[8, 1] = "2";
                ws.Cells[14, 1] = "3";
                ws.Cells[15, 1] = "4";
                ws.Cells[20, 1] = "5";
                ws.Cells[21, 1] = "6";
                ws.Cells[22, 1] = "7";
                ws.Cells[23, 1] = "8";
                ws.Cells[24, 1] = "9";
                ws.Cells[25, 1] = "10";
                ws.Cells[26, 1] = "11";
                ws.Cells[27, 1] = "12";
                ws.Cells[28, 1] = "13";
                ws.Cells[32, 1] = "red.";
                ws.Cells[33, 1] = "broj";
                ws.Cells[35, 1] = "1";
                ws.Cells[36, 1] = "1";
                ws.Cells[37, 1] = "2";
                ws.Cells[38, 1] = "";
                ws.Cells[39, 1] = "";

                ws.Cells[7, 2] = "Raspoloživi fond časova";
                ws.Cells[8, 2] = "Neradni dani:";
                ws.Cells[9, 2] = "državni praznici";
                ws.Cells[10, 2] = "godišnji odmor:";
                ws.Cells[11, 2] = "plaćeni izostanci";
                ws.Cells[12, 2] = "bolovanje";
                ws.Cells[14, 2] = "Efektivni časovi po radniku za godinu dana (2.088 - 312)";
                ws.Cells[15, 2] = "Efektivni časovi za mašine u jednoj smeni";
                ws.Cells[20, 2] = "Faktor bruto/neto (zarade)";
                ws.Cells[21, 2] = "Faktor režije";
                ws.Cells[22, 2] = "Koeficijent minulog rada";
                ws.Cells[23, 2] = "Najniža cena rad";
                ws.Cells[24, 2] = "Topli obrok";
                ws.Cells[25, 2] = "Regras (1/12)";
                ws.Cells[26, 2] = "Prosečni minuli rad";
                ws.Cells[27, 2] = "Osnava za kalkulaciju";
                ws.Cells[28, 2] = "Broj meseci";
                ws.Cells[32, 2] = "kvalifikacija";
                ws.Cells[33, 2] = "broj";
                ws.Cells[35, 2] = "2";
                ws.Cells[36, 2] = "KV";
                ws.Cells[37, 2] = "NSS";

                ws.Cells[32, 3] = "koef.";
                ws.Cells[33, 3] = "struč.";
                ws.Cells[35, 3] = "3";
                ws.Cells[36, 3] = koeficientStrucnostiKV;
                ws.Cells[37, 3] = koeficientStrucnostiNSS;

                ws.Cells[7, 4] = raspoloziviFondCasova / 8;
                ws.Cells[9, 4] = drzavniPraznici / 8;
                ws.Cells[10, 4] = godisnjiOdmor / 8;
                ws.Cells[11, 4] = placeniIzostanci / 8;
                ws.Cells[12, 4] = bolovanje / 8;

                ws.Cells[32, 4] = "neto iznos za";
                ws.Cells[33, 4] = "god. dana";
                ws.Cells[35, 4] = "4";
                ws.Cells[36, 4] = netoIznosZaGodinuDanaKV;
                ws.Cells[37, 4] = netoIznosZaGodinuDanaNSS;

                ws.Cells[7, 5] = "dana";
                ws.Cells[9, 5] = "dana";
                ws.Cells[10, 5] = "dana";
                ws.Cells[11, 5] = "dana";
                ws.Cells[12, 5] = "dana";
                ws.Cells[30, 5] = "KALKULATIVNE SATNINE ZA PLAN 2013. GODINE";

                ws.Cells[32, 5] = "neto";
                ws.Cells[33, 5] = "satnina";
                ws.Cells[35, 5] = "5";
                ws.Cells[36, 5] = netoSatninaKV;
                ws.Cells[37, 5] = netoSatninaNSS;

                ws.Cells[7, 6] = "*";
                ws.Cells[9, 6] = "*";
                ws.Cells[10, 6] = "*";
                ws.Cells[11, 6] = "*";
                ws.Cells[12, 6] = "*";

                ws.Cells[32, 6] = "bruto";
                ws.Cells[33, 6] = "satnina";
                ws.Cells[35, 6] = "6";
                ws.Cells[36, 6] = brutoSatninaKV;
                ws.Cells[37, 6] = brutoSatninaNSS;

                ws.Cells[7, 7] = "8";
                ws.Cells[9, 7] = "8";
                ws.Cells[10, 7] = "8";
                ws.Cells[11, 7] = "8";
                ws.Cells[12, 7] = "8";
                ws.Cells[16, 7] = "raspoloživi broj dana (365 - 105)=";
                ws.Cells[17, 7] = "zimski period 63 dana=";
                ws.Cells[18, 7] = "mogući broj radnih dana=";
                ws.Cells[19, 7] = "efektivan broj časova 197 * 12 * 0,79 =";

                ws.Cells[32, 7] = "bruto";
                ws.Cells[33, 7] = "satnina sa";
                ws.Cells[34, 7] = "režijom";
                ws.Cells[35, 7] = "7";
                ws.Cells[36, 7] = brutoSatninaSaRezijomKV;
                ws.Cells[37, 7] = brutoSatninaSaRezijomNSS;

                ws.Cells[7, 8] = "čas";
                ws.Cells[9, 8] = "čas";
                ws.Cells[10, 8] = "čas";
                ws.Cells[11, 8] = "čas";
                ws.Cells[12, 8] = "čas";

                ws.Cells[7, 9] = raspoloziviFondCasova;
                ws.Cells[9, 9] = drzavniPraznici;
                ws.Cells[10, 9] = godisnjiOdmor;
                ws.Cells[11, 9] = placeniIzostanci;
                ws.Cells[12, 9] = bolovanje;
                ws.Cells[13, 9] = drzavniPraznici + godisnjiOdmor + placeniIzostanci + bolovanje;
                ws.Cells[14, 9] = raspoloziviFondCasova - drzavniPraznici + godisnjiOdmor + placeniIzostanci + bolovanje;
                ws.Cells[16, 9] = raspoloziviBrojDana;
                ws.Cells[17, 9] = zimskiPeriod;
                ws.Cells[18, 9] = moguciBrojRadnihDana;
                ws.Cells[19, 9] = efektivanBrojCasova;
                ws.Cells[20, 9] = faktorBrutoNetoZarade;
                ws.Cells[21, 9] = faktorRezije;
                ws.Cells[22, 9] = koeficientMinulogRada;
                ws.Cells[23, 9] = najnizaCenaRada;
                ws.Cells[24, 9] = topliObrok;
                ws.Cells[25, 9] = regras;
                ws.Cells[26, 9] = prosecanMinuliRad;
                ws.Cells[27, 9] = osnovaZaKalkulaciju;
                ws.Cells[28, 9] = brojMeseci;
            }
        }
    }
}
