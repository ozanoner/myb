using System;

namespace e7
{
    class Sekil
    {
        public int KenarSayisi { get; set; }
        public override string ToString()
        {
            return $"KS={KenarSayisi}";
        }
    }

    // SEALED olmasindan dolayi Kare sinifindan baska sinif tureyemez.
    sealed class Kare : Sekil
    {
        public int KenarUzunlugu { get; set; }
        public override string ToString()
        {
            return $"KU={KenarUzunlugu}, {base.ToString()}";
        }
    }

    // HATA: Kare muhurlu
    /*
    class Dikdortgen: Kare
    {

    }
    */

    class Program
    {
        static void Main(string[] args)
        {

            Kare kare = new Kare() { KenarSayisi = 4, KenarUzunlugu = 3 };
            Console.WriteLine($"Kare bilgi: {kare}");
        }
    }
}
