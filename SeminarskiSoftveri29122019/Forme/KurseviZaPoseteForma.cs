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
    public partial class KurseviZaPoseteForma : Form
    {
        BindingList<Kurs> lista = new BindingList<Kurs>();
        List<TipKursa> listaTipova;
        public TipKursa tip = new TipKursa();
        Kurs kurs;
        public KurseviZaPoseteForma(string tip)
        {
            InitializeComponent();
            this.tip.NazivTipa = tip;
        }

        private void KurseviZaPoseteForma_Load(object sender, EventArgs e)
        {
            listaTipova = KontrolerKI.VratiInstancu().VratiTipoveKursa();

            foreach(TipKursa tip in listaTipova)
            {
                if (this.tip.NazivTipa == tip.NazivTipa)
                    this.tip = tip;
            }

            lista = KontrolerKI.VratiInstancu().PrikaziKurseveZaPosete(tip);

            dgvKursevi.DataSource = lista;
            dgvKursevi.Columns[0].HeaderCell.Value = "Sifra";
            dgvKursevi.Columns[4].HeaderCell.Value = "Tip kursa";

        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            kurs = dgvKursevi.CurrentRow.DataBoundItem as Kurs;
            RadSaPosetamaForma uns = (RadSaPosetamaForma)this.Owner;
            uns.txtKursevi.Text = kurs.Naziv;
           uns.kurs = kurs;  
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
