using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e8
{
    class Kisi
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public override string ToString()
        {
            return $"Kisi adi:{Adi},{Soyadi}";
        }
    }
}
