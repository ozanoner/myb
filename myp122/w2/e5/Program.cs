using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Not harfini giriniz (A-D):");
            char harf = Convert.ToChar(Console.ReadLine());

            switch (harf)
            {
                case 'A':
                    Console.WriteLine("Not >= 90 ");
                    break;
                case 'B':
                    Console.WriteLine("Not >= 80 ");
                    break;
                default:
                    Console.WriteLine("Not < 60");
                    break;
            }
        }
    }
}
