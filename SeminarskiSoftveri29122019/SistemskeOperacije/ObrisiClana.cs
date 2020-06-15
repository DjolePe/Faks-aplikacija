using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Broker;

namespace SistemskeOperacije
{
  public  class ObrisiClana : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOOpstiDomenskiObjekat odo)
        {
            try
            {

                Osoba o = new Clan();
                    

               Clan clan = odo as Clan;
                clan.Sifra = clan.SifraClana;

                o.Sifra = clan.SifraClana;
                Poseta p = new Poseta();
                List<IOOpstiDomenskiObjekat> listaPoseta = BrokerBaze.DajInstancu().VratiSve(p);



                foreach (IOOpstiDomenskiObjekat odo1 in listaPoseta)
                {
                    Poseta p1 = odo1 as Poseta;
                    if (p1.ClanID == clan.SifraClana)
                    {

                        BrokerBaze.DajInstancu().Obrisi(p1);

                        continue;
                    }
                }


                if( BrokerBaze.DajInstancu().Obrisi(odo))
                {
                    return BrokerBaze.DajInstancu().ObrisiPomocna(o);
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
