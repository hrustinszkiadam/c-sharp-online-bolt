using System;

namespace bolt {
   class FizetesiMod {
      public int ID { get; set; }
      public string Megnevezes { get; set; }
      public string Leiras { get; set; }

      public FizetesiMod(int id, string megnevezes, string leiras) {
         ID = id;
         Megnevezes = megnevezes;
         Leiras = leiras;
      }

      public void FizetesiModAdatainakKiirasa() {
         Console.WriteLine($"Fizetési mód azonosítója: {ID}");
         Console.WriteLine($"Fizetési mód megnevezése: {Megnevezes}");
         Console.WriteLine($"Fizetési mód leírása: {Leiras}");
      }

      public void FizetesiModValasztas() {
         Console.WriteLine($"A választott fizetési mód: {Megnevezes}");
      }

      public void FizetesiModTorlese() {
         Console.WriteLine($"Fizetési mód törölve: {Megnevezes}");
      }

      public void FizetesiModModositasa(string ujLeiras) {
         Leiras = ujLeiras;
      }

      public void FizetesiModLetrehozas() {
         Console.WriteLine($"Fizetési mód létrehozása: {Megnevezes}");
      }
   }
}