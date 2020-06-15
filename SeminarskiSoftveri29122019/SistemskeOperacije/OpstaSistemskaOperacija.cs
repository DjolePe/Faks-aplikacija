using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        public object Rezultat { get; set; }

        public bool IzvrsiSO(IOOpstiDomenskiObjekat odo)
        {
            bool rezultat = false;

            BrokerBaze.DajInstancu().OtvoriKonekciju();
            BrokerBaze.DajInstancu().PokreniTransakciju();
            rezultat = Izvrsi(odo);
            if (rezultat)
            {
                BrokerBaze.DajInstancu().Commit();
            }
            else
            {
                BrokerBaze.DajInstancu().Rollback();
            }
            BrokerBaze.DajInstancu().ZatvoriKonekciju();
            return rezultat;
        }



        protected abstract bool Izvrsi(IOOpstiDomenskiObjekat odo);
    }
}
