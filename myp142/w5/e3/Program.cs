using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intListe = new List<int>();
            intListe.AddRange(Enumerable.Range(5, 5));

            // for dongusu ile yazdirmak
            for (int i = 0; i < intListe.Count; i++)
            {
                Console.Write($"{intListe[i]} ");
            }
            Console.WriteLine();

            // iterator yontemi ile listeleme
            var iterator = intListe.GetEnumerator();
            while(iterator.MoveNext())
            {
                Console.Write($"{iterator.Current} ");
            }
            Console.WriteLine();

            // foreach dongusu ile
            foreach (int deger in intListe)
            {
                Console.Write($"{deger} ");
            }
            Console.WriteLine();
        }
    }
}
