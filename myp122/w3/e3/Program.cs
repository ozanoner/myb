using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e3
{
    class Program
    {
        static void Main(string[] args)
        {
            int oyuncuSayisi;

            do
            {
                Console.Write("Oyuncu sayisini giriniz: ");
                oyuncuSayisi = Convert.ToInt32(Console.ReadLine());
            } while (oyuncuSayisi < 0 || oyuncuSayisi > 10);
        }
    }
}
