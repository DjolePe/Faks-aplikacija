using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Broker;
using Domen;

namespace SistemskeOperacije
{
    public class VratiPosete : OpstaSistemskaOperacija
    {
        protected override bool Izvrsi(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                

                Poseta p = odo as Poseta;
                List<IOOpstiDomenskiObjekat> listaGlavna = new List<IOOpstiDomenskiObjekat>();

                List<IOOpstiDomenskiObjekat> lista = BrokerBaze.DajInstancu().VratiSve(odo);



                foreach (IOOpstiDomenskiObjekat odo1 in lista)
                {

                    Poseta p1 = odo1 as Poseta;
              
                   

                    Clan c = new Clan();
                    Kurs k = new Kurs();
                    c.SifraClana = p1.ClanID;
                    k.IdKursa = p1.KursID;
                    Osoba o = new Clan();
                    o.Sifra = c.SifraClana;
                    

                    List<IOOpstiDomenskiObjekat> lista2 = BrokerBaze.DajInstancu().VratiSveZaUslovDva(c);

                    foreach (IOOpstiDomenskiObjekat odo2 in lista2)
                    {
                        Clan c1 = odo2 as Clan;
                        p1.Clan = c1;
                    }

                    List<IOOpstiDomenskiObjekat> lista3 = BrokerBaze.DajInstancu().VratiSveZaUslovDva(k);

                    foreach (IOOpstiDomenskiObjekat odo3 in lista3)
                    {
                        Kurs k1 = odo3 as Kurs;

                        TipKursa tip = new TipKursa();
                        Ucionica prostor = new Ucionica();

                        tip.IdTipa = k1.TipInt;
                        prostor.SifraProstora = k1.ProstorInt;

                        List<IOOpstiDomenskiObjekat> lista4 = BrokerBaze.DajInstancu().VratiSveZaUslovDva(tip);

                        foreach (IOOpstiDomenskiObjekat odo4 in lista4)
                        {
                            TipKursa tip1 = odo4 as TipKursa;
                            k1.TipKursa = tip1;
                        }

                        List<IOOpstiDomenskiObjekat> lista5 = BrokerBaze.DajInstancu().VratiSveZaUslovDva(prostor);

                        foreach (IOOpstiDomenskiObjekat odo5 in lista5)
                        {
                            Ucionica prostor1 = odo5 as Ucionica;
                            k1.Prostor = prostor1;
                        }



                        p1.Kurs = k1;




                    }
                    if (p.Kurs == null)
                    {

                        if (p.Clan.SifraClana == p1.Clan.SifraClana)
                        {
                            listaGlavna.Add(p1);
                        }
                    }
                    else if (p.Clan == null)
                    {
                        if (p.Kurs.IdKursa == p1.Kurs.IdKursa)
                        {
                            listaGlavna.Add(p1);
                        }
                    }
                   else if (p1.Datum.ToString("dd.MM.yyyy") == p.Datum.ToString("dd.MM.yyyy") && p1.Clan.SifraClana == p.Clan.SifraClana) listaGlavna.Add(p1);
                    
                }


                Rezultat = listaGlavna;
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
