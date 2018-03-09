using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e4
{
    class Program
    {
        static void Main(string[] args)
        {
            ZamanSayaci sayac = new ZamanSayaci();
            var dizi = TestDizisiOlustur();
            sayac.Baslat();
            DiziZiyareti(dizi);
            sayac.Durdur();
            Console.WriteLine($"\n{sayac}");
        }

        private static int[] TestDizisiOlustur()
        {
            int[] test = new int[100000];
            for (int i = 0; i < test.Length; i++)
                test[i] = i;
            return test;
        }
        private static void DiziZiyareti(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write($"\r{dizi[i]}     ");
            }
        }

        
    }
}
