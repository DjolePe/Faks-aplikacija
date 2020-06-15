using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class TipKursa : IOOpstiDomenskiObjekat
    {
        public int IdTipa { get; set; }
        public string NazivTipa { get; set; }


        public string vratiImeTabele()
        {
            return "TipKursa";
        }

        public string vratiInsert()
        {
            return $"{IdTipa},'{NazivTipa}'";
        }

        public string vratiKljuc()
        {
            return $"IDTipa = {IdTipa}";
        }

    

        public override string ToString()
        {
            return NazivTipa;
        }

        public string VratiUslovJedan()
        {
            return $"IDTipa = {IdTipa}";
        }

        public string VratiUslovDva()
        {
            return $"IDTipa = {IdTipa}";
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
                TipKursa tip = new TipKursa
                {
                    IdTipa = Convert.ToInt32(citac["IDTipa"]),
                    NazivTipa = citac["NazivTipa"].ToString()

                };
                lista.Add(tip);

            }

            return lista;
        }

        public string vratiInsert2()
        {
            throw new NotImplementedException();
        }

        public string vratiImeTabele2()
        {
            return "TipKursa";
        }

        public string VratiRezultate()
        {
            throw new NotImplementedException();
        }

        public string VratiUslov3()
        {
            return $"IDTipa = {IdTipa}";
        }

        public string vratiImeTabeleZaKljuc()
        {
            return "TipKursa";
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
