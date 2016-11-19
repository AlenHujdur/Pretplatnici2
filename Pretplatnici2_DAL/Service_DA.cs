using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretplatnici2_DAL
{
    public class Service_DA
    {
        public static void InsertPretplatnik(Pretplatnici p)
        {
            using (PretplatniciEntities dm = new PretplatniciEntities())
            {
                dm.usp_PretplatniciInsert(p.Ime, p.Prezime, p.Email, p.Lozinka, p.KorisnickoIme, p.Aktivan, p.StrucnaSpremaID, p.Slika, p.Cv);
            }

        }

        public static List<StrucnaSprema> StrucneSpremeSelectAll()
        {
            using (PretplatniciEntities dm = new PretplatniciEntities())
            {
                return dm.usp_StrucneSpremeSelectAll().ToList();
            }
        }
    }
}
