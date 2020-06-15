using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Broker;
using Domen;

namespace SistemskeOperacije
{
    public class PrikaziTipove : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                Rezultat = BrokerBaze.DajInstancu().VratiSve(odo);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
