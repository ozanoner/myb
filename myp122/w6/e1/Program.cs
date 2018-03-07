using System;


namespace e1
{
    // TEMEL SINIF
    class Sekil
    {
        public int KenarSayisi { get; set; }

        public Sekil()
        {
            this.KenarSayisi = 0;
        }

        public void SekilYazdir()
        {
            Console.WriteLine($"Sekil >> KenarSayisi: {KenarSayisi}");
        }
    }
    
    // TUREMIS SINIF
    class Ucgen: Sekil
    {
        public int Yukseklik { get; set; }
        public int Taban { get; set; }

        public Ucgen(int h, int b)
        {
            this.Yukseklik = h;
            this.Taban = b;
            this.KenarSayisi = 3;
        }

        public void UcgenYazdir()
        {
            Console.WriteLine($"Ucgen >> {Yukseklik}, {Taban}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sekil s = new Sekil();
            s.KenarSayisi = 4;
            s.SekilYazdir();
            Console.WriteLine(s.KenarSayisi);

            // Ucgen, bir Sekil dir ve ayni ozelliklere sahiptir
            Ucgen u = new Ucgen(3, 4);
            u.SekilYazdir();
            u.UcgenYazdir();
            Console.WriteLine(u.KenarSayisi);
        }
    }
}
