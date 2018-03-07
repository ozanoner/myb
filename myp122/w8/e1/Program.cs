using System;


namespace e1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liste = new int[5] { 3, 5, 7, 9, 10 };
            foreach (int sayi in liste)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
