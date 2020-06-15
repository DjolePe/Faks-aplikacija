using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Ucionica : IOOpstiDomenskiObjekat
    {
        public int SifraProstora { get; set; }
        public string Naziv { get; set; }


        public string vratiImeTabele()
        {
            return "Ucionica";
        }

        public string vratiInsert()
        {
            return $"{SifraProstora},'{Naziv}'";
        }

        public string vratiKljuc()
        {
            return $"SifraProstora = {SifraProstora}";
        }

     


        public override string ToString()
        {
            return Naziv;
        }

        public string VratiUslovJedan()
        {
            return null;
        }

        public string VratiUslovDva()
        {
            return $"SifraProstora = {SifraProstora}";
        }





        public string vratiAzuriranje()
        {
            throw new NotImplementedException();
        }

        public List<IOOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOOpstiDomenskiObjekat> lista = new List<IOOpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Ucionica p = new Ucionica
                {
                    SifraProstora = (int)citac["SifraProstora"],
                    Naziv = (string)citac["NazivProstora"]



                };
                lista.Add(p);

            }

            return lista;
        }

        public string vratiInsert2()
        {
            throw new NotImplementedException();
        }

        public string vratiImeTabele2()
        {
            return "Ucionica";
        }

        public string VratiRezultate()
        {
            throw new NotImplementedException();
        }

        public string VratiUslov3()
        {
            return $"SifraProstora = {SifraProstora}";
        }

        public string vratiImeTabeleZaKljuc()
        {
            return "Ucionica";
        }

        public string VratiKriterijum()
        {
            throw new NotImplementedException();
        }

        public string vratiImeTabele3()
        {
            throw new NotImplementedException();
        }

        public string vratiInsert3()
        {
            throw new NotImplementedException();
        }

        public string vratKluc2()
        {
            throw new NotImplementedException();
        }

        public string vratiAzuriranje2()
        {
            throw new NotImplementedException();
        }
    }
}
