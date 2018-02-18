using System;

namespace e11
{
    class Program
    {
        static void Main(string[] args)
        {
            // degisken tanimi
            string ogrenciAdi = "Ali Osman";
            int ogrenciYasi = 11;
            Console.WriteLine("Ogrencinin adi: " + ogrenciAdi + " Ogrencinin yasi: " + ogrenciYasi);
            // STRING INTERPOLATION ile ekrana yazdirma
            Console.WriteLine($"Ogrencinin adi: {ogrenciAdi} Ogrencinin yasi: {ogrenciYasi}");
        }
    }
}
