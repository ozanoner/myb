using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1
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
        /* !!! PRIVATE 
         * en ve boy nesne degiskenlerine 
         * disardan erisim mumkun degil.
         */
        private int en;
        private int boy;

        // Dikdortgen Alan methodu tanimi
        /* !!! PUBLIC
         * Disardan, bu method kullanilabilir
         */
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

            // !!! HATA, alttaki satir DERLEYICI hatasi 
            // birDikdortgen.en = 4;
            Console.WriteLine($"birDikdortgen alan: {birDikdortgen.Alan()}");
        }
    }
}
