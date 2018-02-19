using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e9
{
    class Kitap<T>
    {
        private static int yeniNo = 0;
        // Kitabin sahibi
        private T sahip;
        public Kitap(T sahibi)
        {
            this.No = ++Kitap<T>.yeniNo;
            this.sahip = sahibi;
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
        public void SahipYazdir()
        {
            Console.WriteLine(this.sahip);
        }
    }
}
