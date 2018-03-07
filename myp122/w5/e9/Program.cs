using System;


namespace e9
{
    class Vektor
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static Vektor operator ++(Vektor v1)
        {
            ++v1.X;
            ++v1.Y;
            return v1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vektor vektor1 = new Vektor() { X = 3, Y = 4 };
            vektor1++;
            ++vektor1;
            Console.WriteLine($"({vektor1.X}, {vektor1.Y})");
        }
    }
}
