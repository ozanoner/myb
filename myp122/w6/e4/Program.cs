using System;


namespace e4
{
    // TEMEL SINIF
    class Sekil
    {
        public void SekilYazdir()
        {
            Console.WriteLine("Sekildir");
        }
    }

    // TUREMIS SINIF
    class Ucgen : Sekil
    {
        public void UcgenYazdir()
        {
            Console.WriteLine("Ucgendir");
        }
    }

    // Sekil hiyerarsisinde degil
    class BaskaBirsey
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            // MUMKUN, cunku her ucgen bir sekildir
            Sekil a = new Ucgen();
            
            // is ile tip kontrolu
            if (a is Sekil)
            {
                Console.WriteLine("a nesnesi bir sekil");
            }
            // is ile tip kontrolu
            if (a is Ucgen)
            {
                Console.WriteLine("a nesnesi bir ucgen");
            }

            // as ile tip cevrimi
            Ucgen u = a as Ucgen;
            if(u != null)
            {
                u.UcgenYazdir();
            }

            Sekil s1 = u as Sekil;
            if(s1 != null)
            {
                Console.WriteLine("u nesnesi bir sekil");
                s1.SekilYazdir();
            }

            BaskaBirsey b = new BaskaBirsey();
            if(!(b is Sekil))
            {
                Console.WriteLine("b nesnesi sekil degil");
            }
        }
    }
}
