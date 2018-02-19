using System;

namespace e4
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
            k.OduncVer();

            Dergi d = new Dergi
            {
                Adi = "Bilim ve Teknik",
                Yazari = "TUBITAK"
            };
            d.OduncVer();
        }
    }

    class Kitap
    {
        private static int yeniNo = 0;
        public Kitap()
        {
            this.No = ++Kitap.yeniNo;
        }
        public string Adi { get; set; }
        public string Yazari { get; set; }
        public int No { get; private set; }
        public string KutuphaneAdi { get; protected set; }
        public override string ToString()
        {
            return $"Kitap No: {No}\nKitap adi: {Adi}\nYazari:" +
                $" {Yazari}\nKutuphane: {KutuphaneAdi}\n";
        }
        // virtual method
        // tureyen siniflar yeniden tanimlayabilir
        public virtual void OduncVer()
        {
            Console.WriteLine($"Kitap odunc verildi. Kitap adi:{Adi}");
        }
    }

    // Kitap tan tureyen Dergi sinifi
    class Dergi : Kitap
    {
        public Dergi()
        {
            // set-Kutuphane methodu erisimi
            this.KutuphaneAdi = "Ufuk Univ.";
        }
        // override anahtar kelimesi ile
        // yeniden tanimlaniyor
        public override void OduncVer()
        {
            Console.WriteLine($"Dergi odunc verildi. Dergi adi:{Adi}, " +
                $"Kutuphane: {KutuphaneAdi}");
        }
    }
}
