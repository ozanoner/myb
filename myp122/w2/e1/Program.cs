using System;

namespace e1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adinizi giriniz:");
            string adiniz = Console.ReadLine();
            Console.Write("Yasinizi giriniz:");
            string yasiniz = Console.ReadLine();
            Console.WriteLine($"Adiniz: {adiniz}, Yasiniz:{yasiniz}");
        }
    }
}
