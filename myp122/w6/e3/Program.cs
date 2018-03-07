using System;


namespace e3
{
    // TEMEL SINIF
    class Sekil
    {
        /* Protected SET oldugundan sinif hiyerarsisi disindan
         * degistirmek mumkun degil,
         * ama turemis siniflardan degistirilebilir
         */
        public int KenarSayisi { get; protected set; }

        public Sekil(int kenarsayisi)
        {
            this.KenarSayisi = kenarsayisi;
            Console.WriteLine("bilgi: Sekil yapici");
        }

        // Disardan erisilmez, sadece turemis siniflardan
        protected void SekilYazdir()
        {
            Console.WriteLine($"Sekil >> KenarSayisi: {KenarSayisi}");
        }
    }

    // TUREMIS SINIF
    class Ucgen : Sekil
    {
        public int Yukseklik { get; set; }
        public int Taban { get; set; }

        public Ucgen(int h, int b) : base(3)
        {
            this.Yukseklik = h;
            this.Taban = b;
            this.KenarSayisi = 3; // MUMKUN, protected SET
            Console.WriteLine("bilgi: Ucgen yapici");
        }

        public void UcgenYazdir()
        {
            this.SekilYazdir(); // MUMKUN!! protected
            Console.WriteLine($"Ucgen >> {Yukseklik}, {Taban}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sekil s = new Sekil(4);
            // s.SekilYazdir(); // HATA!! protected 
            Console.WriteLine(s.KenarSayisi); // public GET

            // Ucgen, bir Sekil dir ve ayni ozelliklere sahiptir
            Ucgen u = new Ucgen(3, 4);
            // u.SekilYazdir(); // HATA!! protected
            u.UcgenYazdir();
            Console.WriteLine(u.KenarSayisi);
        }
    }
}
