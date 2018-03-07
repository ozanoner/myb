using System;
using System.IO;

namespace e7
{
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaAdi = @"TestDosyasi.txt";
            string icerik = "Sonuna eklenen iceriktir\n";
            File.AppendAllText(dosyaAdi, icerik);

            string okunanIcerik = File.ReadAllText(dosyaAdi);
            Console.WriteLine(okunanIcerik);
        }
    }
}
