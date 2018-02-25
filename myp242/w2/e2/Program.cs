using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = DateTime.Parse("1-1-2017");
            try
            {
                Console.Write("Okula giris tarihini giriniz (gun-ay-yil):");
                tarih = Convert.ToDateTime(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Istisna olustu: {e.GetType().Name}");
            }

            Console.WriteLine($"Tarih: {tarih.ToString("dd-MMM-yy")}");
        }
    }
}
