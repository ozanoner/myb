using System;


namespace e4
{
    class Ucgen
    {
        public int h;
        public int b;
        public Ucgen(int h, int b)
        {
            this.h = h;
            this.b = b;
        }
        public float Alan()
        {
            return (float)h * b / 2;
        }
    }

    class Dikdortgen
    {
        public int e;
        public int b;
        public Dikdortgen(int e, int b)
        {
            this.e = e;
            this.b = b;
        }
        public int Alan()
        {
            return e * b;
        }
    }

    // STATIC SINIF, sadece statik methodu olur
    static class AlanBilgi
    {
        public static string UcgenAlan(Ucgen u)
        {
            return $"Ucgen alan: {u.Alan()}";
        }
        public static string DikdortgenAlan(Dikdortgen d)
        {
            return $"Dikdortgen alan: {d.Alan()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen u1 = new Ucgen(3, 5);
            Console.WriteLine(AlanBilgi.UcgenAlan(u1));

            Dikdortgen d1 = new Dikdortgen(3, 5);
            Console.WriteLine(AlanBilgi.DikdortgenAlan(d1));
        }
    }
}
