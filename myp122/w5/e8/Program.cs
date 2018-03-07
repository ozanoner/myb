using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e8
{
    class Vektor
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static Vektor operator+(Vektor v1, Vektor v2)
        {
            return new Vektor() { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vektor sonuc;
            Vektor vektor1 = new Vektor() { X = 2, Y = 4 };
            Vektor vektor2 = new Vektor() { X = 3, Y = 6 };
            sonuc = vektor1 + vektor2;

            Console.WriteLine($"Sonuc = ({sonuc.X}, {sonuc.Y})");
        }
    }
}
