using System;
using System.Collections.Generic;

namespace e7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Kitap> indeks = new Dictionary<string, Kitap>();
            indeks["kitap1"] = new Kitap() { Adi = "kitap1", Yazari = "yazar1"};
            indeks["dergi1"] = new Dergi() { Adi = "dergi1", OduncVerilirmi = false, Yazari = "yazar2"};
            indeks["dergi2"] = new Dergi() { Adi = "kitap2", OduncVerilirmi = true, Yazari = "yazar3"};

            // Dictionary uzerinden kitap erisimi
            Console.WriteLine(indeks["kitap1"]);

            // is operatoru ile type kontrolu
            var k = indeks["dergi1"];
            if(k!=null && k is Dergi)
            {
                Console.WriteLine(((Dergi)k).OduncVerilirmi);
            }

            // as operatoru ile type cevirme
            var k2 = indeks["dergi2"] as Dergi;
            if (k2 != null)
            {
                Console.WriteLine(k2.OduncVerilirmi);
            }
        }
    }
}
