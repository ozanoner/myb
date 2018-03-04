using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e12
{
    class Program
    {
        // notlarin toplamini bulan program
        static void Main(string[] args)
        {
            // ilk deger atamasi
            int[] notlar = new int[5]
                {23, 67, 34, 87, 90};

            int toplam = 0;

            for (int index = 0; index < notlar.Length; index++)
            {
                toplam += notlar[index];
            }

            Console.WriteLine($"toplam not: {toplam}");
        }
    }
}
