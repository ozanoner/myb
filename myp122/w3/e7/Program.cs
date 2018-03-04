using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e7
{
    class Program
    {
        static void Main(string[] args)
        {
            float tirYuksekligi;
            float maxYukseklik = 3.5f;
            do
            {
                Console.Write("TIR yuksekligini giriniz (Cikmak icin 'q'): ");
                string cevap = Console.ReadLine();

                // kullanici yukseklik yerine q yazarsa donguden cikar
                if (cevap[0] == 'q')
                    break;

                tirYuksekligi = Convert.ToSingle(cevap);
            } while (tirYuksekligi < maxYukseklik);

            Console.WriteLine("Program sonu.");
        }
    }
}
