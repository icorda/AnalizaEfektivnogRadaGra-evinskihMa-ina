using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    public partial class Posao
    {
        public void dodajPosao()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                ctx.Posaos.AddObject(this);
                ctx.SaveChanges();
            }
        }

        public void azurirajPosao()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var pos = (from p in ctx.Posaos
                           where p.ID_Posao == ID_Posao
                           select p).FirstOrDefault();
                pos.VrstaPosla = VrstaPosla;
                pos.VrstaMasine = VrstaMasine;
                pos.NazivMasine = NazivMasine;
                pos.Radnici = Radnici;
                pos.PlataRukovaoca = PlataRukovaoca;
                pos.Svega = Svega;
                pos.RezijskiTroskovi = RezijskiTroskovi;
                pos.CenaPoCasuRadaBezPDVa = CenaPoCasuRadaBezPDVa;
                pos.CenaPoCasuRadaSaPDVom = CenaPoCasuRadaSaPDVom;
                pos.Norma = Norma;
                pos.CenaPoNormiBezPDVa = CenaPoNormiBezPDVa;
                pos.CenaPoNormiSaPDVom = CenaPoNormiSaPDVom;
                pos.VrstaPomMas = VrstaPomMas;
                pos.NazivPomMas = NazivPomMas;
                ctx.SaveChanges();
            }
        }

        public void obrisiPosao()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var pos = (from p in ctx.Posaos
                           where p.ID_Posao == ID_Posao
                           select p).FirstOrDefault();
                ctx.Posaos.DeleteObject(pos);
                ctx.SaveChanges();
            }
        }

        public static List<Posao> ucitajPoslove()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var posloviList = from p in ctx.Posaos
                                  select p;
                List<Posao> returnLista = posloviList.ToList<Posao>();
                return returnLista;
            }
        }

        public static List<Posao> ucitajPosloveZaRadnika(int RadnikID)
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var posloviList = from p in ctx.Posaos.Include("Kalendar")
                                  where p.ID_Radnik == RadnikID
                                  select p;
                List<Posao> returnLista = posloviList.ToList<Posao>();
                return returnLista;
            }
        }
    }
}
