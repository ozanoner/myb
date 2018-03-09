using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    // Generic sinif
    // T tipinde veri bulunuyor
    class Node<T>
    {
        public T Veri { get; set; }
        public Node<T> Sonraki { get; set; }
        public override string ToString()
        {
            if (Sonraki == null)
                return Veri.ToString();
            return Veri.ToString() + " " + Sonraki.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> intBaslangic = new Node<int>() { Veri = 3 };
            intBaslangic.Sonraki = new Node<int>() { Veri = 5, Sonraki = null };
            Console.WriteLine(intBaslangic);

            Node<string> strBaslangic = new Node<string>() { Veri = "kedi" };
            strBaslangic.Sonraki = new Node<string>()
            {
                Veri = "fare",
                Sonraki = new Node<string>() { Veri = "fil", Sonraki = null }
            };
            Console.WriteLine(strBaslangic);
        }
    }
}
