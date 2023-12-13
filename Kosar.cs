using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolt {
   class Kosar {
      public List<Termek> Termekek { get; set; }

      public Kosar() {
         Termekek = new List<Termek>();
      }

      public void TermekHozzaadasa(Termek termek) {
         Termekek.Add(termek);
      }

      public void TermekTorlese(Termek termek) {
         Termekek.Remove(termek);
      }

      public void KosarUritese() {
         Termekek.Clear();
      }

      public void KosarTartalma() {
         foreach (Termek termek in Termekek) {
            Console.WriteLine(termek.Nev);
         }
      }

      public int KosarAra() {
         return Termekek.Sum(termek => termek.Ar);
      }

      public void TermekMennyisegKiiras(Termek termek) {
         int mennyiseg = Termekek.Count(_termek => _termek.Nev == termek.Nev);
         Console.WriteLine($"A(z) {termek.Nev} termékből {mennyiseg}db van a kosárban.");
      }

      public void TermekMennyisegNovel(Termek termek, int mennyiseg) {
         for(int i = 0; i < mennyiseg; i++) {
            TermekHozzaadasa(termek);
         }
      }

      public void TermekMennyisegCsokken(Termek termek, int mennyiseg) {
         for(int i = 0; i < mennyiseg; i++) {
            TermekTorlese(termek);
         }
      }
   }
}