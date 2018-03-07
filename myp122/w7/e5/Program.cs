using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e5
{
    abstract class Sekil
    {
        public int KenarSayisi { get; set; }
        public override string ToString()
        {
            return $"KS={KenarSayisi}";
        }
    }
    class Kare : Sekil
    {
        public int KenarUzunlugu { get; set; }
        public override string ToString()
        {
            return $"KU={KenarUzunlugu}, {base.ToString()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // HATA, abstract tan nesne olusturulmaz
            // Sekil s = new Sekil(); 
            
            // Ama referans olarak kullanilabilir
            Sekil s = new Kare() { KenarSayisi = 4, KenarUzunlugu = 3 };
            Console.WriteLine(s);
        }
    }
}
