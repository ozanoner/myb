using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kopru max yukseklik: ");
            float maxYukseklik = Convert.ToSingle(Console.ReadLine());
            Console.Write("Kopru max agirlik: ");
            float maxAgirlik = Convert.ToSingle(Console.ReadLine());

            Console.Write("TIR yukseklik: ");
            float tirYukseklik = Convert.ToSingle(Console.ReadLine());
            Console.Write("TIR agirlik: ");
            float tirAgirlik = Convert.ToSingle(Console.ReadLine());

            if(tirAgirlik > maxAgirlik || tirYukseklik > maxYukseklik)
                Console.WriteLine("TIR bu kopruden gecemez");

            if (tirAgirlik <= maxAgirlik && tirYukseklik <= maxYukseklik)
                Console.WriteLine("TIR bu kopruden gecebilir");
        }
    }
}
