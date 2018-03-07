using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e4
{
    class Dikdortgen
    {
        // YAPICI fonksiyon - versiyon 1
        public Dikdortgen()
        {
            en = 3;
            boy = 3;
        }

        // YAPICI fonksiyon - versiyon 2
        public Dikdortgen(int en, int boy)
        {
            this.en = en;
            this.boy = boy;
        }

        // Nesne degiskenleri tanimlari
        public int en;
        public int boy;

        // Dikdortgen Alan methodu tanimi
        public int Alan()
        {
            return this.en * this.boy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Siniftan bir nesne olusturma
            Dikdortgen birDikdortgen = new Dikdortgen();
            Console.WriteLine($"birDikdortgen alan: {birDikdortgen.Alan()}");

            // Siniftan baska bir nesne olusturma
            Dikdortgen baskaDikdortgen = new Dikdortgen(2, 2);
            Console.WriteLine($"baskaDikdortgen alan: {baskaDikdortgen.Alan()}");
        }
    }
}
