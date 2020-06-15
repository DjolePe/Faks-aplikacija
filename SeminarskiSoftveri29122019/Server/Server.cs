using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class Server
    {
        private BinaryFormatter formater = new BinaryFormatter();
        Socket serverSoket;
        public List<ObradaKlijenata> klijenti = new List<ObradaKlijenata>();

        public void PokreniServer()
        {
            try { 
           
            serverSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSoket.Bind(new IPEndPoint(IPAddress.Any, 8080));

            serverSoket.Listen(5);


        
                while (true)
                {
                    Socket klijentSoket = serverSoket.Accept();
                    ObradaKlijenata ok = new ObradaKlijenata(klijentSoket, klijenti);
                    klijenti.Add(ok);
                    
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Server je zaustavljen");
            }

        }

        public void ZaustaviServer()
        {
            //foreach (Socket k in klijenti)
            //{
            //    k.Shutdown(SocketShutdown.Both);
            //    k.Close();
            //}
            if (serverSoket != null)
            {

                serverSoket.Close();
            }
        }
    }
}
