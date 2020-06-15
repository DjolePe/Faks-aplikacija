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
    public partial class UnosClanaForma : Form
    {
        Clan clan = new Clan();
        public UnosClanaForma()
        {
            InitializeComponent();
        }

      

        private void UnosClanaForma_Load_1(object sender, EventArgs e)
        {
            
        }

        private void btnUnos_Click_1(object sender, EventArgs e)
        {
            
            //Dodeljujemo vrednosti novom clanu
            clan.Ime = txtIme.Text;
            clan.Prezime = txtPrezime.Text;
            clan.Mobilni = Convert.ToString(txtMobilni.Text);
            clan.EMail = txtEmail.Text;

            if(clan.Ime == null || clan.Ime == "")
            {
                MessageBox.Show("Morate uneti ime clana!");
                return;
            }
            if(clan.Ime.Any(char.IsDigit))
            {
                MessageBox.Show("Ime ne sme sadrzati brojeve!");
                return; 
            }

            //char[] nizKaraktera = clan.Ime.ToCharArray();
            //foreach(char c in nizKaraktera)
            //{
            //    if(!Char.IsLetterOrDigit(c))
            //    {
            //        MessageBox.Show("Ime člana mora biti samo naziv!");
            //        return;
            //    }
            //}

            if (clan.Ime.Any(char.IsDigit))
            {
                MessageBox.Show("Ime ne sme sadržati brojeve!");
                return;
            }


            if (clan.Prezime == null || clan.Prezime == "")
            {
                MessageBox.Show("Morate uneti prezime člana!");
                return;
            }
            if (clan.Prezime.Any(char.IsDigit))
            {
                MessageBox.Show("Prezime ne sme sadržati brojeve!");
                return;
            }

            //char[] nizKaraktera1 = clan.Prezime.ToCharArray();
            //foreach (char c in nizKaraktera1)
            //{
            //    if (!Char.IsLetterOrDigit(c))
            //    {
            //        MessageBox.Show("Prezime mora biti samo naziv!");
            //        return;
            //    }
            //}

            if (clan.Mobilni == null || clan.Mobilni == "" )
            {
                MessageBox.Show("Morate uneti mobilni člana! ");
                return;
            }

            if(!clan.Mobilni.All(char.IsDigit))
            {
                MessageBox.Show("Mobilni sadrži samo brojeve!");
                return;
            }

            if (clan.EMail == null || clan.EMail == "")
            {
                MessageBox.Show("Morate uneti email člana!");
                return;
            }
            if(!clan.EMail.Contains('@') || !clan.EMail.EndsWith(".com"))
            {
                MessageBox.Show("Neispravna email adresa!");
                    return;
            }


            if (KontrolerKI.VratiInstancu().UbaciClana(clan))
            {
                MessageBox.Show("Sistem je uspešno zapamtio člana");
                
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti člana");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
