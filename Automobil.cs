using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba3ParkingSluzba
{
    class Automobil
    {
        public int ID;
        public string Registracija;
        public string ImeVlasnika;
        public String PrezimeVlasnika;

        public Automobil()
        {
        }

        public Automobil(int id, string registracija, string imeVlasnika,string prezimeVlasnika)
        {
            this.ID = id;
            this.Registracija = registracija;
            this.ImeVlasnika = imeVlasnika;
            this.PrezimeVlasnika = prezimeVlasnika;
        }

        public void IspisPodatakaVozila()
        {
            Console.WriteLine($"Vozilo sa registracijom: {Registracija},ID: {ID}, {ImeVlasnika+" "+PrezimeVlasnika}");
        }
    }
}
