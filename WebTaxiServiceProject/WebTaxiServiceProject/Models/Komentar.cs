﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebTaxiServiceProject.Models.Enums;

namespace WebTaxiServiceProject.Models
{
    public class Komentar
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public DateTime DatumObjave { get; set; }
        public int Korisnik { get; set; }
        public Uloga KorisnikUloga { get; set; }
        public string Voznja { get; set; }
        public int Ocena { get; set; }

        public Komentar() { Ocena = 0; Korisnik = -1; }
        public Komentar(int id, string o, DateTime d, int k, Uloga u, string v, int oc)
        {
            Id = id;
            Opis = o;
            DatumObjave = d;
            Korisnik = k;
            KorisnikUloga = u;
            Voznja = v;
            Ocena = oc;
        }
    }
}