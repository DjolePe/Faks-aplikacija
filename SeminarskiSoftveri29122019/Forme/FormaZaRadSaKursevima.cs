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
    public partial class FormaZaRadSaKursevima : Form
    {
        Kurs kurs;
        List<TipKursa> listaTipova;
        public TipKursa tip;

        public FormaZaRadSaKursevima()
        {
            InitializeComponent();
        }

        private void FormaZaRadSaKursevima_Load(object sender, EventArgs e)
        {

            //vracamo tipove kursa
            listaTipova = new List<TipKursa>();
            //    KontrolerKI.VratiInstancu().VratiTipoveKursa(listaTipova);
         //   dgvKursevi.Columns[5].HeaderCell.Value = "Broj prisustva";

        }
        

        private void btnPrikaziDetalje_Click_1(object sender, EventArgs e)
        {

            

            try
            {
                kurs = dgvKursevi.CurrentRow.DataBoundItem as Kurs;
                DetaljiKursaForma dkf = new DetaljiKursaForma(kurs, dgvKursevi);
                dkf.ShowDialog();
            }
            catch(Exception )
            {
                MessageBox.Show("Nije izabran kurs!");
                return;
            }

            dgvKursevi.Columns[5].HeaderCell.Value = "Broj prisustva";
            dgvKursevi.Columns[4].HeaderCell.Value = "Tip kursa";
        }

        private void cmbTipoviKursa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //try
            //{
            //    KontrolerKI.VratiInstancu().PrikaziKurseve(dgvKursevi, cmbTipoviKursa);
            //}catch
            //{
            //    MessageBox.Show("Sistem ne može da pronađe kurseve");
            //}
        }

        private void btnObrisi_Click_1(object sender, EventArgs e)
        {
            try
            {
                kurs = dgvKursevi.CurrentRow.DataBoundItem as Kurs;
                KontrolerKI.VratiInstancu().ObrisiKurs(kurs, dgvKursevi);
            }
            catch (Exception )
            {
                MessageBox.Show("Sistem ne može da izbriše izabrani kurs");
            }
        }

        private void btnTipovi_Click(object sender, EventArgs e)
        {
            TipoviKursevaZaRad tkzr = new TipoviKursevaZaRad();
            tkzr.Show(this);
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {

            if(tip == null)
            {
                MessageBox.Show("Morate izabrati tip!");
                return;
            }
            try
            {

                KontrolerKI.VratiInstancu().PrikaziKurseve(dgvKursevi,tip);
            }
            catch
            {
                MessageBox.Show("Sistem ne može da pronađe kurseve");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
