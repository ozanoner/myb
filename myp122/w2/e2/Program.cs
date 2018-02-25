using System;

namespace e2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adinizi giriniz:");
            string adiniz = Console.ReadLine();
            Console.Write("Yasinizi giriniz:");
            string yasiniz = Console.ReadLine();
            int yasInteger = Convert.ToInt32(yasiniz);
            Console.WriteLine($"Adiniz: {adiniz}, Yasiniz:{yasInteger}");
        }
    }
}
