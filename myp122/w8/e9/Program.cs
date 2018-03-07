using System;
using System.IO;


namespace e9
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public int OkulNo { get; set; }
        public override string ToString()
        {
            return $"{Adi},{OkulNo}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaAdi = "sinif.csv";
            if (!File.Exists(dosyaAdi))
                return;
            var satirlar = File.ReadAllLines(dosyaAdi);

            Ogrenci[] sinif = SinifOlustur(satirlar);

            foreach (var ogr in sinif)
            {
                Console.WriteLine($"Ogrenci: {ogr}");
            }
        }

        private static Ogrenci[] SinifOlustur(string[] satirlar)
        {
            Ogrenci[] sinif = new Ogrenci[satirlar.Length];

            // satirlarin icindeki bilgilerden 
            // ogrenci nesneleri olusturma
            for (int i = 0; i < satirlar.Length; i++)
            {
                string satir = satirlar[i].Trim();
                if (satir.Length <= 0) continue;

                string[] sutunlar = satir.Split(',');
                if (sutunlar.Length < 2) continue;

                sinif[i] = new Ogrenci()
                {
                    Adi = sutunlar[0],
                    OkulNo = Convert.ToInt32(sutunlar[1])
                };
            }

            return sinif;
        }
    }
}
