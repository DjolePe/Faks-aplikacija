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
   public class LoginKorisnika : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOOpstiDomenskiObjekat k)
        {
            try
            {
                Korisnik kor = k as Korisnik;

                List<IOOpstiDomenskiObjekat> lista = new List<IOOpstiDomenskiObjekat>();
                lista = BrokerBaze.DajInstancu().VratiSve(k);

                foreach (IOOpstiDomenskiObjekat odo1 in lista)
                {
                    Korisnik korisnik = odo1 as Korisnik;

                    if (korisnik.Password == kor.Password && korisnik.Username == kor.Username)
                    {
                        return true;
                    }

                }
                return false;

            }
            catch(Exception e )
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        
    }
}
