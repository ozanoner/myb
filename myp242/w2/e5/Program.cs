using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e5
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokta n = new Nokta() { X = 1, Y = 2 };
            n.NoktaDegismekUzere += nDegismedenOnceCalisir;
            n.NoktaDegisti += nDegistiktenSonraCalisir;
            n.Y = 5;
        }

        private static void nDegismedenOnceCalisir(object gonderenNesne, EventArgs e)
        {
            Nokta n1 = gonderenNesne as Nokta;
            Console.WriteLine($"{n1} degismeden once");
        }
        private static void nDegistiktenSonraCalisir(object gonderenNesne, EventArgs e)
        {
            Nokta n1 = gonderenNesne as Nokta;
            Console.WriteLine($"{n1} degistikten sonra");
        }
    }
}
