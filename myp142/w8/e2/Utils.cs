using System;
using System.Collections.Generic;

namespace e2
{
    static class Utils
    {
        // Extension method ile List<Kitap> tipine Bilgi methodu ekleme
        internal static void Bilgi(this SortedSet<Kitap> liste, 
            string baslik = "Kume icerigi:")
        {
            Console.WriteLine($"\n{baslik}");
            foreach (var k in liste)
            {
                Console.WriteLine(k);
            }
        }
    }
}
