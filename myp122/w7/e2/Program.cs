using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    class Sekil
    {
        public int KenarSayisi { get; set; }

        public virtual string Bilgi()
        {
            return $"K={KenarSayisi}";
        }
    }

    class Daire : Sekil
    {
        public int Yaricap { get; set; }
        public override string Bilgi()
        {
            // base ile temel sinif methoduna erisim
            return $"Yaricap={Yaricap}, {base.Bilgi()}" ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Daire d = new Daire() { Yaricap = 3, KenarSayisi = 0 };
            Console.WriteLine(d.Bilgi());
        }
    }
}
