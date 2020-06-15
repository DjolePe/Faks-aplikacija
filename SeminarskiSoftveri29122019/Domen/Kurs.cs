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
   public class Kurs : IOOpstiDomenskiObjekat
    {
        public int IdKursa { get; set; }
        public string Naziv { get; set; }
        public Int32 Trajnje { get; set; }
        public string Cena { get; set; }

        [Browsable(false)]
        public int TipInt { get; set; }

        [Browsable(false)]
        public int ProstorInt { get; set; }

        TipKursa tipKursa;
        public TipKursa TipKursa

        {
            get
            {
                return tipKursa;
            }
            set
            {
                tipKursa = value;
            }
        }

        Ucionica prostor;

        public Kurs()
        {
            listaPoseta = new BindingList<Poseta>();
        }

        private BindingList<Poseta> listaPoseta;

        public BindingList<Poseta> ListaPoseta
        {
            get { return listaPoseta; }
            set { listaPoseta = value; }
        }

        public Ucionica Prostor
        {
            get
            {
                return prostor;
            }
            set
            {
                prostor = value;
            }
        }

        public string vratiImeTabele()
        {
            return "Kurs";
        }

        public string vratiInsert()
        {
            return $"{IdKursa},'{Naziv}',{Trajnje},'{Cena}',{TipKursa.IdTipa},{Prostor.SifraProstora}";
        }

        public string vratiKljuc()
        {
            return "IDKursa";
        }

        

        public string VratiUslovJedan()
        {
            return $"Tip = {TipKursa.IdTipa}";
        }



        public string vratiAzuriranje()
        {
            return $"Cena ='{Cena}', Trajanje = {Trajnje} ";
        }

        public override string ToString()
        {
            return Naziv;
        }



        public string VratiUslovDva()
        {
            return $"IDKursa = {IdKursa}";
        }

        public List<IOOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOOpstiDomenskiObjekat> lista = new List<IOOpstiDomenskiObjekat>();
            while (citac.Read())
            {




                Kurs k = new Kurs
                {
                    IdKursa = (int)citac["IDKursa"],
                    Naziv = (string)citac["Naziv"],
                    Trajnje = (int)citac["Trajanje"],
                    Cena = (string)citac["Cena"],
                    ProstorInt = (int)citac["Prostor"]
                

                };
                lista.Add(k);

            }

            return lista;
        }

        public string vratiInsert2()
        {
            throw new NotImplementedException();
        }

        public string vratiImeTabele2()
        {
            return "Kurs";
        }

        public string VratiRezultate()
        {
            throw new NotImplementedException();
        }

        public string VratiUslov3()
        {
            return $"IDKursa = {IdKursa}";
        }

        public string vratiImeTabeleZaKljuc()
        {
            return "Kurs";
                
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

