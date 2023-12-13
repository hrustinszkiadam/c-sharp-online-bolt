using System;

namespace bolt {
   class Termek {
      public int ID { get; set; }
      public string Nev { get; set; }
      public int Ar { get; set; }
      public int Raktaron { get; set; }
      private readonly int alapAr;

      public Termek(int id, string nev, int ar, int raktaron) {
         ID = id;
         Nev = nev;
         Ar = ar;
         alapAr = ar;
         Raktaron = raktaron;
      }

      public void RaktarFrissites(int mennyiseg) {
         Raktaron = mennyiseg;
      }

      public void ArBeallitas(int ujAr) {
         Ar = ujAr;
      }

      public void TermekRendelese(int mennyiseg) {
         if (Raktaron >= mennyiseg) {
            Raktaron -= mennyiseg;
         }
      }

      public void TermekAdatainakKiirasa() {
         Console.WriteLine($"ID: {ID}\nNév: {Nev}\nÁr: {Ar}Ft\nRaktáron: {Raktaron}db");
      }

      public void TermekAraNovel(int szazalek) {
         Ar = (int)(Ar * (1 + szazalek / 100.0));
      }

      public void TermekAraCsokken(int szazalek) {
         Ar = (int)(Ar * (1 - szazalek / 100.0));
      }

      public void TermekAraVisszaallitas() {
         Ar = alapAr;
      }

      public void TermekAraKiiras() {
         Console.WriteLine($"A termék ára: {Ar}Ft");
      }
   }
}