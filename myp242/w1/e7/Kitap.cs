using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e7
{
    class Kitap
    {
        private static int yeniNo = 0;
        public Kitap()
        {
            this.No = ++Kitap.yeniNo;
        }
        public string Adi { get; set; }
        public string Yazari { get; set; }
        public int No { get; private set; }
        public string KutuphaneAdi { get; protected set; }
        public override string ToString()
        {
            return $"Kitap No: {No}\nKitap adi: {Adi}\nYazari:" +
                $" {Yazari}\nKutuphane: {KutuphaneAdi}";
        }
        public virtual void OduncVer()
        {
            Console.WriteLine($"Kitap odunc verildi. Kitap adi:{Adi}");
        }
    }
}
