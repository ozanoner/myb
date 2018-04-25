using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanici adi - profil eslestirmesi
            KeyValuePair<string, Profil> kv =
                new KeyValuePair<string, Profil>("zipzip-ali",
                    new Profil() { Adi = "Ali", Soyadi = "Zipzip", Yasi = 20 });

            // key -> anahtar = kullanici adi
            // value -> deger = profil
            Console.WriteLine($"Kullanici adi: {kv.Key}, Profil: {kv.Value}");
        }
    }
}
