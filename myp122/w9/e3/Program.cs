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
            try
            {
                int i = 10;
                Console.Write("O'dan farkli sayi giriniz:");
                int j = Convert.ToInt32(Console.ReadLine());
                if (j == 0)
                    Console.WriteLine("Gecersiz sayi");
                else
                    Console.WriteLine($"Sonuc={i / j}");
            }
            catch(Exception e)
            {
                Log(e);
                KullaniciBildirimi(e);
                throw;
            }
        }

        private static void KullaniciBildirimi(Exception e)
        {
            Console.WriteLine($"Onemli HATA: ({e.Message})");
        }

        private static void Log(Exception e)
        {
            Console.WriteLine("Loglandi.");
            /* uygun yontemler:
             * 1- text dosyaya loglamak
             * 2- veritabanina loglamak
             * 3- programciya bildirimde bulunmak
             */
        }
    }
}
