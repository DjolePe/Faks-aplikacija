using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Broker;
using Domen;

namespace SistemskeOperacije
{
    public class UnosPosete : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                
                Clan c = odo as Clan;
                
                foreach (Poseta p in c.ListaPoseta)
                {
                    if (p.BrojPrisustva == 0)
                    {
                        p.BrojPrisustva = BrokerBaze.DajInstancu().VratiSifru(p);
                        int i = BrokerBaze.DajInstancu().Ubaci(p);
                        if (i == 1)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}
