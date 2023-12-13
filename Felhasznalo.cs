using System;

namespace bolt {

   class Felhasznalo {
      public int ID { get; set; }
      public string Nev { get; set; }
      public string Email { get; set; }
      public Kosar Kosar { get; set; }
      public List<Rendeles> Rendelesek { get; set; }

      public Felhasznalo(int id, string nev, string email) {
         ID = id;
         Nev = nev;
         Email = email;
         Kosar = new Kosar();
         Rendelesek = new List<Rendeles>();
      }

      public void KosarTartalma() {
         Kosar.KosarTartalma();
      }

      public void RendeleseimListazasa() {
         foreach (Rendeles rendeles in Rendelesek) {
            rendeles.RendelesAdatainakKiirasa();
         }
      }

      public void EmailKuldes(string uzenet) {
         Console.WriteLine($"E-mail küldése a következő címre: {Email}");
         Console.WriteLine($"Üzenet: {uzenet}");
      }

      public void ProfilAdatainakKiirasa() {
         Console.WriteLine($"Felhasználó azonosítója: {ID}");
         Console.WriteLine($"Felhasználó neve: {Nev}");
         Console.WriteLine($"Felhasználó e-mail címe: {Email}");
      }

      public void RendelesekOsszegezes() {
         int osszeg = Rendelesek.Sum(rendeles => rendeles.RendelesOsszegzes());
         Console.WriteLine($"A felhasználó összes rendelésének értéke: {osszeg} Ft.");
      }

      public void RendelesHozzaadasa(Rendeles rendeles) {
         Rendelesek.Add(rendeles);
      }

   }
}