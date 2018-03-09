using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1
{
    class Kedi
    {
        public string Adi { get; set; }
        public override string ToString()
        {
            return this.Adi;
        }
    }
    class Fare
    {
        public string Adi { get; set; }
        public override string ToString()
        {
            return this.Adi;
        }
    }


    class Program
    {
        /* Generic method
         * Farkli iki tip yer degistiremez
         * T tipinde 2 deger degisebilir 
         */
        static void YerDegistir<T>(ref T o1, ref T o2)
        {
            T gecici = o1;
            o1 = o2;
            o2 = gecici;
        }
        static void Main(string[] args)
        {
            Kedi k1 = new Kedi() { Adi = "Garfield" };
            Kedi k2 = new Kedi() { Adi = "Tom" };
            YerDegistir<Kedi>(ref k1, ref k2);
            Console.WriteLine($"{k1} {k2}");

            Fare f1 = new Fare() { Adi = "Mickey" };
            Fare f2 = new Fare() { Adi = "Jerry" };
            YerDegistir<Fare>(ref f1, ref f2);
            Console.WriteLine($"{f1} {f2}");
        }
    }
}
