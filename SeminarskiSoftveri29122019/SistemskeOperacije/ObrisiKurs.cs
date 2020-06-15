using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Broker;
using Domen;

namespace SistemskeOperacije
{
    public class ObrisiKurs : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                Kurs kurs = odo as Kurs;
                Poseta p = new Poseta();
                List<IOOpstiDomenskiObjekat> listaPoseta = BrokerBaze.DajInstancu().VratiSve(p);

                foreach (IOOpstiDomenskiObjekat odo1 in listaPoseta)
                {
                    Poseta p1 = odo1 as Poseta;
                    if (p1.KursID == kurs.IdKursa)
                    { 

                        BrokerBaze.DajInstancu().Obrisi(p1);
                        
                        continue;
                    }
                }

                return BrokerBaze.DajInstancu().Obrisi(odo);


            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
