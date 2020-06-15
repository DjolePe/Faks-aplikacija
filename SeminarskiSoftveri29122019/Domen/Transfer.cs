using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Transfer
    {
        public Operacija Operacija { get; set; }
        public object TransferObjekat { get; set; }
        public bool Signal { get; set; }
        public Korisnik Korisnik { get; set; }


    }
    public enum Operacija
    {
        Login,
        Kraj,
        UbaciClana,
        VratiProstore,
        VratiTipoveKurseva,
        UnesiKurs,
        VratiKurseveZaTip,
        VratiClanove,
        AzurirajKurs,
        ObrisiKurs,
        VratiPoseteZaDatum,
        VratiPoseteZaMesec,
        UnesiPosetu,
        ObrisiPosetu,
        AzurirajPosetu,
        VratiPoseteZaClana,
        AzururajClana,
        ObrisiClana
    }
}
