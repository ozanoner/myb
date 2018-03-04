using System;

namespace e15
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacchi(0, 1, 50);
            Console.WriteLine();
        }

        static int Fibonacchi(int i, int j, int max)
        {
            if (j >= max)
                return 0;
            Console.Write($", {j}");
            return Fibonacchi(j, j + i, max);
        }
    }
}
