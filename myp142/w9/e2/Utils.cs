using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    static class Utils
    {
        // extension method
        internal static void Bilgi<T1, T2>(this Dictionary<T1, T2> sozluk, 
            string baslik = "Sozluk:")
        {
            Console.WriteLine($"\n{baslik}");
            Console.WriteLine($"Count: {sozluk.Count}");
            foreach (var k in sozluk)
            {
                Console.WriteLine($"Key: {k.Key},\tValue: {k.Value}");
            }
        }
    }
}
