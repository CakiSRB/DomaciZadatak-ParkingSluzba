using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba3ParkingSluzba
{
    class ParkingKarte
    {
        public int IDkarte;
        public Automobil Automobil;
        public string BrojTelefona;
        public DateTime Vreme;
        public string Zona;

        public ParkingKarte(int v)
        {
        }

        public ParkingKarte( int ID, Automobil automobil, string brojTelefona, DateTime vreme, string zona)
        {
            this.IDkarte = ID;
            this.Automobil = automobil;
            this.BrojTelefona = brojTelefona;
            this.Vreme = vreme;
            this.Zona = zona;
        }
        public void IspisKarte()
        {
            Console.WriteLine($"Uplacena je karta sa broja telefona: {BrojTelefona}, za vozilo sa registracijom: {Automobil.Registracija}, dana: {Vreme} u {Zona} zoni");
        }

        
    }
}
