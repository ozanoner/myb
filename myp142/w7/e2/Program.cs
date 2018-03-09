using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    public static class QueueEkleri
    {
        public static void Bilgi<T>(this Queue<T> q, string bilgi = null)
        {
            if (bilgi != null)
            {
                Console.WriteLine("Bilgi: " + bilgi);
                Console.WriteLine($"Eleman sayisi: {q.Count}");
            }
            Console.Write("Elemanlar: <<");
            foreach (T el in q)
            {
                Console.Write($", {el}");
            }
            Console.WriteLine("<<");
            Console.WriteLine("---");
        }
    }

    class Kisi
    {
        public string Adi { get; set; }
        public override string ToString()
        {
            return this.Adi;
        }
        public override bool Equals(object obj)
        {
            return this.Adi == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.Adi.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // yeni sira
            Queue<Kisi> kisiSirasi = new Queue<Kisi>();
            kisiSirasi.Bilgi("yeni kisi sirasi");

            kisiSirasi.Enqueue(new Kisi() { Adi = "ayse" });
            kisiSirasi.Bilgi();
            kisiSirasi.Enqueue(new Kisi() { Adi = "fatma" });
            kisiSirasi.Bilgi();
            kisiSirasi.Enqueue(new Kisi() { Adi = "hayriye" });
            kisiSirasi.Bilgi();
            kisiSirasi.Bilgi("Enqueue methodu ile siraya yeni eleman ekleme");

            Kisi arananKisi = new Kisi() { Adi = "ayse" };
            kisiSirasi.Bilgi($"Contains ile bulma ({arananKisi}): " +
                (kisiSirasi.Contains(arananKisi) ? "var" : "yok"));

            kisiSirasi.Bilgi($"Siranin basindaki kisi: {kisiSirasi.Peek()}");

            // Dequeue ile siradaki kisileri bastan sona dogru siradan cikarma
            while(kisiSirasi.Count>0)
            {
                kisiSirasi.Bilgi($"Cikan: {kisiSirasi.Dequeue()}");
            }

        }
    }
}
