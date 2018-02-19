using System;

namespace e3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap k = new Kitap
            {
                Adi = "The C# Player's Guide",
                Yazari = "RB Whitaker"
            };
            Console.WriteLine(k);

            Dergi d = new Dergi
            {
                Adi = "Bilim ve Teknik",
                Yazari = "TUBITAK"
            };
            Console.WriteLine(d);
        }
    }

    class Kitap
    {
        // yeniNo alani Kitap sinifina ozel
        private static int yeniNo = 0;
        public Kitap()
        {
            this.No = ++Kitap.yeniNo;
        }
        public string Adi { get; set; }
        public string Yazari { get; set; }
        // set-No methodu Kitap sinifina ozel.
        // Sadece Kitap nesnesi set yapabilir
        public int No { get; private set; }
        // set-KutuphaneAdi methodu Kitap sinifindan tureyenler
        // tarafindan kullanilabilir
        public string KutuphaneAdi { get; protected set; }
        public override string ToString()
        {
            return $"Kitap No: {No}\nKitap adi: {Adi}\nYazari:" +
                $" {Yazari}\nKutuphane: {KutuphaneAdi}\n";
        }
    }

    // Kitap tan tureyen Dergi sinifi
    class Dergi: Kitap
    {
        public Dergi()
        {
            // set-Kutuphane methodu erisimi
            this.KutuphaneAdi = "Ufuk Univ.";
        }
    }
}
