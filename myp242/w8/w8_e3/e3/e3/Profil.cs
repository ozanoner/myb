
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace e3
{

    // Profil verisi, herhangi bir veri kaynagi olabilir
    class Profil
    {
        public string KullaniciAdi { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Sehir { get; set; }
        public int Yas { get; set; }
        public Image Resim { get; set; }
    }
}
