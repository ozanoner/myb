﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1
{
    class KitapYazaraGoreSirala : IComparer<Kitap>
    {
        public int Compare(Kitap x, Kitap y)
        {
            return x.Yazari.CompareTo(y.Yazari);
        }
    }
}
