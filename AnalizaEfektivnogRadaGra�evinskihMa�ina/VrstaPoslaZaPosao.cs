using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    public partial class VrstaPoslaZaPosao
    {
        public void dodajVrstuPosla()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                ctx.VrstaPoslaZaPosaos.AddObject(this);
                ctx.SaveChanges();
            }
        }

        public void azurirajVrstuPosla()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var vp = (from v in ctx.VrstaPoslaZaPosaos
                          where v.ID_VrstaPosla == ID_VrstaPosla
                          select v).FirstOrDefault();
                vp.VrstaPosla = VrstaPosla;
                vp.VrstaMasine = VrstaMasine;
                vp.ImaPomMas = ImaPomMas;
                ctx.SaveChanges();
            }
        }

        public void obrisiVrstuPosla()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var vp = (from v in ctx.VrstaPoslaZaPosaos
                          where v.ID_VrstaPosla == ID_VrstaPosla
                          select v).FirstOrDefault();
                ctx.VrstaPoslaZaPosaos.DeleteObject(vp);
                ctx.SaveChanges();
            }
        }

        public static List<VrstaPoslaZaPosao> ucitajVrstePosla()
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var vrstePoslaZaPosaoList = from v in ctx.VrstaPoslaZaPosaos
                                            select v;
                List<VrstaPoslaZaPosao> returnLista = vrstePoslaZaPosaoList.ToList<VrstaPoslaZaPosao>();
                return returnLista;
            }
        }

        public static VrstaPoslaZaPosao ucitajVrstePoslaPoID(int id)
        {
            using (DatotekaDBEntities ctx = new DatotekaDBEntities())
            {
                var vp = (from v in ctx.VrstaPoslaZaPosaos
                          where v.ID_VrstaPosla == id
                          select v).FirstOrDefault();
                return vp;
            }
        }
    }
}
