using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    class KitapSirala : IComparer<Kitap>
    {
        public int Compare(Kitap x, Kitap y)
        {
            int ret = x.Adi.CompareTo(y.Adi);
            if (ret == 0)
                return x.Yazari.CompareTo(y.Yazari);
            else
                return ret;
        }
    }
}
