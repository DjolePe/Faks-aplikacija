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
    public class PrikaziClanove : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                Rezultat = BrokerBaze.DajInstancu().VratiSve2(odo);
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
