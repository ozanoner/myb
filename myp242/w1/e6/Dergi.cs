using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e6
{
    class Dergi : Kitap, IOduncVerme
    {
        public Dergi()
        {
            // set-Kutuphane methodu erisimi
            this.KutuphaneAdi = "Ufuk Univ.";
            this.OduncVerilirmi = true;
        }
        // IOduncVerme interface den dolayi
        public bool OduncVerilirmi { get; set; }

        public override void OduncVer()
        {
            if (this.OduncVerilirmi)
            {
                Console.WriteLine($"Dergi odunc verildi. Dergi adi:{Adi}, " +
                    $"Kutuphane: {KutuphaneAdi}");
            }
            else
            {
                Console.WriteLine($"Dergi odunc VERILEMEZ. Dergi adi:{Adi}, " +
                 $"Kutuphane: {KutuphaneAdi}");
            }
        }
    }
}
