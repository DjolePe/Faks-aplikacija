using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Broker;
using Domen;

namespace SistemskeOperacije
{
    public class IzmeniPosetu : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOOpstiDomenskiObjekat odo)
        {
            try
            {

                return BrokerBaze.DajInstancu().Azuriraj(odo);

            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}
