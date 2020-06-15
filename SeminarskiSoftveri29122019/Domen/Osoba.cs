using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
   [Serializable]
   public abstract class Osoba : IOOpstiDomenskiObjekat
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mobilni { get; set; }
        public int Sifra { get; set; }

        public abstract string vratiAzuriranje();
        public abstract string vratiImeTabele();



        public abstract string vratiImeTabele2();

        public abstract string vratiImeTabeleZaKljuc();
      

        public abstract string vratiInsert();

        public abstract string vratiInsert2();

      
        public abstract string vratiKljuc();
        public abstract List<IOOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac);

        public abstract string VratiRezultate();

        public abstract string VratiUslov3();

        public abstract string VratiKriterijum();

        public abstract string VratiUslovDva();
        public abstract string VratiUslovJedan();

        public string vratiImeTabele3()
        { 
        
            return "Osoba"; 
        }

        public string vratiInsert3()
        {
            return $"'{Ime}','{Prezime}','{Mobilni}','{Sifra}'";
        }

        public string vratKluc2()
        {
            return $"Sifra = {Sifra}";
        }

        public string vratiAzuriranje2()
        {
            return $"Ime= '{Ime}', Prezime = '{Prezime}', Mobilni = '{Mobilni}'";
        }
    }
}
