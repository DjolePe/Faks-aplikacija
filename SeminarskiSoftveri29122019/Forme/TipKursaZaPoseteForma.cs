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
    public partial class TipKursaZaPoseteForma : Form
    {
        List<TipKursa> lista;
        public TipKursaZaPoseteForma()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            TipKursa tip = dgvTipovi.CurrentRow.DataBoundItem as TipKursa;
            RadSaPosetamaForma uns = (RadSaPosetamaForma)this.Owner;
            uns.tip = tip;
            uns.txtTipovi.Text = tip.NazivTipa;

            uns.txtKursevi.Text = "";
            this.Close();
        }

        private void TipKursaZaPoseteForma_Load(object sender, EventArgs e)
        {
            lista = KontrolerKI.VratiInstancu().VratiTipoveKursa();
            dgvTipovi.DataSource = lista;
            dgvTipovi.Columns[0].HeaderCell.Value = "Sifra";
            dgvTipovi.Columns[1].HeaderCell.Value = "Naziv tipa";

        }
    }
}
