using System;

namespace e2
{
    class Kitap
    {
        // SINIF icin ortak yeniNo alani
        private static int yeniNo = 0;

        // Nesne degiskenleri
        private int kitapNo;
        private string kitapAdi;

        // Yapici method
        public Kitap(string adi)
        {
            this.kitapAdi = adi;
            this.kitapNo = ++Kitap.yeniNo;
        }

        public string KitapString()
        {
            return $"Kitap: {kitapNo}, {kitapAdi}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap1 = new Kitap("Fareli Koyun Kavalcisi");
            Console.WriteLine(kitap1.KitapString());

            Kitap kitap2 = new Kitap("Pinokyo");
            Console.WriteLine(kitap2.KitapString());

            Kitap kitap3 = new Kitap("80 Gunde DevriAlem");
            Console.WriteLine(kitap3.KitapString());
        }
    }
}
