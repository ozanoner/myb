using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    /*
     new Kitap ("Bay Mozart Uyanıyor","Eva Baronsky",73),
                new Kitap ("Bayan Ming'in Hiç Olmayan On Çocuğu","Eric Emmanuel Schmitt",58),
                new Kitap ("Cüceler","Neşe Cehiz",75),
                new Kitap ("Dalkavuk Hanım-Mahmudiye Üçlemesi III","Mahmut Şenol",63),
                new Kitap ("Dark Net","Jamie Bartlett",94),
                new Kitap ("Darmadağın","Karin Slaughter",84),
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Sirali kume tanimi
            SortedSet<Kitap> siraliKume = new SortedSet<Kitap>(new KitapSirala()) {
                new Kitap ("Eşik Burcu: Bütün Yazıları 3","Şükrü Erbaş",96),
                new Kitap ("F","Daniel Kehlmann",97),
                new Kitap ("Eşik Burcu: Bütün Yazıları 3","Ali Veli",96),
                new Kitap ("Fakir Kene","Birhan Keskin",16),
                new Kitap ("Ay’da 172 Saat","Jonah Harstad",33),
                new Kitap ("Ay’da 172 Saat","Jonah Harstad",35),
                new Kitap ("Batı Penceresinin Meleği","Gustav Meyrink",35)
            };
            siraliKume.Bilgi();

            // kume karsilastirma methodlari
            SortedSet<Kitap> kume2 = new SortedSet<Kitap>(new KitapSirala())
            {
                new Kitap ("Bay Mozart Uyanıyor","Eva Baronsky",73),
                new Kitap ("Bayan Ming'in Hiç Olmayan On Çocuğu","Eric Emmanuel Schmitt",58),
                new Kitap ("Darmadağın","Karin Slaughter",84),
                new Kitap ("Ay’da 172 Saat","Jonah Harstad",33),
                new Kitap ("Batı Penceresinin Meleği","Gustav Meyrink",35)
            };

            Console.WriteLine($"\nsiraliKume < kume2?: {siraliKume.IsSubsetOf(kume2)}");
            Console.WriteLine($"siraliKume > kume2?: {siraliKume.IsSupersetOf(kume2)}");
            Console.WriteLine($"siraliKume <ortakKume?> kume2?: {siraliKume.Overlaps(kume2)}");
            Console.WriteLine($"siraliKume <ayniKume?> kume2?: {siraliKume.SetEquals(kume2)}");

            // iki deger arasindaki degerler
            Kitap k1 = new Kitap("B", "", 0);
            Kitap k2 = new Kitap("Ez", "", 0);
            siraliKume.GetViewBetween(k1, k2).Bilgi("B ve Ez arasi kitaplar");

            // kesisim alma
            siraliKume.IntersectWith(kume2);
            siraliKume.Bilgi("Kesisimden sonra:");

            // birlesim alma
            siraliKume.UnionWith(kume2);
            siraliKume.Bilgi("Kesisimden sonra birlesim:");

            // min, max ve karsilastirici
            Console.WriteLine($"\nMin: {siraliKume.Min}");
            Console.WriteLine($"Max: {siraliKume.Max}");

            var karsilastirici = siraliKume.Comparer;
            Console.WriteLine($"\nMin-Max karsilastirma sonucu: " +
                $"{karsilastirici.Compare(siraliKume.Min, siraliKume.Max)}");

        }
    }
}
