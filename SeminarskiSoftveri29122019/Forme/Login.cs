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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
            Korisnik korisnik = new Korisnik();
            korisnik.Username = txtKorisnik.Text;
            korisnik.Password = txtSifra.Text;
            if (Form1.k == null)
            {
                //Saljemo zahtev serveru da nam vrati objekat ako postoji u repozitorijumu
                if (KontrolerKI.VratiInstancu().PrijaviSe(txtKorisnik, txtSifra))
            {
                    Form1.k = new Korisnik();
                    Form1.k = korisnik;

                    this.DialogResult = DialogResult.OK;
                    MessageBoxManager.Unregister();

                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Pogrešno ime ili šifra");
                    return;
                }

          
            }
            else
            {
                MessageBox.Show("Pogrešno ime ili šifra");
                return;
            }
        }
    }
}
