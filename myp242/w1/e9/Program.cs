using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kitap<IKitapSahibi>> indeks = new List<Kitap<IKitapSahibi>>();
            Kisi k = new Kisi() { Adi = "asli", Soyadi = "kahraman" };
            Kitap<IKitapSahibi> kitap1 = new Kitap<IKitapSahibi>(k) { Adi = "kitap1", Yazari = "yazar1" };
            indeks.Add(kitap1);
            Kitap<IKitapSahibi> kitap2 = new Kitap<IKitapSahibi>(k) { Adi = "kitap2", Yazari = "yazar aaaa" };
            indeks.Add(kitap2);

            Kutuphane kh = new Kutuphane() { Adresi = "incek", KutuphaneAdi = "Ufuk Univ." };
            Kitap<IKitapSahibi> kitap3 = new Kitap<IKitapSahibi>(kh) { Adi = "kitap3", Yazari = "yazar1" };
            indeks.Add(kitap3);
            Kitap<IKitapSahibi> kitap4 = new Kitap<IKitapSahibi>(kh) { Adi = "kitap4", Yazari = "yazar aaaa" };
            indeks.Add(kitap4);

            foreach (var kitap in indeks)
            {
                Console.WriteLine(kitap);
                kitap.SahipYazdir();
            }
        }
    }
}
