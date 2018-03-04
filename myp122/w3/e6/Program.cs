using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e6
{
    class Program
    {
        static void Main(string[] args)
        {
            // j degerlerini baslik olarak yazdir
            for (int j = 1; j <= 5; j++)
            {
                Console.Write($"\t({j})");
            }
            Console.WriteLine();

            // carpim tablosu
            for (int i = 1; i <= 5; ++i)
            {
                // i degeri satir basligi olarak
                Console.Write($"({i}):\t");
                for (int j = 1; j <= 5; ++j)
                {
                    Console.Write($"{i*j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
