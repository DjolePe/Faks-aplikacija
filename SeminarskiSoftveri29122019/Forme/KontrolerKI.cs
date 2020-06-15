using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
   public class KontrolerKI
    {
        Korisnik korisnik;
        List<Ucionica> listaProstora;
        List<TipKursa> listaTipova;
        BindingList<Kurs> listaKurseva;

        List<Clan> ListaClanova;
     

        public  Clan clan; 



        private static KontrolerKI instance;

        public static KontrolerKI VratiInstancu()
        {
            if (instance == null)
            {
                instance = new KontrolerKI();
            }
            return instance;

        }

        internal List<Poseta> VratiPoseteZaMesec(DateTime mesec)
        {
            Poseta p = new Poseta();
            p.Datum = mesec;
            List<Poseta> lista = new List<Poseta>();
           lista = Komunikacija.dajInstancu().VratiPoseteZaMesec(p);
            return lista;
        }

        private TipKursa tipKursa;

        public TipKursa TipKursa
        {
            get { return tipKursa; }
            set { tipKursa = value; }
        }

        internal void IzmeniClana(Clan c)
        {
            if (Komunikacija.dajInstancu().AzurirajClana(c))
            {
                MessageBox.Show("Sistem je uspešno izmenio clana");

            }
            else
            {
                MessageBox.Show("Sistem ne može da izmeni člana");

            }
        }

        //Slanje zahteva komunikaciji za izmenu posete

        internal void IzmeniPosetu(Poseta p)
        {
            if (Komunikacija.dajInstancu().AzurirajPosetu(p))
          {
               MessageBox.Show("Sistem je uspešno izmenio prisustvo");
                
            }
           else
            {
                MessageBox.Show("Sistem ne može da izmeni prisustvo");

           }
        }


        //Dodavanje posete u listu
        //internal List<Poseta> DodajPosetu(Kurs cmbKurs1, DateTimePicker dtpDatum, Clan clan)
        //{
            

        //    Poseta poseta = new Poseta
        //    {
        //        Clan = clan,
        //        Datum = dtpDatum.Value,
        //        Kurs = cmbKurs1,
        //        BrojPosete = 0 

        //    };

        //    clan.ListaPoseta.Add(poseta);
        //    return 

        //}

        internal bool ZapamtiPosete(Clan c)
        {
            if (Komunikacija.dajInstancu().DodajPosetu(c))
            {
                
               
                MessageBox.Show("Sistem je uspešno zapamtio prisustva");
                return true;

            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti nova prisustva");
                return false;
            }
        }

        internal void IzaberiClana(DataGridView dgvPosete, ComboBox cmbClan)
        {
            clan = cmbClan.SelectedItem as Clan;
            dgvPosete.DataSource = clan.ListaPoseta;
        }



        internal void VratiPoseteZaClana(Clan cmbClan, DateTimePicker dtpDatum,Kurs kurs, DataGridView dgvPosete)
        {
            clan = cmbClan;
            
            Poseta p = new Poseta();
            p.Clan = clan;
            p.Datum = dtpDatum.Value;
            p.Kurs = kurs;
          //  dgvPosete.DataSource = null;
          
            if (Komunikacija.dajInstancu().VratiPoseteZaClana(p) != null)
            {
               if(clan != null) clan.ListaPoseta.Clear();
               if(kurs != null) kurs.ListaPoseta.Clear();
                BindingList<Poseta> listaPoseta = new BindingList<Poseta>();
                foreach(Poseta p1 in Komunikacija.dajInstancu().VratiPoseteZaClana(p))
                {
                    listaPoseta.Add(p1);
                }

              
                foreach (Poseta po in listaPoseta)
                {
                    if (clan != null)
                    {
                        if (kurs != null)
                        {
                            if (po.Kurs.Naziv == kurs.Naziv)
                            {
                                clan.ListaPoseta.Add(po);

                            }
                        }
                        else clan.ListaPoseta.Add(po);
                       
                        dgvPosete.DataSource = clan.ListaPoseta;
                    }
                    if (clan == null)
                    {
                         if(kurs != null)
                        {
                            kurs.ListaPoseta.Add(po);
                            dgvPosete.DataSource = kurs.ListaPoseta;
                        }
                      
                    }

                }

                if (clan != null)
                {
                    if (clan.ListaPoseta.Count > 0)
                        MessageBox.Show("Sistem je uspešno pronašao prisustva");
                    if (clan.ListaPoseta.Count == 0)
                        MessageBox.Show("Sistem je neuspešno pronašao prisustva");
                }
                if (kurs != null)
                {
                    if (kurs.ListaPoseta.Count > 0)
                        MessageBox.Show("Sistem je uspešno pronašao prisustva");
                    if (kurs.ListaPoseta.Count == 0)
                        MessageBox.Show("Sistem je neuspešno pronašao prisustva");
                }

            }

            
         
          

        }

        internal void Logout()
        {
            Komunikacija.dajInstancu().Logout();
            

        }


        //Slanje zahteva komunikaciji za brisanje posete iz baze

        internal void ObrisiPosetu(DataGridView dgvPosete)
        {
            try
            {
                Poseta poseta = dgvPosete.CurrentRow.DataBoundItem as Poseta;
                if (Komunikacija.dajInstancu().ObrisiPosetu(poseta))
                {
                    MessageBox.Show("Sistem je uspešno obrisao prisustvo");
                    clan.ListaPoseta.Remove(poseta);
                    dgvPosete.Refresh();
                }
                else
                {
                    MessageBox.Show("Sistem ne može da izbriše prisustvo");

                }
            }
            catch(Exception )
            {
                MessageBox.Show("Morate izabrati prisustvo");
                return;
            }
        }






        //Slanje zahteva komunikaciji za prikaz kurseva za odredjeni tip za posete
        public BindingList<Kurs> PrikaziKurseveZaPosete(TipKursa cmbTipKursa)
        {
            Kurs kurs = new Kurs();
            kurs.TipKursa = cmbTipKursa;
            listaKurseva = new BindingList<Kurs>(Komunikacija.dajInstancu().VratiKurseve(kurs));

            return listaKurseva;
        }




        //Slanje zahteva komunikaciji za brisanje kursa iz baze
        internal void ObrisiKurs(Kurs kurs, DataGridView dgvKursevi)
        {
            if (Komunikacija.dajInstancu().ObrisiKurs(kurs))
            {
                MessageBox.Show("Sistem je uspešno obrisao kurs");
                listaKurseva.Remove(kurs);
                dgvKursevi.Refresh();
            }
            else
            {
                MessageBox.Show("Sistem ne može da izbriše izabrani kurs");

            }
        }




        //Slanje zahteva komunikaciji za prikaz clanova
        internal BindingList<Clan> VratiClanove()
        {
            BindingList<Clan> konacnaLista = new BindingList<Clan>();
            ListaClanova = new List<Clan>(Komunikacija.dajInstancu().VratiClanove());
            foreach(Clan c in ListaClanova)
            {
                konacnaLista.Add(c);
            }
            return konacnaLista;
        }


        //Prikaz poseta 
        //internal void VratiPoseteZaDatum(DataGridView dgvPosete, DateTimePicker datum, ComboBox cmbClan)
        //{

        //    Poseta p = new Poseta();


        //    p.Datum = datum.Value;



        //    listaPosetaZaDatum = new BindingList<Poseta>(Komunikacija.dajInstancu().PrikaziPosete(p));
        //    dgvPosete.DataSource = listaPosetaZaDatum;


        //}


        //Slanje zahteva komunikaciji za izmenu kursa
        internal void AzurirajKurs(Kurs kurs, DataGridView dgvKursevi)
        {
            if (Komunikacija.dajInstancu().AzurirajKurs(kurs))
            {
                MessageBox.Show("Sistem je uspesno izmenio kurs");
                dgvKursevi.Refresh();
            }
            else
            {
                MessageBox.Show("Sistem ne može da izmeni kurs");
                
            }
        }




        //Povezivanje sa serverom
        internal bool PoveziSe()
        {
            try
            {
                Komunikacija.dajInstancu().KonektujSe();
                MessageBox.Show("Uspesno povezan!");
   //           Komunikacija.dajInstancu().OsluskujOdgovore(this);          
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }




        //Slanje zahteva komunikaciji za prikaz kurseva za odredjeni tip
        public void PrikaziKurseve(DataGridView tabela, TipKursa tip)
        {
            Kurs kurs = new Kurs();
            kurs.TipKursa = tip;
            listaKurseva = new BindingList<Kurs>(Komunikacija.dajInstancu().VratiKurseve(kurs));
            tabela.DataSource = listaKurseva;

        }

        //Slanje zahteva komunikaciji za unos kursa
        internal void ZapamtiKurs(Kurs kurs)
        {
            if (Komunikacija.dajInstancu().UbaciKurs(kurs))
            {
                MessageBox.Show("Kurs je uspešno zapamćen");

            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti kurs");
            }
        }



        //Slanje zahteva komunikaciji za tipove
        public List<TipKursa> VratiTipoveKursa()
        {
            listaTipova = new List<TipKursa>(Komunikacija.dajInstancu().VratiTipove());
            return listaTipova;
        }




        //Slanje zahteva komunikaciji za prostore
        public List<Ucionica> VratiProstore()
        {
            listaProstora = new List<Ucionica>(Komunikacija.dajInstancu().VratiListuProstora());
            return listaProstora;
        }




        private KontrolerKI()
        {
        }


        //Login korisnika
        public bool Login()
        {
            Login l = new Login();
            l.ShowDialog();
            if (l.DialogResult == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //slanje zahteva komunikaciji za prijavu
        internal bool PrijaviSe(TextBox txtKorisnickoIme, TextBox txtSifra)
        {
            korisnik = Komunikacija.dajInstancu().PrijaviSe(txtKorisnickoIme.Text, txtSifra.Text);
            if (korisnik != null)
            {
                return true;

            }
            else
            {

                return false;

            }
        }

        //slanje zahteva komunikaciji za ubacivanje novog clana
        internal bool UbaciClana(Clan clan)
        {
            if (Komunikacija.dajInstancu().UbaciClana(clan))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        internal void ObrisiClana(DataGridView dgvClanovi, BindingList<Clan> lista)
        {
            try
            {
                Clan clan = dgvClanovi.CurrentRow.DataBoundItem as Clan;
                if (Komunikacija.dajInstancu().ObrisiClana(clan))
                {
                    MessageBox.Show("Sistem je uspešno obrisao clana");
                    lista.Remove(clan);
                    dgvClanovi.Refresh();
                }
                else
                {
                    MessageBox.Show("Sistem ne može da izbriše clana");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Morate izabrati člana");
                return;
            }
        }
    }
}
