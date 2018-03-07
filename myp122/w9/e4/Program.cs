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
            try
            {
                int i = 10;
                int j;
                // out anahtar kelimesi
                while(!SayiOku(out j))
                {
                    Console.WriteLine("Gecerli sayi giriniz");
                }
                Console.WriteLine($"Sonuc={i/j}");
            }
            catch (Exception e)
            {
                Log(e);
                KullaniciBildirimi(e);
                throw;
            }
        }

        private static bool SayiOku(out int j)
        {
            bool gecerli = false;
            j = 0;
            try
            {
                Console.Write("0'dan farkli bir sayi giriniz:");
                j = Convert.ToInt32(Console.ReadLine());
                gecerli = j != 0;
            }
            catch(FormatException)
            {
                KullaniciBildirimi("Sayi formati hatasi");
            }
            catch(OverflowException)
            {
                KullaniciBildirimi("Cok buyuk veya kucuk sayi hatasi");
            }
            return gecerli;
        }

        private static void KullaniciBildirimi(Exception e)
        {
            Console.WriteLine($"Onemli HATA: ({e.Message})");
        }
        private static void KullaniciBildirimi(string mesaj)
        {
            Console.WriteLine(mesaj);
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
