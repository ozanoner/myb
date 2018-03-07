using System;

namespace e1
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
            // dikdortgen Alan() methodunu kullanma
            Console.WriteLine(birDikdortgen.Alan());
        }
    }
}


