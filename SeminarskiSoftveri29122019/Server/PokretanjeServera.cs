using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class PokretanjeServera : Form
    {
        Server s = new Server();
        public PokretanjeServera()
        {
            InitializeComponent();
        }

        private void PokretanjeServera_Load(object sender, EventArgs e)
        {


        }

       

       

        private void PokretanjeServera_Load_1(object sender, EventArgs e)
        {

        }


        private void btnPokreni_Click(object sender, EventArgs e)
        {
            Thread nit = new Thread(s.PokreniServer);
            nit.Start();
            MessageBox.Show("Server je pokrenut");
            btnPokreni.Enabled = false;
            btnZaustavi.Enabled = true; 
        }


        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            s.ZaustaviServer();
            //MessageBox.Show("Server je zaustavljen");
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
        }
    }
}
