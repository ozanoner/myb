using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liste = new List<int>();
            liste.AddRange(Enumerable.Range(0, 10));
            int toplam = 0;
            // lambda method, lokal degiskene erisebilir
            liste.ForEach(x => { toplam += x; });
            Console.WriteLine(toplam);
        }
    }
}
