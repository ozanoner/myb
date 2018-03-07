using System;

namespace e7
{
    class Ucgen
    {
        // Automatic Property
        // salt okunur
        public int Yukseklik { get; private set; }
        public int Taban { get; private set; }

        // salt okunur property'ler 
        // yapici icinde SET ediliyor.
        public Ucgen(int h, int b)
        {
            this.Yukseklik = h < 1 ? 1 : h;
            this.Taban = b < 1 ? 1 : b;
        }

        public float Alan()
        {
            return (float)this.Yukseklik * this.Taban / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen u1 = new Ucgen(3, 5);
            Console.WriteLine($"{u1.Yukseklik}, {u1.Taban}, {u1.Alan()}");
        }
    }
}
