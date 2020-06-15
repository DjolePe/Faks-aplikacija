using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Clan : Osoba
    {
        public int SifraClana { get; set; }
        public string EMail { get; set; }


        BindingList<Poseta> listaPoseta;
        public BindingList<Poseta> ListaPoseta
        {
            get
            {
                return listaPoseta;
            }

            set
            {
                listaPoseta = value;
            }
        }

        public Clan()
        {
            listaPoseta = new BindingList<Poseta>();
        }


        override public string vratiImeTabele()
        {
            return "Clan";
        }

        override public string vratiInsert()
        {
            return $"{SifraClana},'{EMail}'";
        }


        public override string vratiInsert2()
        {
            return $"'{Ime}','{Prezime}','{Sifra}','{Mobilni}'";
        }
        public override string vratiImeTabele2()
        {
            return "Osoba o join Clan c on o.Sifra = c.SifraClana";
        }
      override  public string vratiKljuc()
        {
            return "Sifra";
        }



     override public string ToString()
        {
            return Ime + " " + Prezime;
        }


       override public string VratiUslovDva()
        {
            return $"SifraClana = {SifraClana}";
        }

       override public string VratiUslovJedan()
        {
            return $"Sifra= {Sifra}";
        }

       

       
      override  public string vratiAzuriranje()
        {
            return $"Email ='{EMail}'";
        }



        public string UslovSpajanjaDva()
        {
            return null;
        }

      override  public List<IOOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOOpstiDomenskiObjekat> lista = new List<IOOpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Clan c = new Clan
                {
                    SifraClana = (int)citac["SifraClana"],
                    Ime = (string)citac["Ime"],
                    Prezime = (string)citac["Prezime"],
                    EMail = (string)citac["Email"],
                    Mobilni = (string)citac["Mobilni"]
                };
                lista.Add(c);

            }

            return lista;
        }

        public override string VratiRezultate()
        {
            return "c.SifraClana, o.Ime, o.Prezime,c.Email, o.Mobilni";
        }

        public override string VratiUslov3()
        {
             return $"c.SifraClana = {SifraClana}";
        }

        public override string vratiImeTabeleZaKljuc()
        {
            return "Osoba";
        }

        public override string VratiKriterijum()
        {
           return  $"c.SifraClana, o.Ime, o.Prezime,c.Email, o.Mobilni";
        }
    }
}
