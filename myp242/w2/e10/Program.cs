using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e10
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> birMethod;
            int i = 10;

            if (i >= 10)
                birMethod = val => Console.WriteLine($"10dan buyukler icin {val}");
            else
                birMethod = OndanKucukler;

            birMethod(i);
        }

        static void OndanKucukler(int val)
        {
            Console.WriteLine("10dan kucukler icin");
        }
    }
}
