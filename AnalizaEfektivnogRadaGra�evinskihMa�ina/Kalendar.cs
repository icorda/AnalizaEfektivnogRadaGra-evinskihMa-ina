using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    public partial class Kalendar
    {
        partial void OnRaspoloziviFondCasovaChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Raspolozivi fond casova ne moze biti negativna vrednost!");
        }

        partial void OnDrzavniPrazniciChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Drzavni praznici ne moze biti negativna vrednost!");
        }

        partial void OnPlaceniIzostanciChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Placeni izostanci ne moze biti negativna vrednost!");
        }

        partial void OnBolovanjeChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Bolovanje ne moze biti negativna vrednost!");
        }

        partial void OnFaktorBrutoNetoZaradeChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Faktor bruto\neto zarade ne moze biti negativna vrednost!");
        }

        partial void OnFaktorRezijeChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Faktor rezije ne moze biti negativna vrednost!");
        }

        partial void OnKoeficientMinulogRadaChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Koeficient minulog rada ne moze biti negativna vrednost!");
        }

        partial void OnNajnizaCenaRadaChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Najniza cena rada ne moze biti negativna vrednost!");
        }

        partial void OnTopliObrokChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Topli obrok ne moze biti negativna vrednost!");
        }

        partial void OnRegrasChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Regras ne moze biti negativna vrednost!");
        }

        partial void OnProsecanMinuliRadChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Prosecni minuli rad ne moze biti negativna vrednost!");
        }

        public void dodajKalendar()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                ctx.Kalendars.AddObject(this);
                ctx.SaveChanges();
            }
        }

        public void azurirajKalendar()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var kal = (from k in ctx.Kalendars
                           where k.ID_Kalendar == ID_Kalendar
                           select k).FirstOrDefault();
                kal.RaspoloziviFondCasova = RaspoloziviFondCasova;
                kal.DrzavniPraznici = DrzavniPraznici;
                kal.GodisnjiOdmor = GodisnjiOdmor;
                kal.PlaceniIzostanci = PlaceniIzostanci;
                kal.Bolovanje = Bolovanje;
                kal.EfCasPoRadZaGodDan = EfCasPoRadZaGodDan;
                kal.RaspoloziviBrojDana = RaspoloziviBrojDana;
                kal.ZimskiPeriod = ZimskiPeriod;
                kal.MoguciBrojRadnihDana = MoguciBrojRadnihDana;
                kal.EfektivanBrojCasova = EfektivanBrojCasova;
                kal.FaktorBrutoNetoZarade = FaktorBrutoNetoZarade;
                kal.FaktorRezije = FaktorRezije;
                kal.KoeficientMinulogRada = KoeficientMinulogRada;
                kal.NajnizaCenaRada = NajnizaCenaRada;
                kal.TopliObrok = TopliObrok;
                kal.Regras = Regras;
                kal.ProsecanMinuliRad = ProsecanMinuliRad;
                kal.OsnovaZaKalkulaciju = OsnovaZaKalkulaciju;
                kal.BrojMeseci = BrojMeseci;
                kal.Nafta = Nafta;
                ctx.SaveChanges();
            }
        }

        public void obrisiKalendar()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var kal = (from k in ctx.Kalendars
                           where k.ID_Kalendar == ID_Kalendar
                           select k).FirstOrDefault();
                ctx.Kalendars.DeleteObject(kal);
                ctx.SaveChanges();
            }
        }

        public static List<Kalendar> ucitajKalendar()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var kalendarList = from k in ctx.Kalendars
                                   select k;
                List<Kalendar> returnLista = kalendarList.ToList<Kalendar>();
                return returnLista;
            }
        }

        public static Kalendar ucitajKalendarPoID(int id)
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var kal = (from k in ctx.Kalendars
                           where k.ID_Kalendar == id
                           select k).FirstOrDefault();
                return kal;
            }
        }
    }
}
