using System;
using System.IO;


namespace e8
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
            Ogrenci[] sinif = new Ogrenci[3] 
            {
                new Ogrenci() { Adi = "ali", OkulNo = 123},
                new Ogrenci() { Adi = "ayse", OkulNo = 234},
                new Ogrenci() { Adi = "fatma", OkulNo = 435}
            };

            string[] icerik = new string[3];

            for (int i = 0; i < sinif.Length; i++)
            {
                icerik[i] = sinif[i].ToString();
            }
            File.WriteAllLines("sinif.csv", icerik);
        }
    }
}
