using System;
using System.Collections.Generic;

namespace e1
{
    static class Utils
    {
        // Extension method ile List<Kitap> tipine Bilgi methodu ekleme
        internal static void Bilgi(this List<Kitap> liste, 
            string baslik = "Liste icerigi:")
        {
            Console.WriteLine($"\n{baslik}");
            foreach (var k in liste)
            {
                Console.WriteLine(k);
            }
        }
    }
}
