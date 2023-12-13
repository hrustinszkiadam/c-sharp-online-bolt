using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolt{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Termek osztály tesztelése:
            // 1. Termék létrehozása és adatainak kiírása:
            Termek kenyer = new Termek(1, "Kenyér", 200, 100);
            Termek tej = new Termek(2, "Tej", 300, 50);
            Termek sajt = new Termek(3, "Sajt", 500, 20);
            Termek sonka = new Termek(4, "Sonka", 600, 10);

            kenyer.TermekAdatainakKiirasa();
            tej.TermekAdatainakKiirasa();
            sajt.TermekAdatainakKiirasa();
            sonka.TermekAdatainakKiirasa();
            Console.WriteLine("\n");

            // 2. Raktárfrissítés és rendelés:

            kenyer.RaktarFrissites(50);
            tej.RaktarFrissites(20);
            sajt.RaktarFrissites(10);
            sonka.RaktarFrissites(5);

            kenyer.TermekRendelese(10);
            kenyer.TermekAdatainakKiirasa();
            Console.WriteLine("\n");
            #endregion

            #region Kosar osztály tesztelése:
            // 1. Termék hozzáadása és törlése a kosárból:
            Kosar kosar = new Kosar();
            kosar.TermekHozzaadasa(kenyer);
            kosar.TermekHozzaadasa(tej);
            kosar.TermekHozzaadasa(sajt);
            kosar.TermekHozzaadasa(sonka);

            kosar.TermekTorlese(kenyer);
            kosar.TermekTorlese(tej);

            // 2. Kosár összértékének ellenőrzése:
            kosar.KosarAra();
            Console.WriteLine("\n");
            #endregion

            #region Felhasznalo osztály tesztelése:
            // 1. Felhasználó létrehozása és profiladatainak megjelenítése:
            Felhasznalo kissBela = new Felhasznalo(1, "Kiss Béla", "kissbela@gmail.com");
            Felhasznalo nagyIstvan = new Felhasznalo(2, "Nagy István", "nagyistvan@gmail.com");
            Felhasznalo szaboLaszlo = new Felhasznalo(3, "Szabó László", "szabolaszlo@gmail.com");

            kissBela.ProfilAdatainakKiirasa();
            nagyIstvan.ProfilAdatainakKiirasa();
            szaboLaszlo.ProfilAdatainakKiirasa();
            Console.WriteLine("\n");

            #region Rendelés tesztelése:
            FizetesiMod kartya = new FizetesiMod(1, "Bankkártya", "Bankkártyás fizetés");
            Rendeles rendeles1 = new Rendeles(1, kissBela, new List<Termek> { kenyer, tej }, kartya);
            Rendeles rendeles1_2 = new Rendeles(1, kissBela, new List<Termek> { sonka, sajt }, kartya);
            Rendeles rendeles2 = new Rendeles(2, nagyIstvan, new List<Termek> { sajt, sonka }, kartya);
            Rendeles rendeles3 = new Rendeles(3, szaboLaszlo, new List<Termek> { kenyer, tej, sajt, sonka }, kartya);

            rendeles1.RendelesAdatainakKiirasa();
            rendeles1_2.RendelesAdatainakKiirasa();
            rendeles2.RendelesAdatainakKiirasa();
            rendeles3.RendelesAdatainakKiirasa();
            Console.WriteLine("\n");

            rendeles1.RendelestElvegzett();
            rendeles1_2.RendelestElvegzett();
            rendeles2.RendelestElvegzett();
            rendeles3.RendelestElvegzett();

            rendeles1.RendelesOsszegzes();
            rendeles1_2.RendelesOsszegzes();
            rendeles2.RendelesOsszegzes();
            rendeles3.RendelesOsszegzes();
            Console.WriteLine("\n");

            #endregion

            // 2. Felhasználó rendeléseinek ellenőrzése:
            kissBela.RendeleseimListazasa();
            nagyIstvan.RendeleseimListazasa();
            szaboLaszlo.RendeleseimListazasa();
            Console.WriteLine("\n");
            #endregion

            #region FizetesiMod osztály tesztelése:
            // 1. Fizetési módok kezelése:
            FizetesiMod keszpenz = new FizetesiMod(2, "Készpénz", "Készpénzes fizetés");
            FizetesiMod utalas = new FizetesiMod(3, "Banki átutalás", "Banki átutalással történő fizetés");
            FizetesiMod utanvet = new FizetesiMod(4, "Utánvét", "Utánvéttel történő fizetés");

            keszpenz.FizetesiModAdatainakKiirasa();
            utalas.FizetesiModAdatainakKiirasa();
            utanvet.FizetesiModAdatainakKiirasa();
            Console.WriteLine("\n");

            keszpenz.FizetesiModValasztas();
            Console.WriteLine("\n");

            keszpenz.FizetesiModTorlese();
            utalas.FizetesiModTorlese();
            Console.WriteLine("\n");

            keszpenz.FizetesiModLetrehozas();

            #endregion
            
            Console.ReadKey();
        }
    }
}