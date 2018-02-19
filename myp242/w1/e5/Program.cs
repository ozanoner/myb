using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dergi d = new Dergi
            {
                Adi = "Bilim ve Teknik",
                Yazari = "TUBITAK"
            };
            d.OduncVer();

            Dergi d2 = new Dergi
            {
                Adi = "Ufuk Bulteni",
                Yazari = "Ufuk Universitesi",
                OduncVerilirmi = false
            };
            d2.OduncVer();
        }
    }

    interface IOduncVerme
    {
        // bu interface icin asagidaki alanlar veya
        // methodlar tanimlanmak zorunda
        bool OduncVerilirmi { get; set; }
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
    class Dergi : Kitap, IOduncVerme
    {
        public Dergi()
        {
            // set-Kutuphane methodu erisimi
            this.KutuphaneAdi = "Ufuk Univ.";
            this.OduncVerilirmi = true;
        }
        // IOduncVerme interface den dolayi
        public bool OduncVerilirmi { get; set; }

        public override void OduncVer()
        {
            if (this.OduncVerilirmi)
            {
                Console.WriteLine($"Dergi odunc verildi. Dergi adi:{Adi}, " +
                    $"Kutuphane: {KutuphaneAdi}");
            }
            else
            {
                Console.WriteLine($"Dergi odunc VERILEMEZ. Dergi adi:{Adi}, " +
                 $"Kutuphane: {KutuphaneAdi}");
            }
        }
    }
}
