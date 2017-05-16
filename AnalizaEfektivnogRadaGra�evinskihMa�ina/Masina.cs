using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    public partial class Masina
    {
        partial void OnNazivMasineChanging(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Morate uneti naziv masine (ime ili serijski broj)!");
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

        partial void OnSnagaMotoraKWChanging(decimal value)
        {
            if (value < 0)
                throw new Exception("Snaga motora ne moze biti negativna!");
        }

        public void dodajMasinu()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                ctx.Masinas.AddObject(this);
                ctx.SaveChanges();
            }
        }

        public void azurirajMasinu()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var mas = (from m in ctx.Masinas
                           where m.ID_Masina == ID_Masina
                           select m).FirstOrDefault();
                mas.VrstaMasine = VrstaMasine;
                mas.NazivMasine = NazivMasine;
                mas.NabavnaVrednost = NabavnaVrednost;
                mas.VekTrajanja = VekTrajanja;
                mas.GodisnjiFondEfCasRad = GodisnjiFondEfCasRad;
                mas.SnagaMotoraKW = SnagaMotoraKW;
                mas.SnagaMotoraKS = SnagaMotoraKS;
                mas.Amortizacija = Amortizacija;
                mas.InvesticionoOdrzavanje = InvesticionoOdrzavanje;
                mas.TekuceOdrzavanje = TekuceOdrzavanje;
                mas.Osiguranje = Osiguranje;
                mas.Gorivo = Gorivo;
                mas.Mazivo = Mazivo;
                ctx.SaveChanges();
            }
        }

        public void obrisiMasinu()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var mas = (from m in ctx.Masinas
                           where m.ID_Masina == ID_Masina
                           select m).FirstOrDefault();
                ctx.Masinas.DeleteObject(mas);
                ctx.SaveChanges();
            }
        }

        public static List<Masina> ucitajMasine()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var masineList = from m in ctx.Masinas
                                 select m;
                List<Masina> returnLista = masineList.ToList<Masina>();
                return returnLista;
            }
        }

        public static List<Masina> ucitajBagere()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var masineList = (from m in ctx.Masinas
                                  where m.VrstaMasine == "Bager"
                                  select m);
                List<Masina> returnLista = masineList.ToList<Masina>();
                return returnLista;
            }
        }

        public static List<Masina> ucitajDozere()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var masineList = (from m in ctx.Masinas
                                  where m.VrstaMasine == "Dozer"
                                  select m);
                List<Masina> returnLista = masineList.ToList<Masina>();
                return returnLista;
            }
        }

        public static List<Masina> ucitajTraktore()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var masineList = (from m in ctx.Masinas
                                  where m.VrstaMasine == "Traktor"
                                  select m);
                List<Masina> returnLista = masineList.ToList<Masina>();
                return returnLista;
            }
        }

        public static List<Masina> ucitajKamione()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var masineList = (from m in ctx.Masinas
                                  where m.VrstaMasine == "Kamion"
                                  select m);
                List<Masina> returnLista = masineList.ToList<Masina>();
                return returnLista;
            }
        }

        public static List<Masina> ucitajMasineZaKalendar(int KalendarID)
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var masineiList = from sl in ctx.Masinas.Include("Kalendar")
                                  where sl.ID_Kalendar == KalendarID
                                  select sl;
                List<Masina> returnLista = masineiList.ToList<Masina>();
                return returnLista;
            }
        }

        public static Masina ucitajMasinuPoID(int id)
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var mas = (from m in ctx.Masinas
                           where m.ID_Masina == id
                           select m).FirstOrDefault();
                return mas;
            }
        }
    }
}
