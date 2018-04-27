using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2
{
    public interface IDosya
    {
        Task Yaz(string dosyaAdi, string veri);
        Task<string> Oku(string dosyaAdi);
    }
}
