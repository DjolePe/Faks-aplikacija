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
    public partial class IzmenaClana : Form
    {
        Clan c;
        public IzmenaClana(Clan c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void IzmenaClana_Load(object sender, EventArgs e)
        {
            txtIme.Text = c.Ime;
            txtPrezime.Text = c.Prezime;
            txtMobilni.Text = c.Mobilni;
            txtEmail.Text = c.EMail;
        }

        private void btnIzmena_Click(object sender, EventArgs e)
        {
            try
            {


              

                c.Ime = txtIme.Text;
                c.Prezime = txtPrezime.Text;
                c.Mobilni = txtMobilni.Text;
                c.EMail = txtEmail.Text;



                if (c.Ime == null || c.Ime == "")
            {
                MessageBox.Show("Morate uneti ime clana!");
                return;
            }

                char[] nizKaraktera = c.Ime.ToCharArray();
                foreach (char c in nizKaraktera)
                {
                    if (!Char.IsLetterOrDigit(c))
                    {
                        MessageBox.Show("Ime člana mora biti samo naziv!");
                        return;
                    }
                }

                if (c.Ime.Any(char.IsDigit))
                {
                    MessageBox.Show("Ime ne sme sadržati brojeve!");
                    return;
                }



                if (c.Prezime == null || c.Prezime == "")
            {
                MessageBox.Show("Morate uneti prezime člana!");
                return;
            }

                char[] nizKaraktera1 = c.Prezime.ToCharArray();
                foreach (char c in nizKaraktera1)
                {
                    if (!Char.IsLetterOrDigit(c))
                    {
                        MessageBox.Show("Prezime člana mora biti samo naziv!");
                        return;
                    }
                }

                if (c.Prezime.Any(char.IsDigit))
                {
                    MessageBox.Show("Ime ne sme sadržati brojeve!");
                    return;
                }
                if (c.Mobilni == null || c.Mobilni == "" )
            {
                MessageBox.Show("Morate uneti mobilni člana! ");
                return;
            }

            if(!c.Mobilni.All(char.IsDigit))
            {
                    MessageBox.Show("Mobilni sadrži samo brojeve!");
                        return;            
            }



            if (c.EMail == null || c.EMail == "")
            {
                MessageBox.Show("Morate uneti email člana!");
                return;
            }
            if(!c.EMail.Contains('@') || !c.EMail.EndsWith(".com"))
            {
                MessageBox.Show("Neispravna email adresa!");
                    return;
            }

              
                KontrolerKI.VratiInstancu().IzmeniClana(c);
              

            }
            catch(Exception)
            {
                MessageBox.Show("Morate izabrati člana!");
                return;
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
           
            
            this.Close();
        }
    }
}
