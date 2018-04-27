
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

using Newtonsoft.Json;

namespace e2
{

    // Profil verisi, herhangi bir veri kaynagi olabilir
    class Profil
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Sehir { get; set; }
        public int Yas { get; set; }

        [JsonIgnore]
        public string TumIsim
        {
            get { return $"{Soyisim}, {Isim}"; }
        }

        public override string ToString()
        {
            return $"Profil: {ID}, {KullaniciAdi}, {TumIsim}";
        }
    }
}
