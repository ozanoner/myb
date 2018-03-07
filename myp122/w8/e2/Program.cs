using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 3;
            var sayi2 = sayi1;
            Console.WriteLine(sayi2);

            string[] isimler = new string[3] {"ali", "ayse", "fatma" };
            var isim = isimler[1];
            Console.WriteLine(isim);
        }
    }
}
