using System;

namespace e6
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokta n = new Nokta() { X = 1, Y = 2 };
            n.NoktaDegisti += nDegisti;
            n.Y = 4;
        }

        private static void nDegisti(object nesne, NoktaDegistiEventArgs e)
        {
            Nokta n1 = nesne as Nokta;
            Console.WriteLine($"({e.OncekiX},{e.OncekiY})=>({e.SonrakiX},{e.SonrakiY})");
        }
    }
}
