using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e9
{
    class Kitap
    {
        public int ID { get; set; }
        public string ISBN { get; set; }
        public string Yazar { get; set; }
        public string Adi { get; set; }
        public DateTime YayinTarihi { get; set; }
        public string Yayinevi { get; set; }
        public string Konu { get; set; }
        public string[] AnahtarKelimeler { get; set; }
    }
}
