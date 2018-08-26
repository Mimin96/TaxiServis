using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebTaxiServiceProject.Models.Enums;

namespace WebTaxiServiceProject.Models
{
    public class Automobil
    {
        public int Id { get; set; }
        public string Vozac { get; set; }
        public int Godiste { get; set; }
        public string Registracija { get; set; }
        public int BrojVozila { get; set; }
        public Auto TipAutomobila { get; set; }


        public Automobil(int id, string v, int g, string r, int brv, Auto a) {

            Id = id;
            Vozac = v;
            Godiste = g;
            Registracija = r;
            BrojVozila = brv;
            TipAutomobila = a;
        }
    }
}