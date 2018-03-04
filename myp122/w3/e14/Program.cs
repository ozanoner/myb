using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e14
{
    class Program
    {
        static void Main(string[] args)
        {
            float tirYuksekligi;
            float maxYukseklik = 3.5f;

            while (true)
            {
                string cevap = KullaniciGirisi();
                if (cevap[0] == 'q')
                    break;

                tirYuksekligi = Convert.ToSingle(cevap);

                if (TirYuksekligiUygunMu(tirYuksekligi, maxYukseklik))
                    break;
            }
        }

        static string KullaniciGirisi()
        {
            Console.Write("TIR yuksekligini giriniz (Cikmak icin 'q'): ");
            return Console.ReadLine();
        }

        static bool TirYuksekligiUygunMu(float yukseklik, float maxDeger)
        {
            bool uygun = yukseklik <= maxDeger;
            if (uygun)
            {
                Console.WriteLine($"Uygun TIR: {yukseklik}<={maxDeger}");
            }
            else
            {
                Console.WriteLine("Gecersiz TIR yuksekligi. Yeniden deneyiniz");
            }
            return uygun;
        }
    }
}
