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
    public partial class Form1 : Form
    {
       public static Korisnik k;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!KontrolerKI.VratiInstancu().PoveziSe())
            {
                this.Close();
            }
            if (!KontrolerKI.VratiInstancu().Login())
            {
                this.Close();
            }
         
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Register();

        }       

        private void btnKrajRada_Click_1(object sender, EventArgs e)
        {

            KontrolerKI.VratiInstancu().Logout();
            this.Dispose();
        }

        private void unosClanaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UnosClanaForma us = new UnosClanaForma();
            us.ShowDialog();
        }

        private void unosNovogKursaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UnosNovogKursa unk = new UnosNovogKursa();
            unk.ShowDialog();
        }

        private void radSaPostojecimKursevimaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormaZaRadSaKursevima frk = new FormaZaRadSaKursevima();
            frk.ShowDialog();
        }

        private void radSaPosetamaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RadSaPosetamaForma rsf = new RadSaPosetamaForma();
            rsf.ShowDialog();
        }

        private void Form1_FormClosing(object sender, CancelEventArgs e)
        {
            var result = MessageBox.Show("Da li želite da izađete iz forme?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void lblPoruka_Click(object sender, EventArgs e)
        {

        }

        private void radSaClanovimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ManipulacijaSaClanovima manipulacija = new ManipulacijaSaClanovima();
            manipulacija.ShowDialog();
        }

        private void pregledImportovanihClanovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledImportovanihClanovaForma pf = new PregledImportovanihClanovaForma();
            pf.ShowDialog();
        }

        private void posetaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
