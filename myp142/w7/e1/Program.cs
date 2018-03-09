using System;
using System.Collections.Generic;

namespace e1
{
    public static class StackEkleri
    {
        public static void Bilgi<T>(this Stack<T> s, string bilgi = null)
        {
            if (bilgi != null)
            {
                Console.WriteLine("Bilgi: " + bilgi);
                Console.WriteLine($"Eleman sayisi: {s.Count}");
            }
            Console.Write("Elemanlar: ");
            foreach (T el in s)
            {
                Console.Write($", {el}");
            }
            Console.WriteLine("||");
            Console.WriteLine("---");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Bilgi("yeni stack");

            // push ile 0..2 sayilarinin stacke eklenmesi 
            // en altta 0 var. |01234
            intStack.Push(0);
            intStack.Bilgi();
            intStack.Push(1);
            intStack.Bilgi();
            intStack.Push(2);
            intStack.Bilgi();
            intStack.Bilgi("Push ile stack ustune eleman ekleme");

            intStack.Bilgi("Contains ile eleman bulma: " + 
                (intStack.Contains(1)?"1 var":"1 yok"));

            intStack.Bilgi("Peek ile en ustteki elemana bakma: " 
                + intStack.Peek());

            // Pop ile en ustteki elemani stackten cikarma
            while(intStack.Count>0)
            {
                Console.WriteLine("Pop: " + intStack.Pop());
                intStack.Bilgi();
            }
        }
    }
}
