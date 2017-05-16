using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Microsoft.Office.Interop.Excel;

namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    public partial class frmIzvestajPosao : Form
    {
        int idPosao;
        int idMasine;
        int idPomMas;

        string vrstaMasine;
        string nazivMasine;
        decimal nabavnaVrednost;
        decimal vekTrajanja;
        decimal godisnjiFondEfCasRada;
        decimal snagaMotoraKW;
        decimal snagaMotoraKS;
        decimal amortizacija;
        decimal investicionoOdrzavanje;
        decimal tekuceOdrzavanje;
        decimal osiguranje;
        decimal gorivo;
        decimal mazivo;

        string vrstaPosla;
        string radnici;
        decimal plataRukovaoca;
        decimal svega;
        decimal rezijskiTroskovi;
        decimal cenaPoCasuRadaBezPDVa;
        decimal cenaPoCasuRadaSaPDVom;
        decimal norma;
        decimal cenaPoNormiBezPDVa;
        decimal cenaPoNormiSaPDVom;

        string vrstaMasinePM;
        string nazivMasinePM;
        decimal nabavnaVrednostPM;
        decimal vekTrajanjaPM;
        decimal godisnjiFondEfCasRadaPM;
        decimal amortizacijaPM;
        decimal investicionoOdrzavanjePM;
        decimal tekuceOdrzavanjePM;
        decimal osiguranjePM;
        decimal mazivoPM;

        public frmIzvestajPosao()
        {
            InitializeComponent();

            List<Posao> posloviList = Posao.ucitajPoslove();
            cbxPosao.Items.Add(new DictionaryEntry("Odaberite posao", 0));
            foreach (Posao pos in posloviList)
            {
                cbxPosao.Items.Add(new DictionaryEntry(pos.ID_Posao + " " + pos.VrstaMasine + " " + pos.VrstaPosla, pos.ID_Posao));
            }
            cbxPosao.DisplayMember = "Key";
            cbxPosao.ValueMember = "Value";
            cbxPosao.DataSource = cbxPosao.Items;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            idPosao = Int32.Parse(cbxPosao.SelectedValue.ToString());

            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                Posao pos = (from p in ctx.Posaos
                             where p.ID_Posao == idPosao
                             select p).FirstOrDefault();

                vrstaPosla = pos.VrstaPosla;
                radnici = pos.Radnici;
                plataRukovaoca = pos.PlataRukovaoca;
                svega = pos.Svega;
                rezijskiTroskovi = pos.RezijskiTroskovi;
                cenaPoCasuRadaBezPDVa = pos.CenaPoCasuRadaBezPDVa;
                cenaPoCasuRadaSaPDVom = pos.CenaPoCasuRadaSaPDVom;
                norma = pos.Norma;
                cenaPoNormiBezPDVa = pos.CenaPoNormiBezPDVa;
                cenaPoNormiSaPDVom = pos.CenaPoNormiSaPDVom;
                idMasine = pos.ID_Masina;
                idPomMas = pos.ID_PomMasina;


                Masina mas = (from m in ctx.Masinas
                              where m.ID_Masina == idMasine
                              select m).FirstOrDefault();

                vrstaMasine = mas.VrstaMasine;
                nazivMasine = mas.NazivMasine;
                nabavnaVrednost = mas.NabavnaVrednost;
                vekTrajanja = mas.VekTrajanja;
                godisnjiFondEfCasRada = mas.GodisnjiFondEfCasRad;
                snagaMotoraKW = mas.SnagaMotoraKS;
                snagaMotoraKS = mas.SnagaMotoraKW;
                amortizacija = mas.Amortizacija;
                investicionoOdrzavanje = mas.InvesticionoOdrzavanje;
                tekuceOdrzavanje = mas.TekuceOdrzavanje;
                osiguranje = mas.Osiguranje;
                gorivo = mas.Gorivo;
                mazivo = mas.Mazivo;


                PomocnaMasina pmas = (from m in ctx.PomocnaMasinas
                                      where m.ID_PomocnaMasina == idPomMas
                                      select m).FirstOrDefault();

                vrstaMasinePM = pmas.VrstaMasine;
                nazivMasinePM = pmas.NazivMasine;
                nabavnaVrednostPM = pmas.NabavnaVrednost;
                vekTrajanjaPM = pmas.VekTrajanja;
                godisnjiFondEfCasRadaPM = pmas.GodisnjiFondEfCasRad;
                amortizacijaPM = pmas.Amortizacija;
                investicionoOdrzavanjePM = pmas.InvesticionoOdrzavanje;
                tekuceOdrzavanjePM = pmas.TekuceOdrzavanje;
                osiguranjePM = pmas.Osiguranje;
                mazivoPM = pmas.Mazivo;
            }

            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xla.ActiveSheet;

            xla.Visible = true;

            ws.Cells[1, 2] = "VDP  ''Srednji Banat''";
            ws.Cells[2, 2] = "PJ melioracije, odeljenje tehničke pripreme";
            ws.Cells[3, 2] = "Zrenjanin";

            ws.Cells[5, 1] = "Red. broj";
            ws.Cells[11, 1] = "1";
            ws.Cells[12, 1] = "2";
            ws.Cells[13, 1] = "3";
            ws.Cells[14, 1] = "4";
            ws.Cells[15, 1] = "5";
            ws.Cells[18, 1] = "1";
            ws.Cells[19, 1] = "2";
            ws.Cells[20, 1] = "3";
            ws.Cells[21, 1] = "4";
            ws.Cells[22, 1] = "5";
            ws.Cells[23, 1] = "6";
            ws.Cells[24, 1] = "7";
            ws.Cells[35, 1] = "";
            ws.Cells[36, 1] = "";

            ws.Cells[5, 2] = "PODACI";
            ws.Cells[10, 2] = "I  OSNOVNI PODACI O MAŠINI";
            ws.Cells[11, 2] = "Nabavna vrednost";
            ws.Cells[12, 2] = "Vek trajanja";
            ws.Cells[13, 2] = "Godišnji fond ef. čas. rada";
            ws.Cells[14, 2] = "Snaga motora";
            ws.Cells[15, 2] = "Snaga motora";
            ws.Cells[17, 2] = "II  DIREKTNI TROŠKOVI";
            ws.Cells[18, 2] = "Amortizacija";
            ws.Cells[19, 2] = "Investiciono održavanje (60 % amortizacije)";
            ws.Cells[20, 2] = "Tekuće održavanje (10 % ivest. održavanja)";
            ws.Cells[21, 2] = "Osiguranje (0,001 ‰ od nabavne cene)";
            ws.Cells[22, 2] = "Gorivo (120 gr / KS na čas)";
            ws.Cells[23, 2] = "Mazivo - ulje (10 % od cene goriva)";
            ws.Cells[24, 2] = "Plata rukovaoca - bruto";
            ws.Cells[25, 2] = "II SVEGA";
            ws.Cells[27, 2] = "III  REŽIJSKI TROŠKOVI (faktor 1,50)";
            ws.Cells[29, 2] = "Cena po času rada bez PDV-a";
            ws.Cells[30, 2] = "Cena po času rada sa PDV-om";
            ws.Cells[31, 2] = "Norma";
            ws.Cells[32, 2] = "Jedinica mere";
            ws.Cells[33, 2] = "Cena po normi bez PDV-a";
            ws.Cells[34, 2] = "Cena po normi sa PDV-om";

            ws.Cells[5, 3] = "PODACI";
            ws.Cells[11, 3] = "din";
            ws.Cells[12, 3] = "god";
            ws.Cells[13, 3] = "čas";
            ws.Cells[14, 3] = "KW";
            ws.Cells[15, 3] = "KS";
            ws.Cells[18, 3] = "din/čas";
            ws.Cells[19, 3] = "din/čas";
            ws.Cells[20, 3] = "din/čas";
            ws.Cells[21, 3] = "din/čas";
            ws.Cells[22, 3] = "din/čas";
            ws.Cells[23, 3] = "din/čas";
            ws.Cells[24, 3] = "din/čas";
            ws.Cells[25, 3] = "din/čas";
            ws.Cells[27, 3] = "din/čas";
            ws.Cells[29, 3] = "din/čas";
            ws.Cells[30, 3] = "din/čas";
            ws.Cells[33, 3] = "din/čas";
            ws.Cells[34, 3] = "din/čas";

            ws.Cells[5, 4] = vrstaPosla;
            ws.Cells[6, 4] = radnici;
            ws.Cells[7, 4] = nazivMasine;
            ws.Cells[8, 4] = vrstaMasine;
            ws.Cells[11, 4] = nabavnaVrednost;
            ws.Cells[12, 4] = vekTrajanja;
            ws.Cells[13, 4] = godisnjiFondEfCasRada;
            ws.Cells[14, 4] = snagaMotoraKW;
            ws.Cells[15, 4] = snagaMotoraKS;
            ws.Cells[18, 4] = amortizacija;
            ws.Cells[19, 4] = investicionoOdrzavanje;
            ws.Cells[20, 4] = tekuceOdrzavanje;
            ws.Cells[21, 4] = osiguranje;
            ws.Cells[22, 4] = gorivo;
            ws.Cells[23, 4] = mazivo;
            ws.Cells[24, 4] = plataRukovaoca;
            ws.Cells[25, 4] = svega;
            ws.Cells[27, 4] = rezijskiTroskovi;
            ws.Cells[29, 4] = cenaPoCasuRadaBezPDVa;
            ws.Cells[30, 4] = cenaPoCasuRadaSaPDVom;
            ws.Cells[31, 4] = norma;
            ws.Cells[32, 4] = "m3/m'";
            ws.Cells[33, 4] = cenaPoNormiBezPDVa;
            ws.Cells[34, 4] = cenaPoNormiSaPDVom;

            ws.Cells[7, 5] = nazivMasinePM;
            ws.Cells[8, 5] = vrstaMasinePM;
            ws.Cells[11, 5] = nabavnaVrednostPM;
            ws.Cells[12, 5] = vekTrajanjaPM;
            ws.Cells[13, 5] = godisnjiFondEfCasRadaPM;
            ws.Cells[18, 5] = amortizacijaPM;
            ws.Cells[19, 5] = investicionoOdrzavanjePM;
            ws.Cells[20, 5] = tekuceOdrzavanjePM;
            ws.Cells[21, 5] = osiguranjePM;
            ws.Cells[23, 5] = mazivoPM;
        }
    }
}
