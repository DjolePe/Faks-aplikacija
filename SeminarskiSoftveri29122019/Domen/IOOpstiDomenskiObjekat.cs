using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    
   public interface IOOpstiDomenskiObjekat
    {
        string vratiImeTabele();

        string vratiImeTabele3();

        string VratiUslovDva();

        string VratiRezultate();

        string vratiKljuc();

        string vratKluc2();
        string vratiInsert();
        List<IOOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac);

        string VratiUslovJedan();

        string vratiInsert2();

        string vratiImeTabele2();


        string vratiImeTabeleZaKljuc();

        string VratiUslov3();

        string VratiKriterijum();
        string vratiAzuriranje();

        string vratiAzuriranje2();

        string vratiInsert3();

    }
}
