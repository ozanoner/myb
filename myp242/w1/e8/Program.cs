using System;
using System.Collections.Generic;


namespace e8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kitap<Kisi>> kisiselKutuphane = new List<Kitap<Kisi>>();
            Kisi k = new Kisi() { Adi = "asli", Soyadi = "kahraman" };
            Kitap<Kisi> kitap1 = new Kitap<Kisi>(k) { Adi = "kitap1", Yazari = "yazar1" };
            kisiselKutuphane.Add(kitap1);
            Kitap<Kisi> kitap2 = new Kitap<Kisi>(k) { Adi = "kitap2", Yazari = "yazar aaaa" };
            kisiselKutuphane.Add(kitap2);

            foreach (var kitap in kisiselKutuphane)
            {
                Console.WriteLine(kitap);
                kitap.SahipYazdir();
            }

            List<Kitap<Kutuphane>> genelKutuphane = new List<Kitap<Kutuphane>>();
            Kutuphane kh = new Kutuphane() { Adresi = "incek", KutuphaneAdi = "Ufuk Univ." };
            Kitap<Kutuphane> kitap3 = new Kitap<Kutuphane>(kh) { Adi = "kitap3", Yazari = "yazar1" };
            genelKutuphane.Add(kitap3);
            Kitap<Kutuphane> kitap4 = new Kitap<Kutuphane>(kh) { Adi = "kitap4", Yazari = "yazar aaaa" };
            genelKutuphane.Add(kitap4);

            foreach (var kitap in genelKutuphane)
            {
                Console.WriteLine(kitap);
                kitap.SahipYazdir();
            }
        }
    }
}
