using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class RadSaPosetamaForma : Form
    {
       List<TipKursa> listaTipova;
       public  Clan clan;
       public  TipKursa tip;
        public Kurs kurs;
        string filename;
       
        
        public RadSaPosetamaForma()
        {
            InitializeComponent();
            
        }

        private void RadSaPosetamaForma_Load(object sender, EventArgs e)
        {
            listaTipova = new List<TipKursa>();
            //  listaTipova =  KontrolerKI.VratiInstancu().VratiTipoveKursa();
            //  KontrolerKI.VratiInstancu().VratiClanove(cmbClan);
            //KontrolerKI.VratiInstancu().IzaberiClana(dgvPosete, cmbClan);
            if (clan != null)
            {
                dgvPosete.DataSource = clan.ListaPoseta;
                dgvPosete.Columns[3].DefaultCellStyle.Format = "yyyy-dd-MM";

                dgvPosete.Columns[0].HeaderCell.Value = "Clan";
                dgvPosete.Columns[1].HeaderCell.Value = "Kurs";
                dgvPosete.Columns[2].HeaderCell.Value = "Broj posete";
            }
        }

     
        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            // DateTime datum = new DateTime();
            //   datum = dtpDatum.Value.ToString("yyyy-dd-MM");
            //  string datumS = dtpDatum.Value.ToString("yyyy-dd-MM");

            Poseta poseta = new Poseta
            {
                Clan = clan,
                Datum = dtpDatum.Value.Date,
                Kurs = kurs,
                BrojPrisustva = 0

            };

        

            if (clan == null)
            {
                MessageBox.Show("Morate izabrati clana!");
                return;
            }
            if(kurs == null)
            {
                MessageBox.Show("Morate izabrati kurs!");
                return;
            }
                clan.ListaPoseta.Add(poseta);
                dgvPosete.DataSource = clan.ListaPoseta;

          
              

                ////clan.ListaPoseta = KontrolerKI.VratiInstancu().DodajPosetu(kurs, dtpDatum, clan);
              //  kurs = null;
                //clan = null;
             //   tip = null;
            

       ;
            dgvPosete.Columns[3].DefaultCellStyle.Format = "yyyy-dd-MM";

            dgvPosete.Columns[0].HeaderCell.Value = "Clan";
            dgvPosete.Columns[1].HeaderCell.Value = "Kurs";
            dgvPosete.Columns[2].HeaderCell.Value = "Broj posete";

        }

        

        private void cmbTipKursa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
   //         KontrolerKI.VratiInstancu().PrikaziKurseveZaPosete(cmbTipKursa, cmbKurs);
        }

        private void btnObrisi_Click_1(object sender, EventArgs e)
        {
            KontrolerKI.VratiInstancu().ObrisiPosetu(dgvPosete);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Poseta p = dgvPosete.CurrentRow.DataBoundItem as Poseta;
                if (p == null)
                {
                    MessageBox.Show("Morate izabrati posetu!");
                    return;
                }
                FormaZaIzmenuPosete izmena = new FormaZaIzmenuPosete(p);
                izmena.ShowDialog();
                dgvPosete.Refresh();
            }
            catch (Exception )
            {
                MessageBox.Show("Morate izabrati prisustvo!");
                return;
          
            }
        }

        private void cmbClan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
     //       KontrolerKI.VratiInstancu().VratiPoseteZaClana(cmbClan, dtpDatum, dgvPosete);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {


            bool uspesno;
          uspesno = KontrolerKI.VratiInstancu().ZapamtiPosete(clan);
          if (uspesno == true)
           {
                PronadjiPosete();

         }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "PoseteClanova";

            for (int i = 1; i <dgvPosete.Columns.Count+1; i++)
            {
                worksheet.Cells[1,i] = dgvPosete.Columns[i - 1].HeaderText;
            }

            for(int i = 0; i< dgvPosete.Rows.Count-1; i++)

            {
                for (int j = 0; j < dgvPosete.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvPosete.Rows[i].Cells[j].Value.ToString();
                }
            }

       
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "output";
            saveFileDialog.DefaultExt = ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing);
                MessageBox.Show("Uspešno eksportovane posete");
            }
            app.Quit();
        }

        private void btnPretragaClanova_Click(object sender, EventArgs e)
        {
            string filter = txtClanovi.Text;

            PrikazClanovaZaPosete pczp = new PrikazClanovaZaPosete(filter);
            pczp.Show(this);
        }

        private void btnPretragaTipova_Click(object sender, EventArgs e)
        {
            string filter = txtTipovi.Text;
            TipKursaZaPoseteForma tkzpf = new TipKursaZaPoseteForma();
            tkzpf.Show(this);
        }

        private void btnPretragaKurseva_Click(object sender, EventArgs e)
        {
            if(tip == null)
            {
                MessageBox.Show("Morate izabrati tip!");
                return; 
            }

            string nazivTipa = txtTipovi.Text;
            KurseviZaPoseteForma kzpf = new KurseviZaPoseteForma(nazivTipa);
            kzpf.Show(this);
        }

        public void PronadjiPosete()
        {
            if(txtKursevi.Text == "" && txtClanovi.Text == "")
            {
                MessageBox.Show("Morate izabrati kurs ili člana");
                return;
            }

            KontrolerKI.VratiInstancu().VratiPoseteZaClana(clan, dtpDatum, kurs, dgvPosete);
            dgvPosete.Columns[3].DefaultCellStyle.Format = "yyyy-dd-MM";

            dgvPosete.Columns[0].HeaderCell.Value = "Clan";
            dgvPosete.Columns[1].HeaderCell.Value = "Kurs";
            dgvPosete.Columns[2].HeaderCell.Value = "Broj prisustva";
        }


        private void btnVratiPosete_Click(object sender, EventArgs e)
        {
            PronadjiPosete();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            String name = "PoseteClanova";

            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

            }
            try
            {

                String constr = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + filePath
                                 +
                                ";Extended Properties='Excel 12.0 XML;HDR=YES;IMEX=1;';";

                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);

                con.Open();

                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                DataTable data = new DataTable();
                sda.Fill(data);
                
                dgvPosete.DataSource = data;
                int counter = dgvPosete.Rows.Count;
                

                con.Close();
                MessageBox.Show("Uspesan import fajla!");
            }
            catch(Exception)
            {
                MessageBox.Show("Neuspesan import fajla!");
                return;
            }


        //     btnDodaj.Enabled = false;
        //     btnObrisi.Enabled = false;
        //     btnPretragaClanova.Enabled = false;
        //     btnPretragaKurseva.Enabled = false;
        //     btnPretragaTipova.Enabled = false;


        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            //if(dgvPosete.DataSource == null )
            //{
            //    return;
            //}
            //if(clan.ListaPoseta.Count ==0)
            //{
            //    return;
            //}
            DateTime mesec = dtpDatum.Value;
            List<Poseta> listaPoseta = new List<Poseta>();
           listaPoseta =   KontrolerKI.VratiInstancu().VratiPoseteZaMesec(mesec);

            if ( listaPoseta == null)
            {
                MessageBox.Show("Ne postoje prisustva za ovaj mesec!");            
                return;
            }
            IzvestajForma izvesta = new IzvestajForma(mesec, listaPoseta);
            izvesta.ShowDialog();
        }

        private void btnOcistiClan_Click(object sender, EventArgs e)
        {
            txtClanovi.Text = "";
            clan = null;
        }

        private void btnOcistiTip_Click(object sender, EventArgs e)
        {
            txtTipovi.Text = "";
            tip = null;
        }

        private void btnOcistiKurs_Click(object sender, EventArgs e)
        {
            txtKursevi.Text = "";
            kurs = null;
        }
    }
}
