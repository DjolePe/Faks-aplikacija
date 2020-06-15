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
    public class Poseta : IOOpstiDomenskiObjekat
    {
        public Clan Clan { get; set; }
        public Kurs Kurs { get; set; }
        public int BrojPrisustva { get; set; }



        DateTime datum;
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }


        [Browsable(false)]

        public int ClanID { get; set; }
        [Browsable(false)]
        public int KursID { get; set; }




        public string vratiAzuriranje()
        {
            return $"Datum = '{Datum.ToShortDateString()}'";
        }

        public string vratiImeTabele()
        {
            return "Prisustvo";
        }





        public string vratiInsert()
        {
            return $"{Kurs.IdKursa},{Clan.SifraClana},{BrojPrisustva},'{Datum}'";
        }

        public string vratiKljuc()
        {
            return $"BrojPosete" ;
        }







        public string VratiUslovJedan()
        {
            return $"Datum = {Datum}";
        }

       
        public string VratiUslovDva()
        {
            return $"BrojPosete = {BrojPrisustva}"; 
        }

        public List<IOOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOOpstiDomenskiObjekat> lista = new List<IOOpstiDomenskiObjekat>();
            while (citac.Read())
            {



                Poseta poseta = new Poseta
                {
                    BrojPrisustva = (int)citac["BrojPosete"]  ,
                    Datum = Convert.ToDateTime(citac["Datum"]),
                    ClanID = Convert.ToInt32(citac["Clan"]),
                    KursID = Convert.ToInt32(citac["Kurs"])




                };
                lista.Add(poseta);

            }

            return lista;
        }

        public string vratiInsert2()
        {
            throw new NotImplementedException();
        }

        public string vratiImeTabele2()
        {
            return "Prisustvo";
        }

        public string VratiRezultate()
        {
            throw new NotImplementedException();
        }

        public string VratiUslov3()
        {
            return $"BrojPosete = {BrojPrisustva}";
        }

        public string vratiImeTabeleZaKljuc()
        {
            return "Prisustvo";
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
