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
    public partial class IzvestajForma : Form
    {
        List<Poseta> lista;
        DateTime mesec;

        public IzvestajForma(DateTime mesec, List<Poseta> lista)
        {
            InitializeComponent();
            this.mesec = mesec;
            this.lista = lista;
        }

        private void IzvestajForma_Load(object sender, EventArgs e)
        {
          
            int broj;
            PosetaBindingSource.DataSource = lista;


            broj = lista.Count;

            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("Mesec", mesec.ToShortDateString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Iznos", mesec.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("BrojKurseva", broj.ToString())
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
