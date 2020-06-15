using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Korisnik : Osoba
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int SifraKorisnika { get; set; }

        public override string vratiAzuriranje()
        {
            throw new NotImplementedException();
        }

        public override string vratiImeTabele()
        {
            return "Korisnik";
        }

        public override string vratiImeTabele2()
        {
            throw new NotImplementedException();
        }

        public override string vratiImeTabeleZaKljuc()
        {
            return "Osoba";
        }

        public override string vratiInsert()
        {
            throw new NotImplementedException();
        }

        public override string vratiInsert2()
        {
            throw new NotImplementedException();
        }

        public override string vratiKljuc()
        {
            return "SifraKorisnika";
        }

        public override List<IOOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOOpstiDomenskiObjekat> lista = new List<IOOpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Korisnik k = new Korisnik
                {
                    SifraKorisnika = (int)citac["Sifra"],
                    
                   Username = (string)citac["Username"],
                   Password = (string)citac["Password"]
                };
                lista.Add(k);

            }

            return lista;
        }

        public override string VratiRezultate()
        {
            throw new NotImplementedException();
        }

        public override string VratiUslov3()
        {
            throw new NotImplementedException();
        }

        public override string VratiUslovDva()
        {
            throw new NotImplementedException();
        }

        public override string VratiUslovJedan()
        {
            throw new NotImplementedException();
        }

        public override string VratiKriterijum()
        {
            throw new NotImplementedException();
        }
    }
}
