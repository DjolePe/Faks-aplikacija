using Domen;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerPL
{
    public class Kontroler
    {
        public static Korisnik prijaviKorisnika(Korisnik k)
        {

            OpstaSistemskaOperacija login = new LoginKorisnika();
            if (login.IzvrsiSO(k))
            {
                return k;
            }
            return null;
          //  return Repozitorijum.nadjiKorisnika(k.Username, k.Password);
        }

        public static bool UbaciClana(Clan clan)
        {
            OpstaSistemskaOperacija ubaciClana = new UnosClana();
            return ubaciClana.IzvrsiSO(clan);
        }

        public static List<IOOpstiDomenskiObjekat> VratiProstore()
        {
            OpstaSistemskaOperacija vratiProstore = new VratiSveProstore();
            bool rez = vratiProstore.IzvrsiSO(new Ucionica());
            if (!rez)
            {
                throw new Exception();
            }
            return (List<IOOpstiDomenskiObjekat>)vratiProstore.Rezultat;
        }

        public static List<IOOpstiDomenskiObjekat> VratiTipove()
        {
            OpstaSistemskaOperacija vratiTipove = new PrikaziTipove();
            bool rez = vratiTipove.IzvrsiSO(new TipKursa());
            if (!rez)
            {
                throw new Exception();
            }
            return (List<IOOpstiDomenskiObjekat>)vratiTipove.Rezultat;
        }

        public static bool UnesiKurs(Kurs kurs)
        {
            OpstaSistemskaOperacija unesiKurs = new ZapamtiKurs();
            return unesiKurs.IzvrsiSO(kurs);
        }

        public static List<IOOpstiDomenskiObjekat> VratiKurseve(Kurs kurs)
        {
            OpstaSistemskaOperacija vratiKurseve = new PrikaziKurseve();
            bool rez = vratiKurseve.IzvrsiSO(kurs);
            if (!rez)
            {
                throw new Exception();
            }
            return (List<IOOpstiDomenskiObjekat>)vratiKurseve.Rezultat;
        }

        public static List<IOOpstiDomenskiObjekat> VratiClanove()
        {

            OpstaSistemskaOperacija vratiClanove = new PrikaziClanove();
            bool rez = vratiClanove.IzvrsiSO(new Clan());
            if (!rez)
            {
                throw new Exception();
            }
            return (List<IOOpstiDomenskiObjekat>)vratiClanove.Rezultat;
        }

        public static bool AzurirajKurs(Kurs kurs)
        {
            OpstaSistemskaOperacija azurirajKurs = new AzurirajKursa();
            return azurirajKurs.IzvrsiSO(kurs);
        }

        public static bool ObrisiKurs(Kurs kurs)
        {
            OpstaSistemskaOperacija brisiKurs = new ObrisiKurs();
            return brisiKurs.IzvrsiSO(kurs);
        }

        public static List<IOOpstiDomenskiObjekat> VratiPosete(Poseta poseta)
        {
            OpstaSistemskaOperacija vratiPosete = new VratiPosete();
            bool rez = vratiPosete.IzvrsiSO(poseta);
            if (!rez)
            {
                throw new Exception();
            }
            return (List<IOOpstiDomenskiObjekat>)vratiPosete.Rezultat;
        }

        public static bool UnesiPosetu(Clan clan)
        {
            OpstaSistemskaOperacija unesiPosetu = new UnosPosete();
            return unesiPosetu.IzvrsiSO(clan);
        }

        public static bool ObrisiPosetu(Poseta poseta)
        {
            OpstaSistemskaOperacija brisiPosetu = new ObrisiPosetu();
            return brisiPosetu.IzvrsiSO(poseta);
        }

        public static bool AzurirajPosetu(Poseta poseta)
        {
            OpstaSistemskaOperacija azurirajPosetu = new IzmeniPosetu();
            return azurirajPosetu.IzvrsiSO(poseta);
        }

        public static bool AzurirajClana(Clan clan)
        {
            OpstaSistemskaOperacija azurirajClana = new AzurirajClana();
            return azurirajClana.IzvrsiSO(clan);
        }

        public static bool ObrisiClana(Clan clan)
        {
            OpstaSistemskaOperacija obrisiClana = new ObrisiClana();
            return obrisiClana.IzvrsiSO(clan);
        }

        public static List<IOOpstiDomenskiObjekat> VratiPoseteZaMesec(Poseta poseta)
        {
            OpstaSistemskaOperacija vratiPosete = new VratiPoseteZaMesec();
                  bool rez = vratiPosete.IzvrsiSO(poseta);
            if (!rez)
            {
                throw new Exception();
            }
            return (List<IOOpstiDomenskiObjekat>)vratiPosete.Rezultat;
        }
    }
}
