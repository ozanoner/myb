using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e3
{
    class Kisi
    {
        public string Adi { get; set; }
        public override string ToString()
        {
            return $"Kisi: {Adi}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k = new Kisi() { Adi = "Fatma" };
            Console.WriteLine(k);
        }
    }
}
