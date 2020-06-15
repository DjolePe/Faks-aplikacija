using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Broker;
using Domen;

namespace SistemskeOperacije
{
    public class PrikaziKurseve : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                Kurs kurs = odo as Kurs;
                List<IOOpstiDomenskiObjekat> lista = BrokerBaze.DajInstancu().VratiSveZaUslovJedan(kurs);




                foreach (IOOpstiDomenskiObjekat odo1 in lista)
                {
                    Kurs kurs1 = new Kurs();
                    Ucionica prostor = new Ucionica();


                    kurs1 = odo1 as Kurs;
                    prostor.SifraProstora = kurs1.ProstorInt;

                    List<IOOpstiDomenskiObjekat> lista1 = BrokerBaze.DajInstancu().VratiSveZaUslovDva(prostor);

                    foreach (IOOpstiDomenskiObjekat odo2 in lista1)
                    {
                        Ucionica prostor1 = odo2 as Ucionica;
                        kurs1.Prostor = prostor1;
                    }

                    kurs1.TipKursa = kurs.TipKursa;



                }





                Rezultat = lista;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }
    }
}
