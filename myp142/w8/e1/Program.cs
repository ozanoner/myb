using System;
using System.Collections.Generic;

namespace e1
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
            // Yeni kitap listesi olusturma
            List<Kitap> kitapListesi = new List<Kitap>()
            {
                new Kitap ("Aynadaki Sır","Özge Doğar",15),
                new Kitap ("Ayrılık Vakti","Jodi Picoult",20),
                new Kitap ("Ayyaş Buda","Göktuğ Canbaba",79),
                new Kitap ("Eşik Burcu: Bütün Yazıları 3","Şükrü Erbaş",96),
                new Kitap ("F","Daniel Kehlmann",97),
                new Kitap ("Fakir Kene","Birhan Keskin",16),
                new Kitap ("Ay’da 172 Saat","Jonah Harstad",33),
                new Kitap ("Batı Penceresinin Meleği","Gustav Meyrink",35),
                
            };
            kitapListesi.Bilgi();

            // Listeye yeni kitap ekleme
            kitapListesi.Add(new Kitap("Dark Net", "Jamie Bartlett", 94));
            kitapListesi.Bilgi("Liste (List<T>.Add):");

            // kitap1 silme
            var kitap1 = kitapListesi[3];
            Console.WriteLine($"\nkitap1 -> {kitap1}");
            kitapListesi.Remove(kitap1);
            kitapListesi.Bilgi("Liste (List<T>.Add):");

            // Contains ile olup olmadigini kontrol etme
            var kitap2 = new Kitap("Darmadağın", "Karin Slaughter", 84);
            Console.WriteLine($"\nkitap2 -> {kitap2}");
            Console.WriteLine(kitapListesi.Contains(kitap2)? "Var": "Yok");
            kitapListesi.Add(kitap2);
            Console.WriteLine(kitapListesi.Contains(kitap2) ? "Var" : "Yok");

            /*
            // HATA: Karsilastirma yontemi yok
            kitapListesi.Sort();
            */

            // Yazara gore siralama
            KitapYazaraGoreSirala yazaraGore = new KitapYazaraGoreSirala();
            kitapListesi.Sort(yazaraGore);
            kitapListesi.Bilgi("Liste (List<T>.Sort(yazaraGore)):");

            // Yazara gore BinarySearch ile arama yapma
            int i = kitapListesi.BinarySearch(kitap2, yazaraGore);
            Console.WriteLine($"\nINDEX: {i}, kitap2 -> {kitap2}");
        }
    }
}
