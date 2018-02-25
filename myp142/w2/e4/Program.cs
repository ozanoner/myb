using System;


namespace e4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ogrenci notu giriniz(0-100): ");
            int not = Convert.ToInt32(Console.ReadLine());

            if(not>=90)
            {
                Console.WriteLine("Harf: A");
            }
            else if (not>=60)
            {
                Console.WriteLine("Gecti");
            }
            else
            {
                Console.WriteLine("Kaldi");
            }

        }
    }
}
