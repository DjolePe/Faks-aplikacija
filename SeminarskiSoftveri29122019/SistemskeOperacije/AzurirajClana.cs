using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Broker;

namespace SistemskeOperacije
{
   public class AzurirajClana : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                Clan c = odo as Clan;

                Osoba o = new Clan();

                o.Ime = c.Ime;
                o.Prezime = c.Prezime;
                o.Mobilni = c.Mobilni;
                o.Sifra = c.SifraClana;

                if( BrokerBaze.DajInstancu().Azuriraj2(o))
                {
                    return Broker.BrokerBaze.DajInstancu().Azuriraj(odo);
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

     
    }
}
