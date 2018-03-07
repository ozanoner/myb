using System;
using System.IO;

namespace e10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"exe dizini adi: {Directory.GetCurrentDirectory()}");

            Console.WriteLine("exe dizinindeki dosyalar:");
            var dosyalar = Directory.GetFiles(".");
            foreach (var dosya in dosyalar)
            {
                Console.WriteLine(dosya);
            }
            Directory.GetCurrentDirectory();
        }
    }
}
