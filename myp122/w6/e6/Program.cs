using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e6
{
    interface IBilgi
    {
        void Yazdir();
    }

    interface IYuzey
    {
        double Alan();
        double Cevre();
    }

    class Sekil
    {
        public int KenarSayisi { get; set; }
    }

    // Bir sinif, sadece tek bir siniftan tureyebilir
    // Ama birden cok arayuz (interface) implementasyonu
    // yapabilir
    class Daire : Sekil, IBilgi, IYuzey
    {
        public double Yaricap { get; set; }

        // IBilgi implementasyonu
        public void Yazdir()
        {
            Console.WriteLine($"Daire bilgi: R={Yaricap}, K={KenarSayisi}");
        }

        // IYuzey implementasyonu
        public double Alan()
        {
            return Math.PI * Math.Pow(this.Yaricap, 2);
        }

        public double Cevre()
        {
            return 2 * Math.PI * this.Yaricap;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // KenarSayisi, Sekil den geliyor
            Daire d = new Daire() { KenarSayisi = 0, Yaricap = 3.2 };
            // IBilgi den gelen method
            d.Yazdir();
            // IYuzeyd den gelen methodlar
            Console.WriteLine($"Yuzey bilgileri: C={d.Cevre()}, A={d.Alan()}");
        }
    }
}
