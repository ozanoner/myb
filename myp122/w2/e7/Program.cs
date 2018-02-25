using System;


namespace e7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ogrenci notunu yaziniz (0-100): ");
            int not = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(not>=60 ? "Gecti": "Kaldi");
        }
    }
}
