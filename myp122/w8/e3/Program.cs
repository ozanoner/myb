using System;
using System.IO;


namespace e3
{
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaAdi = @"TestDosyasi.txt";
            if (File.Exists(dosyaAdi))
            {
                var icerik = File.ReadAllText(dosyaAdi);
                Console.WriteLine(icerik);
            }
            else
                Console.WriteLine("Dosya bulunamadi");
        }
    }
}
