using Domen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broker
{
    public class BrokerBaze
    {
        OleDbConnection konekcija;
        OleDbCommand komanda;
        OleDbTransaction transakcija;

        private static BrokerBaze instanca;

        public bool Obrisi(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                
               string upit = $" delete from  {odo.vratiImeTabele()}  where {odo.VratiUslovDva()} ";
                OleDbCommand komanda3 = new OleDbCommand(upit, konekcija, transakcija);
                komanda3.CommandType = CommandType.Text;
                komanda3.ExecuteNonQuery();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        public bool Obrisi2(IOOpstiDomenskiObjekat odo)
        {
            try
            {

                string upit = $" delete from  {odo.vratiImeTabele2()}  where {odo.VratiUslovJedan()} ";
                OleDbCommand komanda3 = new OleDbCommand(upit, konekcija, transakcija);
                komanda3.CommandType = CommandType.Text;
                komanda3.ExecuteNonQuery();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool ObrisiPomocna(IOOpstiDomenskiObjekat o)
        {
            try
            {

                string upit = $" delete from  {o.vratiImeTabele3()}  where {o.vratKluc2()} ";
                OleDbCommand komanda3 = new OleDbCommand(upit, konekcija, transakcija);
                komanda3.CommandType = CommandType.Text;
                komanda3.ExecuteNonQuery();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public List<IOOpstiDomenskiObjekat> VratiSveZaUslovJedan(IOOpstiDomenskiObjekat odo)
        {

           string upit = $"Select * from {odo.vratiImeTabele()} where {odo.VratiUslovJedan()}";
            OleDbCommand komanda3 = new OleDbCommand(upit, konekcija, transakcija);
            komanda3.CommandType = CommandType.Text;
            OleDbDataReader citac3 = komanda3.ExecuteReader();
            return odo.VratiListu(citac3);


        }
        

        public List<IOOpstiDomenskiObjekat> VratiSveZaUslovDva(IOOpstiDomenskiObjekat odo)
        {

            string upit = $"Select * from {odo.vratiImeTabele2()} where {odo.VratiUslov3()}";
            OleDbCommand komanda2 = new OleDbCommand(upit, konekcija, transakcija);
            komanda2.CommandType = CommandType.Text;
            OleDbDataReader citac1 = komanda2.ExecuteReader();
            return odo.VratiListu(citac1);
        }

        public bool Azuriraj(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = $" update  {odo.vratiImeTabele()} set {odo.vratiAzuriranje()} where {odo.VratiUslovDva()} ";
                komanda.CommandType = CommandType.Text;
                komanda.ExecuteNonQuery();
               
                return true;
              

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool Azuriraj2(IOOpstiDomenskiObjekat o)
        {
            try
            {
                komanda.CommandText = $" update  {o.vratiImeTabele3()} set {o.vratiAzuriranje2()}  where {o.vratKluc2()} ";
                komanda.CommandType = CommandType.Text;
                komanda.ExecuteNonQuery();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }



        public static BrokerBaze DajInstancu()
        {
            if (instanca == null)
            {
                instanca = new BrokerBaze();
            }
            return instanca;
        }

        public int VratiSifru(IOOpstiDomenskiObjekat odo)
        {
            komanda.CommandText = "SELECT MAX(" + odo.vratiKljuc() + ")  FROM " + odo.vratiImeTabeleZaKljuc();
            komanda.CommandType = CommandType.Text;
            try
            {
                int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                return sifra + 1;
            }
            catch (Exception )
            {
                return 1;
            }

        }

        public int Ubaci(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = $"Insert into {odo.vratiImeTabele()} Values ({odo.vratiInsert()})";
                komanda.CommandType = CommandType.Text;
                int rezultat = komanda.ExecuteNonQuery();
                return rezultat;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }

        }

        public int Ubaci2(IOOpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = $"Insert into {odo.vratiImeTabele3()} Values ({odo.vratiInsert3()})";
                komanda.CommandType = CommandType.Text;
                int rezultat = komanda.ExecuteNonQuery();
                return rezultat;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }

        }


        //Ostavljeno zbog testa
        //public int UbaciOsobu(Osoba o)
        //{
        //    try
        //    {
        //        komanda.CommandText = $"Insert into Osoba(Ime, Prezime, Sifra, Mobilni) Values ('{o.Ime}','{o.Prezime}',{o.Sifra},'{o.Mobilni}')";
        //        komanda.CommandType = CommandType.Text;
        //        int rezultat = komanda.ExecuteNonQuery();
        //        return rezultat;

        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}


        public List<IOOpstiDomenskiObjekat> VratiSve(IOOpstiDomenskiObjekat odo)
        {
            komanda.CommandText = $"Select * from {odo.vratiImeTabele()}";
            komanda.CommandType = CommandType.Text;
            OleDbDataReader citac = komanda.ExecuteReader();
            return odo.VratiListu(citac);
        }


        public List<IOOpstiDomenskiObjekat> VratiSve2(IOOpstiDomenskiObjekat odo)
        {
            komanda.CommandText = $"Select {odo.VratiKriterijum()} from {odo.vratiImeTabele2()}";
            komanda.CommandType = CommandType.Text;
            OleDbDataReader citac = komanda.ExecuteReader();
            return odo.VratiListu(citac);
        }
        
        //Ostavljeno zbog testa
        //public List<IOOpstiDomenskiObjekat> VratiSveOsobe(IOOpstiDomenskiObjekat odo)
        //{
        //    komanda.CommandText = $"Select  c.SifraClana, o.Ime, o.Prezime,c.Email, o.Mobilni from Osoba o join Clan c on o.Sifra = c.SifraClana";
        //    komanda.CommandType = CommandType.Text;
        //    OleDbDataReader citac = komanda.ExecuteReader();
        //    return odo.VratiListu(citac);
        //}





        BrokerBaze()
        {
            konekcija = new OleDbConnection(@"Provider = SQLOLEDB; Data Source=DESKTOP-2N7NHC4\DJORDJESERVER;Initial Catalog=LocalDatabase; Integrated Security = SSPI");
            komanda = konekcija.CreateCommand();
        }

        public void Commit()
        {
            transakcija.Commit();
        }

        public void Rollback()
        {
            transakcija.Rollback();
        }

        public void OtvoriKonekciju()
        {
            konekcija.Close();
            konekcija.Open();
        }

        public void ZatvoriKonekciju()
        {
            konekcija.Close();
        }
        public void PokreniTransakciju()
        {
            transakcija = konekcija.BeginTransaction();
            komanda.Transaction = transakcija;
        }
    }
}
