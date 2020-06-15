using Domen;
using KontrolerPL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
   public class ObradaKlijenata
    {
        Socket klijent;
        NetworkStream tok;
        BinaryFormatter formater = new BinaryFormatter();
        List<ObradaKlijenata> klijenti;

        public ObradaKlijenata(Socket klijent, List<ObradaKlijenata> klijenti)
        {
            
            this.klijent = klijent;
            tok = new NetworkStream(this.klijent);
            this.klijenti = klijenti;
          

            Thread nit = new Thread(ObradaZahteva);
            nit.Start();
        }

        private void ObradaZahteva()
        {
            bool kraj = false;
            try
            {
                while (!kraj)
                {
                    Transfer zahtev = formater.Deserialize(tok) as Transfer;

                    Transfer odgovor = new Transfer();
                    switch (zahtev.Operacija)
                    {
                        case Operacija.Login:

                          IOOpstiDomenskiObjekat korisnik = Kontroler.prijaviKorisnika(zahtev.TransferObjekat as Korisnik);
                            if (korisnik != null)
                            {
                                odgovor.TransferObjekat = korisnik;
                                odgovor.Signal = true;
                                
                            }
                            else
                            {
                                odgovor.TransferObjekat = korisnik;
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        case Operacija.UbaciClana:
                            try
                            {
                                if (Kontroler.UbaciClana(zahtev.TransferObjekat as Clan))
                                {
                                    odgovor.Signal = true;
                                }
                                else
                                {
                                    odgovor.Signal = false;
                                }

                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.Message);
                            }
                            formater.Serialize(tok, odgovor);
                            break;
                        case Operacija.VratiProstore:
                            try
                            {
                                List<IOOpstiDomenskiObjekat> prostori = Kontroler.VratiProstore();
                                odgovor.TransferObjekat = prostori;
                                odgovor.Signal = true;
                            }
                            catch (Exception)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);

                            break;

                        case Operacija.VratiTipoveKurseva:
                            try
                            {
                                List<IOOpstiDomenskiObjekat> tipovi = Kontroler.VratiTipove();
                                odgovor.TransferObjekat = tipovi;
                                odgovor.Signal = true;
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.Message);
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);

                            break;
                        case Operacija.UnesiKurs:
                            if (Kontroler.UnesiKurs(zahtev.TransferObjekat as Kurs))
                            {
                                odgovor.Signal = true;
                            }
                            else
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);

                            break;

                        case Operacija.VratiKurseveZaTip:

                            try
                            {
                                List<IOOpstiDomenskiObjekat> kursevi = Kontroler.VratiKurseve(zahtev.TransferObjekat as Kurs);
                                odgovor.TransferObjekat = kursevi;
                                odgovor.Signal = true;
                            }
                            catch (Exception)
                            {

                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        case Operacija.VratiClanove:
                            try
                            {
                                List<IOOpstiDomenskiObjekat> Clanovi = Kontroler.VratiClanove();
                                odgovor.TransferObjekat = Clanovi;
                                odgovor.Signal = true;
                            }
                            catch (Exception)
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);

                            break;

                        case Operacija.AzurirajKurs:
                            if (Kontroler.AzurirajKurs(zahtev.TransferObjekat as Kurs))
                            {
                                odgovor.Signal = true;
                            }
                            else
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;


                        case Operacija.ObrisiKurs:
                            if (Kontroler.ObrisiKurs(zahtev.TransferObjekat as Kurs))
                            {
                                odgovor.Signal = true;
                            }
                            else
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;


                        //case Operacija.VratiPoseteZaDatum:
                        //try
                        //{
                        //    List<IOOpstiDomenskiObjekat> posete = Kontroler.VratiPosete(zahtev.TransferObjekat as Poseta);
                        //    odgovor.TransferObjekat = posete;
                        //    odgovor.Signal = true;
                        //}
                        //catch (Exception e)
                        //{


                        //    odgovor.Signal = false;
                        //}
                        //formater.Serialize(tok, odgovor);
                        //break;

                        case Operacija.UnesiPosetu:
                            if (Kontroler.UnesiPosetu(zahtev.TransferObjekat as Clan))
                            {
                                odgovor.Signal = true;
                            }
                            else
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        case Operacija.ObrisiPosetu:
                            if (Kontroler.ObrisiPosetu(zahtev.TransferObjekat as Poseta))
                            {
                                odgovor.Signal = true;
                            }
                            else
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        case Operacija.AzurirajPosetu:
                            if (Kontroler.AzurirajPosetu(zahtev.TransferObjekat as Poseta))
                            {
                                odgovor.Signal = true;
                            }
                            else
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        case Operacija.AzururajClana:
                            if (Kontroler.AzurirajClana(zahtev.TransferObjekat as Clan))
                            {
                                odgovor.Signal = true;
                            }
                            else
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        case Operacija.ObrisiClana:

                            if (Kontroler.ObrisiClana(zahtev.TransferObjekat as Clan))
                            {
                                odgovor.Signal = true;
                            }
                            else
                            {
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;

                        case Operacija.VratiPoseteZaClana:
                            try
                            {
                                List<IOOpstiDomenskiObjekat> posete = Kontroler.VratiPosete(zahtev.TransferObjekat as Poseta);
                                odgovor.TransferObjekat = posete;
                                odgovor.Signal = true;
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.Message);
                                throw e;
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;
                        case Operacija.VratiPoseteZaMesec:
                             try
                            {
                                List<IOOpstiDomenskiObjekat> posete = Kontroler.VratiPoseteZaMesec(zahtev.TransferObjekat as Poseta);
                                odgovor.TransferObjekat = posete;
                                odgovor.Signal = true;
                            }
                          
                            catch (Exception e)
                            {
                                
                                odgovor.Signal = false;
                            }
                            formater.Serialize(tok, odgovor);
                            break;
                        case Operacija.Kraj:
                            kraj = true;
                            klijent.Shutdown(SocketShutdown.Both);

                            klijent.Close();
                            klijenti.Remove(this);
                            kraj = true; 
                            break;
                    }


                }
            }
            catch(Exception )
            {                       
                    kraj = true;
                    klijenti.Remove(this);
                    klijent.Shutdown(SocketShutdown.Both);
                    klijent.Close();                                
            }
        //    kraj = true; 
        }
    }
}
