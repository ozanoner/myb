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
            var sayilar = Enumerable.Range(1, 10);

            // ForEach methoduna Action<T> tipi parametresi 
            // Action<T> -> T tipinde parametre alir, sonuc donmez
            sayilar.ToList().ForEach(CiftseYazdir);

            // Lambda method = yerinde method
            sayilar.ToList().ForEach(
                x => { if (x % 2 == 0) Console.WriteLine(x); }
                );
        }

        static void CiftseYazdir(int i)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}
