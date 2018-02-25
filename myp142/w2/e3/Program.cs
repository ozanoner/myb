using System;

namespace e3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Silindir yaricapi: ");
            float yaricap = Convert.ToSingle(Console.ReadLine());
            Console.Write("Silindir yuksekligi: ");
            float yukseklik = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Silindir hacmi: {Math.PI*Math.Pow(yaricap,2)*yukseklik}");
            Console.WriteLine($"Silindir alani: {2*Math.PI*yaricap*(yaricap+yukseklik)}");
        }
    }
}

