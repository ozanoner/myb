using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    class Profil
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yasi { get; set; }

        public override string ToString()
        {
            return $"Adi: {Adi}, Soyadi: {Soyadi}, Yasi: {Yasi}";
        }
    }
}
