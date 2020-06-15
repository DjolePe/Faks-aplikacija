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
    public class ZapamtiKurs : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                Kurs k = odo as Kurs;

                k.IdKursa = BrokerBaze.DajInstancu().VratiSifru(odo);
                int i = BrokerBaze.DajInstancu().Ubaci(k);
                if (i == 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
