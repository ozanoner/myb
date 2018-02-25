using System;

namespace e1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Okula giris tarihini giriniz (gun-ay-yil):");
                DateTime tarih = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine($"Tarih: {tarih.ToString("dd-MMM-yy")}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Istisna olustu: {e.GetType().Name}, {e.Message}");
            }
            finally
            {
                Console.WriteLine("finally icinde kaynaklar kapatilir");
            }
        }
    }
}
