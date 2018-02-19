using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e9
{
    class Kisi: IKitapSahibi
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        // IKitapSahibi icin
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Kisi adi:{Adi},{Soyadi}";
        }
    }
}
