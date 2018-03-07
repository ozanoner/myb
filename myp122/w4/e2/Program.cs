using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    // SOYUTLAMA: Dikdortgen sinifi tanimi
    class Dikdortgen
    {
        // Nesne degiskenleri tanimlari
        public int en;
        public int boy;

        // Dikdortgen Alan methodu tanimi
        public int Alan()
        {
            return en * boy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Siniftan bir nesne olusturma
            Dikdortgen birDikdortgen = new Dikdortgen();
            // nesnenin degiskenlerine deger atama
            birDikdortgen.en = 2;
            birDikdortgen.boy = 3;
            Console.WriteLine("birDikdortgen nesnesi:");
            Console.WriteLine($"en: {birDikdortgen.en}");
            Console.WriteLine($"boy: {birDikdortgen.boy}");
            Console.WriteLine($"alan: {birDikdortgen.Alan()}");
         
            // Dikdortgen sinifindan baska bir degisken
            Dikdortgen baskaDikdortgen = new Dikdortgen();
            // nesnenin kendine ait degiskenlerine deger verme
            baskaDikdortgen.en = 12;
            baskaDikdortgen.boy = 4;
            Console.WriteLine("baskaDikdortgen nesnesi:");
            Console.WriteLine($"en: {baskaDikdortgen.en}");
            Console.WriteLine($"boy: {baskaDikdortgen.boy}");
            Console.WriteLine($"alan: {baskaDikdortgen.Alan()}");
        }
    }
}


