using System;


namespace e3
{ 
    // SOYUTLAMA: Dikdortgen sinifi tanimi
    class Dikdortgen
    {
        // YAPICI fonksiyon
        public Dikdortgen()
        {
            en = 3;
            boy = 3;
        }
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
            
            // dikdortgen Alan() methodunu kullanma
            Console.WriteLine(birDikdortgen.Alan());
        }
    }
}
