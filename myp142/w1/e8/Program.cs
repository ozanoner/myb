using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e8
{
    class Program
    {
        static void Main(string[] args)
        {
            // degiskenler
            int a = 3, b, c;
            // once b nin degerini a yap, sonra a yi artir
            b = a++;
            // once a yi artir, sonra c nin degerini a yap
            c = ++a;
        }
    }
}
