using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba3ParkingSluzba
{
    class Program
    {
        static void Main(string[] args)
        {
            string vozilaTxt = "1,SO 123 456,Petar,Petrovic\n" +
                "2,NS 222 333,Mitar,Mitrovic\n" +
                "3,BG 777 111,Jovan,Jovanovic\n" +
                "4,SU 444 999,Mitar,Mitra Mitar\n" +
                "5,SU 444 123,Dordje,Djordjevic";

            string parkingKarteTxt = "1,1,0699999999,2012-12-31 11:30:45,crvena\n" +
                "2,1,0699999999,2013-01-20 11:30:45,plava\n" +
                "3,1,0600000000,2014-10-10 11:30:45,bela\n" +
                "4,2,0644444444,2013-04-04 11:30:45,plava\n" +
                "5,2,0644444444,2013-04-04 12:30:45,plava";

            //PODELA STRINGA NA REDOVE TAKO STO PREKIDAMO NA SVAKOM \n
            string[] VozilaPoRedovima = vozilaTxt.Split('\n');
            Console.WriteLine("\nPODELJEN STRING PO REDOVIMA\n");
            for (int i = 0; i < VozilaPoRedovima.Length; i++)
            {
                Console.WriteLine(VozilaPoRedovima[i]);
            }
            Console.WriteLine("\nPODELA NIZA TIPA STRING NA SVAKI ZAREZ\n");
            Automobil[] vozila = new Automobil[5];
            for (int i = 0; i < VozilaPoRedovima.Length; i++)
            {
                string[] PojedinacniPodaciVozila = VozilaPoRedovima[i].Split(',');
                vozila[i] = new Automobil(int.Parse(PojedinacniPodaciVozila[0]), PojedinacniPodaciVozila[1], PojedinacniPodaciVozila[2], PojedinacniPodaciVozila[3]);
                                            //INT PARSE JER PRETVARAMO STRING U INT
            }
            //for (int i = 0; i < vozila.Length; i++)
            //{
            //    vozila[i].IspisPodatakaVozila();        //ISPIS SVIH PODATAKA ZA SVAKU OSOBU
            //}

            string[] KartePoRedovima = parkingKarteTxt.Split('\n');
            Console.WriteLine("\nPODELJEN STRING PO REDOVIMA\n");
            for (int i = 0; i < KartePoRedovima.Length; i++)
            {
                Console.WriteLine(KartePoRedovima[i]);
            }
            Console.WriteLine("\nPODELA STRINGA NA SVAKI ZAREZ");
            ParkingKarte[] Karte = new ParkingKarte[5];
            
            for (int i = 0; i < KartePoRedovima.Length; i++)
            {
                string[] PojedinacniPodaciKarata = KartePoRedovima[i].Split(',');
                Automobil vozilo = new Automobil();
                foreach(var item in vozila)         //OVAJ DEO KODA SAM PREUZEO OD KOLEGE ALEKSANDRA RAKOVICA, NISAM MOGAO DA PROVALIM KAKO DA URADIM SAM
                {
                    if (item.ID == int.Parse(PojedinacniPodaciKarata[1]))
                    {
                        vozilo = item;
                    }
                }
                Karte[i] = new ParkingKarte(int.Parse(PojedinacniPodaciKarata[0]), vozilo, PojedinacniPodaciKarata[2], DateTime.Parse(PojedinacniPodaciKarata[3]), PojedinacniPodaciKarata[4]);
            }

            //ISPIS SVIH POLJA
            Console.WriteLine("ISPIS PODATAKA");

                for (int i = 0; i < vozila.Length; i++)
                {
                    vozila[i].IspisPodatakaVozila();        //ISPIS SVIH PODATAKA ZA SVAKU OSOBU
                }
            Console.WriteLine("\n ISPIS SVIH PARKING KARTI\n");
            for (int i = 0; i <Karte.Length; i++)
            {
                Karte[i].IspisKarte();
            }


        }
    }
}
