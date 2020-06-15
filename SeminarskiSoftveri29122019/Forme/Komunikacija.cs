using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
   public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater = new BinaryFormatter();
        KontrolerKI Ki { get; set; }
        Korisnik Korisnik { get; set; }

        private static Komunikacija instanca;

        public static Komunikacija dajInstancu()
        {
            if (instanca == null)
            {
                instanca = new Komunikacija();
            }
            return instanca;
        }

        internal List<Poseta> VratiPoseteZaMesec(Poseta p)
        {
            List<Poseta> listaPoseta = new List<Poseta>();

            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.VratiPoseteZaMesec,
                TransferObjekat = p
            };

            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;

            if (odgovor.Signal)
            {
                List<IOOpstiDomenskiObjekat> rezultat1 = odgovor.TransferObjekat as List<IOOpstiDomenskiObjekat>;
                if (rezultat1.Count == 0)
                {
                    return null;
                }
                foreach (IOOpstiDomenskiObjekat odo1 in rezultat1)
                {
                    listaPoseta.Add(odo1 as Poseta);
                }


            }
            else
            {

                return null;
            }
            return listaPoseta;
        }

        //public void OsluskujOdgovore(KontrolerKI ki)
        //{
        //    Ki = ki;
        //    Thread nit = new Thread(Osluskuj);
        //    nit.Start();
        //}



        //public void Osluskuj()
        //{
        //    try
        //    {
        //        bool kraj = false;
        //        while (!kraj)
        //        {
        //            Transfer odgovor = formater.Deserialize(tok) as Transfer;
        //            switch (odgovor.Operacija)
        //            {
        //                case Operacija.AzururajClana:
        //                    MessageBox.Show("esss");
        //                    break;
        //            }
        //        }

        //    }
        //    catch (Exception e)
        //    {

        //            throw e;
        //    }
        //}







        public void KonektujSe()
        {
            this.klijent = new TcpClient("127.0.0.1", 8080);
            this.tok = klijent.GetStream();

        }


        //zahtev serveru za prikaz clanova
        internal IList<Clan> VratiClanove()
        {
            List<Clan> listaClanova = new List<Clan>();
            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.VratiClanove
            };

            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;


            if (odgovor.Signal)
            {


                List<IOOpstiDomenskiObjekat> rezultat1 = odgovor.TransferObjekat as List<IOOpstiDomenskiObjekat>;
                foreach (IOOpstiDomenskiObjekat odo1 in rezultat1)
                {
                    listaClanova.Add(odo1 as Clan);
                }


            }
            else
            {
                MessageBox.Show("Greska!");
            }
            return listaClanova;
        }

        internal bool AzurirajClana(Clan clan)
        {
            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.AzururajClana,
                TransferObjekat = clan
            };
            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;
            return odgovor.Signal;
        }

        internal void Logout()
        {
            Transfer transfer = new Transfer
            {
                Operacija = Operacija.Kraj,
            };
            if (klijent != null)
            {
                formater.Serialize(tok, transfer);
                klijent.Close();
            }
        }

        // zahtev serveru za brisanje kursa
        internal bool ObrisiKurs(Kurs kurs)
        {
            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.ObrisiKurs,
                TransferObjekat = kurs
            };
            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;
            return odgovor.Signal;
        }



        internal IList<Poseta> VratiPoseteZaClana(Poseta p)
        {
            List<Poseta> listaPoseta = new List<Poseta>();

            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.VratiPoseteZaClana,
                TransferObjekat = p
            };

            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;

            if (odgovor.Signal)
            {
                List<IOOpstiDomenskiObjekat> rezultat1 = odgovor.TransferObjekat as List<IOOpstiDomenskiObjekat>;
                if (rezultat1.Count == 0)
                {
                    return null;
                }
                foreach (IOOpstiDomenskiObjekat odo1 in rezultat1)
                {
                    listaPoseta.Add(odo1 as Poseta);
                }
             

            }
            else
            {

                return null;
            }
            return listaPoseta;
        }





        //zahtev serveru da obrise posete iz baze 
        internal bool ObrisiPosetu(Poseta poseta)
        {
            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.ObrisiPosetu,
                TransferObjekat = poseta
            };
            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;
            return odgovor.Signal;
        }




        //zahtev serveru za prikaz poseta za datum
        //internal IList<Poseta> PrikaziPosete(Poseta p)
        //{
        //    List<Poseta> listaPoseta = new List<Poseta>();

        //    Transfer zahtev = new Transfer
        //    {
        //        Operacija = Operacija.VratiPoseteZaDatum,
        //        TransferObjekat = p
        //    };

        //    formater.Serialize(tok, zahtev);
        //    Transfer odgovor = formater.Deserialize(tok) as Transfer;

        //    if (odgovor.Signal)
        //    {
        //        List<IOOpstiDomenskiObjekat> rezultat1 = odgovor.TransferObjekat as List<IOOpstiDomenskiObjekat>;
        //        foreach (IOOpstiDomenskiObjekat odo1 in rezultat1)
        //        {
        //            listaPoseta.Add(odo1 as Poseta);
        //        }

        //    }
        //    else
        //    {

        //        MessageBox.Show("Sistem ne moze da pronadje posete");
        //    }
        //    return listaPoseta;
        //}





        // zahtev serveru za izmenu kursa
        internal bool AzurirajKurs(Kurs kurs)
        {
            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.AzurirajKurs,
                TransferObjekat = kurs
            };
            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;
            return odgovor.Signal;
        }





        // zahtev serveru za izmenu posete
        internal bool AzurirajPosetu(Poseta poseta )
        {
            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.AzurirajPosetu,
                TransferObjekat = poseta
            };
            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;
            return odgovor.Signal;
        }





        //zahtev serveru za prijavu korisnika
        public Korisnik PrijaviSe(string ime, string sifra)
        {
            Transfer zahtev = new Transfer()
            {

                TransferObjekat = new Korisnik()
                {
                    Username = ime,
                    Password = sifra
                },
                Operacija = Operacija.Login
            };

            formater.Serialize(tok, zahtev);
             zahtev = formater.Deserialize(tok) as Transfer;
            return zahtev.TransferObjekat as Korisnik;
        }
        


        //Vracamo kurseve za izabrani tip
        internal IList<Kurs> VratiKurseve(Kurs kurs)
        {

            List<Kurs> listaKurseva = new List<Kurs>();

            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.VratiKurseveZaTip,
                TransferObjekat = kurs
            };

            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;

            if (odgovor.Signal)
            {
                List<IOOpstiDomenskiObjekat> rezultat1 = odgovor.TransferObjekat as List<IOOpstiDomenskiObjekat>;
                foreach (IOOpstiDomenskiObjekat odo1 in rezultat1)
                {
                    listaKurseva.Add(odo1 as Kurs);
                }

            }
            else
            {

                MessageBox.Show("Greska!");
            }
            return listaKurseva;

        }




        //zahtev serveru da unese kurs u bazu
        internal bool UbaciKurs(Kurs kurs)
        {
            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.UnesiKurs,
                TransferObjekat = kurs
            };
            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;
            return odgovor.Signal;

        }

        //zahtev serveru da unese posete u bazu

        public bool DodajPosetu(Clan c)
        {
            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.UnesiPosetu,
                TransferObjekat = c
            };
            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;
            return odgovor.Signal;
        }



        //zahtev serveru da vrati listu tipova kurseva
        public IList<TipKursa> VratiTipove()
        {
            List<TipKursa> listaTipova = new List<TipKursa>();
            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.VratiTipoveKurseva
            };

            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;


            if (odgovor.Signal)
            {


                List<IOOpstiDomenskiObjekat> rezultat1 = odgovor.TransferObjekat as List<IOOpstiDomenskiObjekat>;
                foreach (IOOpstiDomenskiObjekat odo1 in rezultat1)
                {
                    listaTipova.Add(odo1 as TipKursa);
                }


            }
            else
            {
                MessageBox.Show("Sistem ne može da pronađe kurseve");
            }
            return listaTipova;
        }

        //zahtev serveru da vrati listu prostora
        public IList<Ucionica> VratiListuProstora()
        {

            List<Ucionica> listaProstora = new List<Ucionica>();
            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.VratiProstore
            };

            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;


            if (odgovor.Signal)
            {

                List<IOOpstiDomenskiObjekat> rezultat = odgovor.TransferObjekat as List<IOOpstiDomenskiObjekat>;
                foreach (IOOpstiDomenskiObjekat odo in rezultat)
                {
                    listaProstora.Add((Ucionica)odo);
                }


            }
            else
            {
                MessageBox.Show("Greska!");
            }
            return listaProstora;
        }

        internal bool ObrisiClana(object clan)
        {
            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.ObrisiClana,
                TransferObjekat = clan
            };
            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;
            return odgovor.Signal;
        }


        //zahtev serveru da ubaci novog clana u sistem
        internal bool UbaciClana(Clan clan)
        {
            Transfer zahtev = new Transfer
            {
                Operacija = Operacija.UbaciClana,
                TransferObjekat = new Clan
                {
                    EMail = clan.EMail,
                    Ime = clan.Ime,
                    Prezime = clan.Prezime,
                    Mobilni = clan.Mobilni,
                    SifraClana = clan.SifraClana
                }
            };
            formater.Serialize(tok, zahtev);
            Transfer odgovor = formater.Deserialize(tok) as Transfer;
            return odgovor.Signal;
        }
    }
}
