using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerPL
{
   public class Repozitorijum
    {
        public static List<Korisnik> listaKorisnika = new List<Korisnik>()
        {
           new Korisnik {Username = "k1", Password = "k1"},
           new Korisnik {Username = "k2", Password = "k2"}
        };

        public static List<Korisnik> ListaKorisnika
        {
            get
            {
                return listaKorisnika;
            }

        }


        public static Korisnik nadjiKorisnika(string ime, string sifra)
        {
            foreach (Korisnik k in listaKorisnika)
            {
                if (k.Username == ime && k.Password == sifra)
                {
                    return k;
                }


            }
            return null;

        }
    }
}
