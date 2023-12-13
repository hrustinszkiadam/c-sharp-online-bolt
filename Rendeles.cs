using System;

namespace bolt {
   class Rendeles {
      public int ID { get; set; }
      public Felhasznalo Vevo { get; set; }
      public List<Termek> RendeltTermekek { get; set; }
      public FizetesiMod FizetesiMod { get; set; }
      public DateTime RendelesIdeje { get; set; }

      public Rendeles(int id, Felhasznalo vevo, List<Termek> rendeltTermekek, FizetesiMod fizetesiMod) {
         ID = id;
         Vevo = vevo;
         RendeltTermekek = rendeltTermekek;
         FizetesiMod = fizetesiMod;
         RendelesIdeje = DateTime.Now;
      }

      public void RendeltTermekekListazasa() {
         foreach (Termek termek in RendeltTermekek) {
            Console.WriteLine(termek.Nev);
         }
      }

      public void RendelestElvegzett() {
         Vevo.RendelesHozzaadasa(this);
      }

      public void RendelesAdatainakKiirasa() {
         Console.WriteLine($"Rendelés azonosítója: {ID}");
         Console.WriteLine($"Rendelés ideje: {RendelesIdeje}");
         Console.WriteLine($"Rendelt termékek:");
         RendeltTermekekListazasa();
         Console.WriteLine($"Fizetési mód: {FizetesiMod.Megnevezes}");
      }

      public int RendelesOsszegzes() {
         int osszeg = RendeltTermekek.Sum(termek => termek.Ar);
         Console.WriteLine($"A rendelés összege: {osszeg} Ft.");
         return osszeg;
      }
   }

}