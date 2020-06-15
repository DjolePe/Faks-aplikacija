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
    public partial class ManipulacijaSaClanovima : Form
    {
        BindingList<Clan> lista;
        BindingList<Clan> konacnaListaClanova;
        public ManipulacijaSaClanovima()
        {
            InitializeComponent();
        }

        private void PretraziClanove()
        {
            lista = KontrolerKI.VratiInstancu().VratiClanove();
            BindingList<Clan> ListaClanova = new BindingList<Clan>();


            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string mobilni = txtMobilni.Text;
            string email = txtEmail.Text;

            bool sadrzi;

            if (txtEmail.Text == "" && txtIme.Text == "" && txtMobilni.Text == "" && txtPrezime.Text == "")
            {
                konacnaListaClanova = lista;
                dgvClanovi.DataSource = lista;
            }
            else
            {

                //provera da li postoji clan sa imenom zadatim u pretrazi
                if (txtIme.Text != "" && txtPrezime.Text == "" && txtMobilni.Text == "" && txtEmail.Text == "")
                {
                    foreach (Clan clan in lista)
                    {
                        if (sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                            ListaClanova.Add(clan);
                    }
                }

                //provera da li postoji clan sa prezimenom zadatim u pretrazi
                else if (txtPrezime.Text != "" && txtIme.Text == "" && txtMobilni.Text == "" && txtEmail.Text == "")
                {
                    foreach (Clan clan in lista)
                    {
                        if (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            ListaClanova.Add(clan);
                    }
                }

                //provera da li postoji clan sa mobilnim zadatim u pretrazi
                else if (txtMobilni.Text != "" && txtEmail.Text == "" && txtIme.Text == "" && txtPrezime.Text == "")
                {
                    foreach (Clan clan in lista)
                    {
                        if (sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                            ListaClanova.Add(clan);
                    }
                }

                //provera da li postoji clan sa emailom zadatim u pretrazi
                else if (txtEmail.Text != "" && txtMobilni.Text == "" && txtIme.Text == "" && txtPrezime.Text == "")
                {

                    foreach (Clan clan in lista)
                    {
                        if (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0)
                            ListaClanova.Add(clan);
                    }
                }

                //provera za izabrano ime i prezime

                else if (txtEmail.Text == "" && txtMobilni.Text == "" && txtIme.Text != "" && txtPrezime.Text != "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }

                //provera za ime i mejl
                else if (txtEmail.Text != "" && txtMobilni.Text == "" && txtIme.Text != "" && txtPrezime.Text == "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }


                //provera za ime i mobilni
                else if (txtEmail.Text == "" && txtMobilni.Text != "" && txtIme.Text != "" && txtPrezime.Text == "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }

                //provera za prezime i mobilni
                else if (txtEmail.Text == "" && txtMobilni.Text != "" && txtIme.Text == "" && txtPrezime.Text != "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }

                //provera za prezime i mejl 
                else if (txtEmail.Text != "" && txtMobilni.Text == "" && txtIme.Text == "" && txtPrezime.Text != "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }

                //provera za mobilni i mejl
                else if (txtEmail.Text != "" && txtMobilni.Text != "" && txtIme.Text == "" && txtPrezime.Text == "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }

                //provera za ime, prezime, i mejl
                else if (txtEmail.Text != "" && txtMobilni.Text == "" && txtIme.Text != "" && txtPrezime.Text != "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            && (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0))
                            ListaClanova.Add(clan);
                    }
                }

                //provera za ime, prezime, i mobilni
                else if (txtEmail.Text == "" && txtMobilni.Text != "" && txtIme.Text != "" && txtPrezime.Text != "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            && (sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0))
                            ListaClanova.Add(clan);
                    }
                }

                //provera za ime, mejl i mobilni
                else if (txtEmail.Text != "" && txtMobilni.Text != "" && txtIme.Text != "" && txtPrezime.Text == "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Ime.IndexOf(ime, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                            && (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0))
                            ListaClanova.Add(clan);
                    }
                }

                //provera za prezime, mejl i mobilni
                else if (txtEmail.Text != "" && txtMobilni.Text != "" && txtIme.Text != "" && txtPrezime.Text == "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            && (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0))
                            ListaClanova.Add(clan);
                    }
                }


                //provera za sve
                else if (txtEmail.Text != "" && txtMobilni.Text != "" && txtIme.Text != "" && txtPrezime.Text != "")
                {

                    foreach (Clan clan in lista)
                    {
                        if ((sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                           && (sadrzi = clan.Prezime.IndexOf(prezime, StringComparison.OrdinalIgnoreCase) >= 0)
                            && (sadrzi = clan.EMail.IndexOf(email, StringComparison.OrdinalIgnoreCase) >= 0)
                             && (sadrzi = clan.Mobilni.IndexOf(mobilni, StringComparison.OrdinalIgnoreCase) >= 0)
                            )
                            ListaClanova.Add(clan);
                    }
                }

                konacnaListaClanova = ListaClanova;

                dgvClanovi.DataSource = konacnaListaClanova;       
                
               

            }



            //Menjanje naziva kolona
            dgvClanovi.Columns[0].HeaderCell.Value = "Sifra";
            dgvClanovi.Columns[3].HeaderCell.Value = "Prezime";
            if (dgvClanovi.Columns.Count > 0)
                dgvClanovi.Columns.RemoveAt(5);
        }


        private void btnPretraga_Click(object sender, EventArgs e)
        {
           PretraziClanove();
      //      Timer timer = new Timer();
      //      timer.Interval = (6 * 1000);
     //       timer.Tick += new EventHandler(timer_Tick);
      //      timer.Start();
        }

     //   private void timer_Tick(object sender, EventArgs e)
     //   {
       //     PretraziClanove();
       // }

            

        private void btnIzmena_Click(object sender, EventArgs e)
        {
            try
            {
                Clan clan = dgvClanovi.CurrentRow.DataBoundItem as Clan;

                IzmenaClana forma = new IzmenaClana(clan);
                forma.ShowDialog();
                dgvClanovi.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Morate izabrati clana!");
                return;
            }

        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            try
            {
                KontrolerKI.VratiInstancu().ObrisiClana(dgvClanovi, konacnaListaClanova);
            }
            catch (Exception)
            {
                MessageBox.Show("Morate izabrati clana!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManipulacijaSaClanovima_Load(object sender, EventArgs e)
        {
           
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if(dgvClanovi.DataSource == null)
            {
                MessageBox.Show("Morate učitati članove");
                return;
            }

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "PoseteClanova";

            for (int i = 1; i < dgvClanovi.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvClanovi.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvClanovi.Rows.Count - 1; i++)

            {
                for (int j = 0; j < dgvClanovi.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvClanovi.Rows[i].Cells[j].Value.ToString();
                }
            }

           

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "output";
            saveFileDialog.DefaultExt = ".xlsx";
            try
            {
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
                    MessageBox.Show("Uspešno eksportovani clanovi!");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            app.Quit();
        }
    }
}
