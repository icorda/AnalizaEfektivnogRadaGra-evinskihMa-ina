using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    public partial class Radnik
    {
        public void dodajRadnika()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                ctx.Radniks.AddObject(this);
                ctx.SaveChanges();
            }
        }
        
        public void azurirajRadnikaKV()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var rad = (from r in ctx.Radniks
                           where r.Kvalifikacija == "KV"
                           select r).FirstOrDefault();
                rad.Kvalifikacija = Kvalifikacija;
                rad.KoeficientStrucnosti = KoeficientStrucnosti;
                rad.NetoIznosZaGodDana = NetoIznosZaGodDana;
                rad.NetoSatnina = NetoSatnina;
                rad.BrutoSatnina = BrutoSatnina;
                rad.BrutoSatninaSaRezijom = BrutoSatninaSaRezijom;
                ctx.SaveChanges();
            }
        }

        public void azurirajRadnikaNSS()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var rad = (from r in ctx.Radniks
                           where r.Kvalifikacija == "NSS"
                           select r).FirstOrDefault();
                rad.Kvalifikacija = Kvalifikacija;
                rad.KoeficientStrucnosti = KoeficientStrucnosti;
                rad.NetoIznosZaGodDana = NetoIznosZaGodDana;
                rad.NetoSatnina = NetoSatnina;
                rad.BrutoSatnina = BrutoSatnina;
                rad.BrutoSatninaSaRezijom = BrutoSatninaSaRezijom;
                ctx.SaveChanges();
            }
        }

        public void obrisiRadnika()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var rad = (from r in ctx.Radniks
                           where r.ID_Radnik == ID_Radnik
                           select r).FirstOrDefault();
                ctx.Radniks.DeleteObject(rad);
                ctx.SaveChanges();
            }
        }

        public static List<Radnik> ucitajRadnike()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var radniciList = from r in ctx.Radniks
                                  select r;
                List<Radnik> returnLista = radniciList.ToList<Radnik>();
                return returnLista;
            }
        }

        public static List<Radnik> ucitajRadnikeKV()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var radniciList = (from r in ctx.Radniks
                                   where r.Kvalifikacija == "KV"
                                   select r);
                List<Radnik> returnLista = radniciList.ToList<Radnik>();
                return returnLista;
            }
        }

        public static List<Radnik> ucitajRadnikeNSS()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var radniciList = (from r in ctx.Radniks
                                   where r.Kvalifikacija == "NSS"
                                   select r);
                List<Radnik> returnLista = radniciList.ToList<Radnik>();
                return returnLista;
            }
        }

        public static List<Radnik> ucitajRadnikeZaKalendar(int KalendarID)
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var radniciList = from sl in ctx.Radniks.Include("Kalendar")
                                  where sl.ID_Kalendar == KalendarID
                                  select sl;
                List<Radnik> returnLista = radniciList.ToList<Radnik>();
                return returnLista;
            }
        }

        public static Radnik ucitajRadnikaPoID(int id)
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var rad = (from r in ctx.Radniks
                           where r.ID_Radnik == id
                           select r).FirstOrDefault();
                return rad;
            }
        }
    }
}
