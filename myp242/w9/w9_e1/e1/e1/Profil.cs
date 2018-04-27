
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

using SQLite;
namespace e1
{

    // Profil verisi, herhangi bir veri kaynagi olabilir
    class Profil
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(16)]
        public string KullaniciAdi { get; set; }
        [MaxLength(16)]
        public string Isim { get; set; }
        [MaxLength(16)]
        public string Soyisim { get; set; }
        [MaxLength(16)]
        public string Sehir { get; set; }
        public int Yas { get; set; }

        [Ignore]
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
