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
    public partial class PregledImportovanihClanovaForma : Form
    {
        public PregledImportovanihClanovaForma()
        {
            InitializeComponent();
        }

        private void PregledImportovanihClanovaForma_Load(object sender, EventArgs e)
        {

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

                dgvClanoviImport.DataSource = data;
                int counter = dgvClanoviImport.Rows.Count;


                con.Close();
                MessageBox.Show("Uspesan import fajla!");
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesan import fajla!");
                return;
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
