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
    public partial class TipoviKursevaZaRad : Form
    {
        List<TipKursa> lista;
        string filter;
        public TipoviKursevaZaRad()
        {
            InitializeComponent();
        }

        private void TipoviKursevaZaRad_Load(object sender, EventArgs e)
        {
            lista = KontrolerKI.VratiInstancu().VratiTipoveKursa();
            dgvTipovi.DataSource = lista;

            dgvTipovi.Columns[0].HeaderCell.Value = "Sifra";
            dgvTipovi.Columns[1].HeaderCell.Value = "Naziv tipa";
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            TipKursa tip = dgvTipovi.CurrentRow.DataBoundItem as TipKursa;
           FormaZaRadSaKursevima uns = (FormaZaRadSaKursevima)this.Owner;
            uns.txtTipKursa.Text = tip.NazivTipa;
            uns.tip = tip;
            this.Close();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
