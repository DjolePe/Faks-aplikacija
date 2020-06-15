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
    public partial class ProstorForma : Form
    {
        List<Ucionica> lista;

        public ProstorForma()
        {
            InitializeComponent();
        }

        private void ProstorForma_Load(object sender, EventArgs e)
        {
            lista = KontrolerKI.VratiInstancu().VratiProstore();
            dgvProstori.DataSource = lista;

            dgvProstori.Columns[0].HeaderCell.Value = "Sifra";
            dgvProstori.Columns[1].HeaderCell.Value = "Naziv prostora";
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
           Ucionica prostor = dgvProstori.CurrentRow.DataBoundItem as Ucionica;
            UnosNovogKursa uns = (UnosNovogKursa)this.Owner;
            uns.txtProstor.Text = prostor.Naziv;
            uns.prostor = prostor;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
