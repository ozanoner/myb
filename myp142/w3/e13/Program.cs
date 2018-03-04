using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e13
{
    class Program
    {
        static void Main(string[] args)
        {
            // dersler ve notlar icin 2 boyutlu dizi
            // satirlar dersler icin sutunlar her ders icin notlar
            int[,] notlar = new int[3, 3]
            {
                { 23, 54, 78 },
                { 67, 89, 54 },
                { 74, 83, 77 }
            };

            for (int satir = 0; satir < 3; satir++)
            {
                Console.Write($"Ders {satir+1} notlar: ");
                for (int sutun = 0; sutun < 3; sutun++)
                {
                    Console.Write($"{notlar[satir,sutun]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
