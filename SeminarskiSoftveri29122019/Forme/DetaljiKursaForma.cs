using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class DetaljiKursaForma : Form
    {

        Kurs kurs;
        DataGridView dgvKursevi;
        public DetaljiKursaForma(Kurs kurs, DataGridView dgvKursevi)
        {
            InitializeComponent();
            this.kurs = kurs;
            this.dgvKursevi = dgvKursevi;
        }

        private void DetaljiKursaForma_Load(object sender, EventArgs e)
        {

            //ucitavamo podatke kursa i punimo polja

            txtNaziv.Text = kurs.Naziv;
            txtTipKursa.Text = kurs.TipKursa.NazivTipa;
            txtProstor.Text = kurs.Prostor.Naziv;

        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            // vrsimo potrebne validacije 
           
            if (txtCena.Text == "" || txtCena.Text == null)
            {
                MessageBox.Show("Morate uneti cenu");
                return;
            }


            int errorCounter = Regex.Matches(txtCena.Text, @"[a-zA-Z]").Count;
            if (errorCounter > 0)
            {
                MessageBox.Show("Cena ne sme da sadrzi slova!");
                return;
            }


            int errorCounter1 = Regex.Matches(txtTrajanje.Text, @"[a-zA-Z]").Count;
            if (errorCounter1 > 0)
            {
                
                MessageBox.Show("Trajanje ne sme da sadrzi slova!");
                return;
            }


            char[] nizKaraktera = txtTrajanje.Text.ToCharArray();

            foreach(char c in nizKaraktera)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                  
                    MessageBox.Show("Trajanje mora biti ceo broj!");
                    return;
                }
            }



            char[] nizKaraktera2 = txtCena.Text.ToCharArray();

            foreach (char c in nizKaraktera2)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    if (c == '.')
                    {
                       break;
                    }
                    else
                    {
                        MessageBox.Show("Cena mora biti broj!");
                        return;
                    }
                }
            }




            kurs.Cena = txtCena.Text;

            if (txtTrajanje.Text == "" || txtTrajanje.Text == null)
            {
                MessageBox.Show("Morate uneti cenu");
                return;
            }

            kurs.Trajnje = Int32.Parse(txtTrajanje.Text);



            //saljemo zahtev kontroleru za izmenu podataka kursa 


            KontrolerKI.VratiInstancu().AzurirajKurs(kurs, dgvKursevi);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
