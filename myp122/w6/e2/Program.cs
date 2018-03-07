using System;


namespace e2
{
    // TEMEL SINIF
    class Sekil
    {
        /* Private SET oldugundan Sekil sinifi disindan
         * degistirmek mumkun degil
         */
        public int KenarSayisi { get; private set; }

        public Sekil(int kenarsayisi)
        {
            this.KenarSayisi = kenarsayisi;
            Console.WriteLine("bilgi: Sekil yapici");
        }

        public void SekilYazdir()
        {
            Console.WriteLine($"Sekil >> KenarSayisi: {KenarSayisi}");
        }
    }

    // TUREMIS SINIF
    class Ucgen : Sekil
    {
        public int Yukseklik { get; set; }
        public int Taban { get; set; }

        /* 
         * 'base' anahtar kelimesi ile 
         * temel sinif yapici cagrilir
         */
        public Ucgen(int h, int b): base(3)
        {
            this.Yukseklik = h;
            this.Taban = b;
            // this.KenarSayisi = 3; // HATALI, private SET
            Console.WriteLine("bilgi: Ucgen yapici");
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
            Sekil s = new Sekil(4);
            s.SekilYazdir();
            Console.WriteLine(s.KenarSayisi); // public GET

            // Ucgen, bir Sekil dir ve ayni ozelliklere sahiptir
            Ucgen u = new Ucgen(3, 4);
            u.SekilYazdir();
            u.UcgenYazdir();
            Console.WriteLine(u.KenarSayisi);
        }
    }
}
