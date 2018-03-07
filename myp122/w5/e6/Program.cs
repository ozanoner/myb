using System;


namespace e6
{
    class Ucgen
    {
        // yukseklik icin nesne alani
        private int h;
        // PROPERTY tanimi
        // h nesne degiskenine erisimi kontrol ediyor
        public int Yukseklik
        {
            get { return this.h; }
            set
            {
                if (value < 1)
                    this.h = 1;
                else
                    this.h = value;
            }
        }

        // taban tanimi
        private int b;
        public int Taban
        {
            get { return b; }
            set { b = value < 1 ? 1 : value; }
        }

        public float Alan()
        {
            return (float)h * b / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen u1 = new Ucgen();
            u1.Yukseklik = -2;
            u1.Taban = 3;
            Console.WriteLine($"{u1.Yukseklik}, {u1.Taban}, {u1.Alan()}");

            // property ilk deger atama
            Ucgen u2 = new Ucgen() { Taban = -1, Yukseklik = -2 };
            Console.WriteLine($"{u2.Yukseklik}, {u2.Taban}, {u2.Alan()}");
        }
    }
}
