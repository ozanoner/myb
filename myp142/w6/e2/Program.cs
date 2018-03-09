using System;
using System.Collections;

namespace e2
{
    public static class HashtableEkleri
    {
        public static void Bilgi(this Hashtable koleksiyon, string bilgi)
        {
            Console.WriteLine($"Bilgi: {bilgi}");
            Console.WriteLine($"Eleman sayisi: {koleksiyon.Count}");
            Console.WriteLine("Anahtar-degerler: ");
            foreach (DictionaryEntry el in koleksiyon)
            {
                Console.Write($"{el.Key}=>{el.Value}\n");
            }
            Console.WriteLine("---");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // yeni Hashtable
            Hashtable birlikteAc = new Hashtable();

            // yeni ikililer ekleme.
            birlikteAc.Add("txt", "notepad.exe");
            birlikteAc.Add("bmp", "paint.exe");
            birlikteAc.Add("rtf", "wordpad.exe");
            // HATA: txt anahtari zaten var
            //birlikteAc.Add("txt", "winword.exe");
            birlikteAc.Bilgi("Add methodu ile yeni ikililer ekleme");


            // anahtara karsilik gelen degeri guncelleme
            // yoksa ekler
            birlikteAc["rtf"] = "winword.exe";
            birlikteAc.Bilgi("Anahtara karsilik gelen degeri guncelleme");

            // indeksleme yontemi ile yeni veri ekleme.
            birlikteAc["doc"] = "winword.exe";
            birlikteAc.Bilgi("indeksleme yontemi ile yeni veri ekleme");

            // ContainsKey ile eklemeden once kontrol etme
            if (!birlikteAc.ContainsKey("ht"))
            {
                birlikteAc.Add("ht", "hypertrm.exe");
            }
            birlikteAc.Bilgi("ContainsKey ile eklemeden once kontrol etme");


            // Keys property araciligiyla ikilileri listeleme
            var anahtarlar = birlikteAc.Keys;
            foreach (string s in anahtarlar)
            {
                Console.WriteLine($"anahtar:{s} deger:{birlikteAc[s]}");
            }
            Console.WriteLine("---");

            // Remove methodu ile silme.
            birlikteAc.Remove("doc");
            birlikteAc.Bilgi("Remove methodu ile silme.");

        }
    }
}
