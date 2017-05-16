using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    public partial class PomocnaMasina
    {
        partial void OnNazivMasineChanging(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Morate uneti naziv masine (ime ili serijski broj)!");
        }

        partial void OnVrstaMasineChanging(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Morate izabrati vrstu masine!");
        }

        partial void OnNabavnaVrednostChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Nabavna vrednost ne moze biti negativna!");
        }

        partial void OnVekTrajanjaChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Vek trajanja ne moze biti negativan!");
        }

        public void dodajMasinu()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                ctx.PomocnaMasinas.AddObject(this);
                ctx.SaveChanges();
            }
        }

        public void azurirajMasinu()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var mas = (from m in ctx.PomocnaMasinas
                           where m.ID_PomocnaMasina == ID_PomocnaMasina
                           select m).FirstOrDefault();
                mas.VrstaMasine = VrstaMasine;
                mas.NazivMasine = NazivMasine;
                mas.NabavnaVrednost = NabavnaVrednost;
                mas.VekTrajanja = VekTrajanja;
                mas.GodisnjiFondEfCasRad = GodisnjiFondEfCasRad;
                mas.Amortizacija = Amortizacija;
                mas.InvesticionoOdrzavanje = InvesticionoOdrzavanje;
                mas.TekuceOdrzavanje = TekuceOdrzavanje;
                mas.Osiguranje = Osiguranje;
                mas.Mazivo = Mazivo;
                ctx.SaveChanges();
            }
        }

        public void obrisiMasinu()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var mas = (from m in ctx.PomocnaMasinas
                           where m.ID_PomocnaMasina == ID_PomocnaMasina
                           select m).FirstOrDefault();
                ctx.PomocnaMasinas.DeleteObject(mas);
                ctx.SaveChanges();
            }
        }

        public static List<PomocnaMasina> ucitajMasine()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var masineList = from m in ctx.PomocnaMasinas
                                 select m;
                List<PomocnaMasina> returnLista = masineList.ToList<PomocnaMasina>();
                return returnLista;
            }
        }

        public static List<PomocnaMasina> ucitajMasineZaKalendar(int KalendarID)
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var masineiList = from m in ctx.PomocnaMasinas.Include("Kalendar")
                                  where m.ID_Kalendar == KalendarID
                                  select m;
                List<PomocnaMasina> returnLista = masineiList.ToList<PomocnaMasina>();
                return returnLista;
            }
        }

        public static PomocnaMasina ucitajMasinuPoID(int id)
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var mas = (from m in ctx.PomocnaMasinas
                           where m.ID_PomocnaMasina == id
                           select m).FirstOrDefault();
                return mas;
            }
        }
    }
}
