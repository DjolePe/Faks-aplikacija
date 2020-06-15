using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class PrikazClanovaZaPosete : Form
    {
        string filter;
        BindingList<Clan> lista;


        public PrikazClanovaZaPosete(string filter)
        {

            InitializeComponent();
            this.filter = filter; 
        }

        private void PrikazClanovaZaPosete_Load(object sender, EventArgs e)
        {
            //lista = KontrolerKI.VratiInstancu().VratiClanove();
            //dgvClanovi.DataSource = lista;
            //dgvClanovi.Columns[0].HeaderCell.Value = "Sifra";
            //dgvClanovi.Columns[3].HeaderCell.Value = "Email";
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            if(dgvClanovi.DataSource == null)
            {
                return;
            }
           Clan clan = dgvClanovi.CurrentRow.DataBoundItem as Clan;
            RadSaPosetamaForma rspf = (RadSaPosetamaForma)this.Owner;
            rspf.txtClanovi.Text = clan.Ime+' '+clan.Prezime;
            rspf.clan = clan;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            //Vravanje clanova
            lista = KontrolerKI.VratiInstancu().VratiClanove();
            BindingList<Clan> ListaClanova = new BindingList<Clan>();
        

            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string mobilni = txtMobilni.Text;
            string email = txtEmail.Text;

            bool sadrzi;

            if (txtEmail.Text == "" && txtIme.Text == "" && txtMobilni.Text == "" && txtPrezime.Text == "")
            {
                dgvClanovi.DataSource = lista;
            }
            else
            {
               
                //provera da li postoji clan sa imenom zadatim u pretrazi
                if(txtIme.Text != "" && txtPrezime.Text =="" && txtMobilni.Text == "" && txtEmail.Text =="")
                {
                    foreach(Clan clan in lista)
                    {
                        if (sadrzi = clan.Ime.IndexOf(ime,StringComparison.OrdinalIgnoreCase ) >= 0 )
                            ListaClanova.Add(clan);
                    }                   
                }

                //provera da li postoji clan sa prezimenom zadatim u pretrazi
               else if (txtPrezime.Text != "" && txtIme.Text == "" && txtMobilni.Text =="" && txtEmail.Text =="")
                {          
                    foreach (Clan clan in lista)
                    {
                        if (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            ListaClanova.Add(clan);
                    }
                }

                //provera da li postoji clan sa mobilnim zadatim u pretrazi
              else  if (txtMobilni.Text != "" && txtEmail.Text =="" && txtIme.Text =="" && txtPrezime.Text == "")
                {
                    foreach (Clan clan in lista)
                    {
                        if (sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                            ListaClanova.Add(clan);
                    }
                }

                //provera da li postoji clan sa emailom zadatim u pretrazi
             else   if (txtEmail.Text != "" && txtMobilni.Text =="" && txtIme.Text == "" && txtPrezime.Text == "")
                {
               
                    foreach (Clan clan in lista)
                    {
                        if (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0)
                            ListaClanova.Add(clan);
                    }
                }

                //provera za izabrano ime i prezime

              else  if (txtEmail.Text == "" && txtMobilni.Text == "" && txtIme.Text != "" && txtPrezime.Text != "")
                {
                   
                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Prezime.IndexOf(ime, StringComparison.OrdinalIgnoreCase)>= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }

                //provera za ime i mejl
              else  if (txtEmail.Text != "" && txtMobilni.Text == "" && txtIme.Text != "" && txtPrezime.Text == "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }


                //provera za ime i mobilni
               else if (txtEmail.Text == "" && txtMobilni.Text != "" && txtIme.Text != "" && txtPrezime.Text == "")
                {

                    foreach (Clan clan in lista)
                    {
                        if((sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }

                //provera za prezime i mobilni
              else  if (txtEmail.Text == "" && txtMobilni.Text != "" && txtIme.Text == "" && txtPrezime.Text != "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }

                //provera za prezime i mejl 
               else if (txtEmail.Text != "" && txtMobilni.Text == "" && txtIme.Text == "" && txtPrezime.Text != "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }

                //provera za mobilni i mejl
             else  if (txtEmail.Text != "" && txtMobilni.Text != "" && txtIme.Text == "" && txtPrezime.Text == "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }

                //provera za ime, prezime, i mejl
              else  if (txtEmail.Text != "" && txtMobilni.Text == "" && txtIme.Text != "" && txtPrezime.Text != "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            && (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0))
                            ListaClanova.Add(clan);
                    }
                }

                //provera za ime, prezime, i mobilni
             else   if (txtEmail.Text == "" && txtMobilni.Text != "" && txtIme.Text != "" && txtPrezime.Text != "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            && (sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0))
                            ListaClanova.Add(clan);
                    }
                }

                //provera za ime, mejl i mobilni
              else  if (txtEmail.Text != "" && txtMobilni.Text != "" && txtIme.Text != "" && txtPrezime.Text == "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                            && (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0))
                            ListaClanova.Add(clan);
                    }
                }

                //provera za prezime, mejl i mobilni
               else if (txtEmail.Text != "" && txtMobilni.Text != "" && txtIme.Text != "" && txtPrezime.Text == "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            && (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0))
                            ListaClanova.Add(clan);
                    }
                }


                //provera za sve
              else  if (txtEmail.Text != "" && txtMobilni.Text != "" && txtIme.Text != "" && txtPrezime.Text != "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            && (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0)
                             && (sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }


                dgvClanovi.DataSource = ListaClanova;

                if (dgvClanovi.Columns.Count > 0)
                {
                    dgvClanovi.Columns[5].Visible = false;
                }

            }



            //Menjanje naziva kolona
            dgvClanovi.Columns[0].HeaderCell.Value = "Sifra";
            dgvClanovi.Columns[3].HeaderCell.Value = "Prezime";
        }


    }
}
