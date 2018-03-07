using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e4
{
    class Kisi
    {
        public string Adi { get; set; }
        public int TCNo { get; set; }
        public override string ToString()
        {
            return $"Kisi: {Adi}";
        }
        public override bool Equals(object obj)
        {
            Kisi kisi = obj as Kisi;
            if (kisi == null)
                return false;
            return kisi.TCNo == this.TCNo;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k = new Kisi() { Adi = "Fatma", TCNo = 123 };
            Kisi k2 = new Kisi() { Adi = "Aslan", TCNo = 123 };

            Console.WriteLine($"Kisiler ayni mi? ({k}, {k2}): {k.Equals(k2)}");
            Console.WriteLine($"Kisi referanslari ayni mi? ({k}, {k2}): {k==k2}");

            k = k2;
            Console.WriteLine($"Kisi referanslari ayni mi? ({k}, {k2}): {k==k2}");
        }
    }
}
