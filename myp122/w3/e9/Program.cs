using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e9
{
    class Program
    {
        static void Main(string[] args)
        {
            float tirYuksekligi;
            float maxYukseklik = 3.5f;

            while (true)
            {
                Console.Write("TIR yuksekligini giriniz (Cikmak icin 'q'): ");
                string cevap = Console.ReadLine();
                if (cevap[0] == 'q')
                    break;

                tirYuksekligi = Convert.ToSingle(cevap);
                if (tirYuksekligi > maxYukseklik)
                {
                    Console.WriteLine("Gecersiz TIR yuksekligi. Yeniden deneyiniz");
                    // donguye yeniden baslar.
                    continue;
                }

                Console.WriteLine($"Uygun TIR: {tirYuksekligi}<={maxYukseklik}");
            }
        }
    }
}
