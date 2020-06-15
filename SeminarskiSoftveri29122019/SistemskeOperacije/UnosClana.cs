using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Broker;
using Domen;
using System.Windows.Forms;

namespace SistemskeOperacije
{
    public class UnosClana : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                Clan c = odo as Clan;
                Osoba osoba = new Clan();
               
                c.SifraClana = BrokerBaze.DajInstancu().VratiSifru(odo);

           


                osoba.Sifra = c.SifraClana;
                osoba.Ime = c.Ime;
                osoba.Prezime = c.Prezime;
                osoba.Mobilni = c.Mobilni;

              

                int o = BrokerBaze.DajInstancu().Ubaci2(osoba);
                if (o == 1)
                {
                    int i = BrokerBaze.DajInstancu().Ubaci(c);
                    if (i == 1)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }
    }
}
