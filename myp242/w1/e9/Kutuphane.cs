using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e9
{
    class Kutuphane: IKitapSahibi
    {
        public string KutuphaneAdi { get; set; }
        public string Adresi { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Kutuphane adi: {KutuphaneAdi}, Adresi: {Adresi}";
        }
    }
}
