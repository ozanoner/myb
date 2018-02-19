using System;

namespace e1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kitap sinifindan yeni nesne
            // k bir referans
            Kitap k = new Kitap();
            k.Adi = "The C# Player's Guide";
            k.Yazari = "RB Whitaker";

            Console.WriteLine(k);
        }
    }

    // Soyutlama
    // Sinif tanimi
    // her sinif varsayilan olarak object sinifindan turer
    class Kitap
    {
        // property = ozellik
        public string Adi { get; set; }
        public string Yazari { get; set; }

        public override string ToString()
        {
            // string interpolation
            return $"Kitap adi: {Adi}\nYazari: {Yazari}\n";
        }
    }
}
