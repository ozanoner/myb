using System;

namespace e3
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

        public static int SiradakiYeniNo()
        {
            // ONEMLI: sadece SINIF DEGISKENLERI kullanilabilir
            return Kitap.yeniNo + 1;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine($"Siradaki yeni no: {Kitap.SiradakiYeniNo()}");
            Kitap kitap1 = new Kitap("Fareli Koyun Kavalcisi");
            Console.WriteLine(kitap1.KitapString());

            Console.WriteLine($"Siradaki yeni no: {Kitap.SiradakiYeniNo()}");
            Kitap kitap2 = new Kitap("Pinokyo");
            Console.WriteLine(kitap2.KitapString());
        }
    }
}
