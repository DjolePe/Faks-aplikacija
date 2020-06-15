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
    public partial class UnosNovogKursa : Form
    {
        public Kurs kurs;
   //   public List<TipKursa> listaTipova;
        private List<TipKursa> listaTipova;
        public TipKursa tipKursa;
        public Ucionica prostor;


     

        public List<TipKursa> ListaTipova
        {
            get { return listaTipova; }
            set { listaTipova = value; }
        }


        List<string> listaImenaTipova;
        public UnosNovogKursa()
        {
            InitializeComponent();
        }

        private void UnosNovogKursa_Load(object sender, EventArgs e)
        {
            //vracanje tipova kursa u combobox
     //       listaTipova = new List<TipKursa>();
            listaImenaTipova = new List<string>();
          //  KontrolerKI.VratiInstancu().VratiTipoveKursa(listaTipova);
            //foreach (TipKursa tipKursa in listaTipova)
            //{
            //    listaImenaTipova.Add(tipKursa.NazivTipa);
            //}
            //vracanje prostora u combobox
        //    KontrolerKI.VratiInstancu().VratiProstore(cmbProstori);

       
        }
    

        private void button1_Click_1(object sender, EventArgs e)
        {
            kurs = new Kurs();
            int errorCounter = 0;

            if (txtCena.Text == null || txtCena.Text == "")
            {
                MessageBox.Show("Morate uneti cenu");
                txtCena.Clear();
                return;
            }

            if (txtNaziv.Text == null || txtNaziv.Text == "")
            {
                MessageBox.Show("Morate uneti naziv");
                txtNaziv.Clear();
                return;
            }
            if (txtNaziv.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Naziv ne sme sadrzati brojeve!");
                return;
            }

            if (txtTrajanje.Text == null || txtTrajanje.Text == "")
            {
                MessageBox.Show("Morate uneti trajanje");
                txtTrajanje.Clear();
                return;
            }

            if(kurs == null)
            {
                MessageBox.Show("Morate uneti kurs!");
                return;
            }


            if ( prostor == null)
            {
                MessageBox.Show("Morate uneti učionicu!");
                return;
            }

            errorCounter = Regex.Matches(txtCena.Text, @"[a-zA-Z]").Count;
            if(errorCounter > 0)
            {
                MessageBox.Show("Cena ne sme da sadrzi slova!");
                return;
            }
            int errorCounter1;

            errorCounter1 = Regex.Matches(txtTrajanje.Text, @"[a-zA-Z]").Count;
            if (errorCounter > 0)
            {
                MessageBox.Show("Trajanje ne sme da sadrzi slova!");
                return;
            }

            char[] nizKaraktera = txtTrajanje.Text.ToCharArray();

            foreach (char c in nizKaraktera)
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

            if (txtTrajanje.Text.Count(x => Char.IsDigit(x) )>6)
            {
                MessageBox.Show("Nedozvoljeno trajanje jednog kursa!");
                return;
            }

            kurs.Cena = txtCena.Text;
            // kurs.Cena = Convert.ToDouble(txtCena.Text);
            kurs.Naziv = txtNaziv.Text;
            kurs.Prostor = prostor;
            kurs.Trajnje = Convert.ToInt32(txtTrajanje.Text);
            kurs.TipKursa = tipKursa;

            KontrolerKI.VratiInstancu().ZapamtiKurs(kurs);
            txtCena.Clear();
            txtTrajanje.Clear();
            txtNaziv.Clear();
            txtProstor.Clear();
            txtTipoviKursa.Clear();
            
        }

        private void txtTipoviKursa_TextChanged(object sender, EventArgs e)
        {
            
     
        }

        public void postaviVrednostZaTip(TipKursa tip)
        {
            tipKursa = tip;
            txtTipoviKursa.Text = tipKursa.NazivTipa;
        }

        private void btnTipoviKursa_Click(object sender, EventArgs e)
        {
            
            string filter = txtTipoviKursa.Text;
         
            TipoviKurseva tipForma = new TipoviKurseva(filter);
            tipForma.Show(this);
             

        }

        private void btnProstori_Click(object sender, EventArgs e)
        {
            ProstorForma pf = new ProstorForma();
            pf.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
