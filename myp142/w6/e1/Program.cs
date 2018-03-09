using System;
using System.Collections;

namespace e1
{
    public static class ArrayListEkleri
    {
        public static void Bilgi(this ArrayList liste, string bilgi)
        {
            Console.WriteLine($"Bilgi: {bilgi}");
            Console.WriteLine($"Eleman sayisi: {liste.Count}, Kapasite: {liste.Capacity}");
            Console.Write("Elemanlar: ");
            foreach (var el in liste)
            {
                Console.Write($"{el}, ");
            }
            Console.WriteLine("\n---");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            ArrayList notlar = new ArrayList();
            notlar.Bilgi("Yeni liste");
            
            // Ekleme
            notlar.Add(54);
            notlar.Add(19);
            notlar.Bilgi("Add ile ekleme");

            // otomatik kapasite artmasi
            for (int i = 0; i < 5; i++)
                notlar.Add(70 + i);
            notlar.Bilgi("Otomatik kapasite artmasi");

            // verilen indekse ekleme
            notlar.Insert(1, 65);
            // HATA: 20 indeksi simdilik yok
            // notlar.Insert(20, 81);
            notlar.Bilgi("Insert ile araya ekleme");
            
            // index yardimiyla guncelleme
            notlar[0] = 5;
            notlar.Bilgi("index ile guncelleme");

            // deger bulup silme
            notlar.Remove(5);
            notlar.Bilgi("Remove ile deger bulup silme");

            // indexteki degeri silme
            notlar.RemoveAt(0);
            notlar.Bilgi("RemoveAt ile indexteki degeri silme");

            // listeyi temizleme
            notlar.Clear();
            notlar.Bilgi("Clear ile listeyi temizleme");
        }
    }
}
