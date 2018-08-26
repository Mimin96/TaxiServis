using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTaxiServiceProject.Models
{
    public class Lokacija
    {
        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Adresa Adresa { get; set; }

        public Lokacija()
        {
            Adresa = new Adresa();
        }

        public Lokacija(int i, double x, double y, Adresa a) {

            Id = i;
            X = x;
            Y = y;
            Adresa = a;
        }
    }
}