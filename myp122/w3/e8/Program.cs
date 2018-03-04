using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e8
{
    class Program
    {
        static void Main(string[] args)
        {
            float tirYuksekligi;
            float maxYukseklik;

            for(tirYuksekligi =0, maxYukseklik = 3.5f; tirYuksekligi < maxYukseklik;)
            {
                Console.Write("TIR yuksekligini giriniz (Cikmak icin 'q'): ");
                string cevap = Console.ReadLine();

                // kullanici yukseklik yerine q yazarsa donguden cikar
                if (cevap[0] == 'q')
                    break;

                tirYuksekligi = Convert.ToSingle(cevap);
            }
            
            Console.WriteLine("Program sonu.");
        }
    }
}
