using System;

namespace e2
{
    class Program
    {
        static void Main(string[] args)
        {
            int oyuncuSayisi = -1;

            while(oyuncuSayisi < 0 || oyuncuSayisi > 10)
            {
                Console.Write("Oyuncu sayisini giriniz: ");
                oyuncuSayisi = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

