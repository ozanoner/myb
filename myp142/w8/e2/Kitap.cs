using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    // Kitap sinifi tanimi
    class Kitap
    {
        // Yeni nesne icin otomatik ID olusturma amaciyla
        protected static int YeniId = 0;
        public int Id { get; protected set; }
        public string Adi { get; protected set; }
        public string Yazari { get; protected set; }
        public double Fiyati { get; set; }

        // Yapici method
        public Kitap(string adi, string yazari, double fiyat)
        {
            this.Id = ++Kitap.YeniId;
            this.Adi = adi;
            this.Yazari = yazari;
            this.Fiyati = fiyat;
        }

        public override string ToString()
        {
            return $"Kitap Id:{Id}, Adi:{Adi}, Yazari:{Yazari}, Fiyat:{Fiyati}";
        }
    }
}
