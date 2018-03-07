using System;


namespace e5
{
    // arayuz tanimi
    interface IBilgi
    {
        void Yazdir();
    }

    class Sekil: IBilgi
    {
        public int KenarSayisi { get; set; }

        // IBilgi arayuz implementasyonu
        public void Yazdir()
        {
            Console.WriteLine($"Sekil kenar sayisi: {KenarSayisi}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sekil sekil1 = new Sekil() { KenarSayisi = 3 };
            sekil1.Yazdir();

            IBilgi b = new Sekil() { KenarSayisi = 5 };
            b.Yazdir();

            b = sekil1;
            b.Yazdir();
        }
    }
}
