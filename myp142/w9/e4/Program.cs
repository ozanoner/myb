using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e4
{
    class Program
    {
        static void Main(string[] args)
        {
            // sozluge Add ile yeni kayitlar ekleme
            Dictionary<string, Profil> kullanicilar = new Dictionary<string, Profil>();
            kullanicilar.Add("ali", new Profil() { Adi = "Ali", Soyadi = "Zipzip", Yasi = 20 });
            kullanicilar.Add("hasan", new Profil() { Adi = "K.Hasan", Soyadi = "Sonmez", Yasi = 25 });
            kullanicilar.Add("ayse", new Profil() { Adi = "Ayse", Soyadi = "Korkmaz", Yasi = 22 });
            kullanicilar.Add("fatih", new Profil() { Adi = "Fatih", Soyadi = "Donmez", Yasi = 18 });
            kullanicilar.Add("kahraman", new Profil() { Adi = "Kahraman", Soyadi = "Deli", Yasi = 23 });

            // Yasi 20den buyukleri secme (Where methodu)
            // Func<T,T_Return> -> T parametresi alir T_Return doner
            // Where methodu, bool donen bir Func alir
            var buyukler = kullanicilar.Values.Where(
                p => p.Yasi > 20
                );

            Console.WriteLine("foreach dongusu ile listeleme:");
            foreach (var p in buyukler)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nForEach methodu + lambda ile listeleme:");
            buyukler.ToList().ForEach(
                p1 => Console.WriteLine(p1)
                );

        }
    }
}
