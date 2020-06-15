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
    public partial class FormaZaIzmenuPosete : Form
    {
        Poseta p;
        public FormaZaIzmenuPosete(Poseta p)
        {
            InitializeComponent();
            this.p = p; 
        }

        private void FormaZaIzmenuPosete_Load(object sender, EventArgs e)
        {
            txtClan.Text = p.Clan.Ime + " " + p.Clan.Prezime;
            txtKurs.Text = p.Kurs.Naziv;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            p.Datum = dtpDatum.Value;
            KontrolerKI.VratiInstancu().IzmeniPosetu(p);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
