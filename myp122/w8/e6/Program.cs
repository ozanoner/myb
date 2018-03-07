using System;
using System.IO;


namespace e6
{
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaAdi = @"TestDosyasi.txt";
            string icerik = "Uzerine yazilan iceriktir";
            File.WriteAllText(dosyaAdi, icerik);

            string okunanIcerik = File.ReadAllText(dosyaAdi);
            Console.WriteLine(okunanIcerik);
        }
    }
}
