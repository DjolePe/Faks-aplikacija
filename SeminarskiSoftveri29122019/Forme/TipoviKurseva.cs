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
    public partial class TipoviKurseva : Form
    {
        List<TipKursa> lista;
        string filter;
        

        public TipoviKurseva(string filter)
        {
            InitializeComponent();
            this.filter = filter;
        }

        private void TipoviKurseva_Load(object sender, EventArgs e)
        {
                      
         lista =  KontrolerKI.VratiInstancu().VratiTipoveKursa();               
         dgvTipovi.DataSource = lista;
            dgvTipovi.Columns[0].HeaderCell.Value = "Sifra";
            dgvTipovi.Columns[1].HeaderCell.Value = "Naziv tipa";

        }

        public void postaviVrednostZaTip(TipKursa tip)
        {

        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            TipKursa tip = dgvTipovi.CurrentRow.DataBoundItem as TipKursa;
            UnosNovogKursa uns = (UnosNovogKursa)this.Owner;
            uns.txtTipoviKursa.Text = tip.NazivTipa;
            uns.tipKursa = tip;

          
            this.Close();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
