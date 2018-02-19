using System;
using System.Collections.Generic;

namespace e6
{
    class Program
    {
        static void Main(string[] args)
        {
            // GENERIC List<T>
            List<Kitap> liste = new List<Kitap>();
            liste.Add(new Kitap() { Adi = "kitap1", Yazari = "yazar1" });
            liste.Add(new Dergi() { Adi = "dergi1", Yazari = "yazar1", OduncVerilirmi=false });
            liste.Add(new Dergi() { Adi = "dergi2", Yazari = "yazar2"});

            // foreach sadece IEnumerable<T> uzerinde calisir
            // List<T> , IEnumerable<T> interface implementasyonuna sahip
            foreach (var k in liste)
            {
                Console.WriteLine(k);
                k.OduncVer();
                Console.WriteLine();
            }
        }
    }
}
