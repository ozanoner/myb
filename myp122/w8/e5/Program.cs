using System;
using System.IO;

namespace e5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaAdi = @"TestDosyasi.txt";
            if (File.Exists(dosyaAdi))
            {
                var satirlar = File.ReadLines(dosyaAdi);
                Console.WriteLine($"Dosya adi: {dosyaAdi}");
                // satirlarin tipi IEnumerable<string>
                // Lenght property bulunmaz.
                // Console.WriteLine($"Satir sayisi: {satirlar.Length}");
                Console.WriteLine($"Icerik:");
                foreach (var satir in satirlar)
                {
                    Console.WriteLine(satir);
                }
                Console.WriteLine("-- Bitti --");
            }
            else
                Console.WriteLine("Dosya bulunamadi");
        }
    }
}
