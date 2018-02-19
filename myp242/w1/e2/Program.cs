using System;

namespace e2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap k = new Kitap {
                Adi = "The C# Player's Guide",
                Yazari = "RB Whitaker"
            };
            Console.WriteLine(k);
        }
    }

    class Kitap
    {
        // sinifin ortak degiskeni (static), nesneye ozel degil
        // sadece Kitap erisebilir (private), disardan erisilemez
        private static int yeniNo=0;

        // yapici fonksiyon
        public Kitap()
        {
            this.No = Kitap.yeniNo++;
        }

        public string Adi { get; set; }
        public string Yazari { get; set; }

        public int No { get; private set; }

        public override string ToString()
        {
            return $"Kitap No: {No}\nKitap adi: {Adi}\nYazari: {Yazari}\n";
        }
    }
}
