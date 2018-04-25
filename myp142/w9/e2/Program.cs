using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    class Program
    {
        static void Main(string[] args)
        {
            // sozluge Add ile yeni kayitlar ekleme
            Dictionary<string, Profil> kullanicilar = new Dictionary<string, Profil>();
            kullanicilar.Add("ali", new Profil() { Adi = "Ali", Soyadi = "Zipzip", Yasi = 20 });
            kullanicilar.Add("hasan", new Profil() { Adi = "K.Hasan", Soyadi = "Sonmez", Yasi = 25 });
            // HATA: tekil anahtar
            // kullanicilar.Add("ali", new Profil() { Adi = "Ali", Soyadi = "Zipzip", Yasi = 20 });
            kullanicilar.Add("ayse", new Profil() { Adi = "Ayse", Soyadi = "Korkmaz", Yasi = 22 });
            kullanicilar.Add("fatih", new Profil() { Adi = "Fatih", Soyadi = "Donmez", Yasi = 18 });
            kullanicilar.Bilgi();

            // indeks yardimi ile yeni kayit olusturma
            kullanicilar["kahraman"] = new Profil()
                { Adi = "Kahraman", Soyadi = "Deli", Yasi = 23 };
            kullanicilar.Bilgi("Sozluk (indeks ile yeni kayit)");

            // index ile kayda erisim
            var profil = kullanicilar["kahraman"];
            if (profil != null)
            {
                profil.Yasi = 28;
                Console.WriteLine($"\n{profil}");
            }

            // ContainsKey ile anahtar kontrolu ve silme
            if (kullanicilar.ContainsKey("ali"))
                kullanicilar.Remove("ali");
            kullanicilar.Bilgi("Sozluk (Remove)");

            // Anahtarlari listeleme
            Console.WriteLine("\nKullanici adlari:");
            foreach (var kullanici_adi in kullanicilar.Keys)
            {
                Console.WriteLine(kullanici_adi);
            }

            // Degerleri listeleme
            Console.WriteLine("\nProfiller:");
            foreach (var p in kullanicilar.Values)
            {
                Console.WriteLine(p);
            }
        }
    }
}
