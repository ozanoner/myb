using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1
{
    public interface IVeritabani
    {
        SQLite.SQLiteConnection Baglan(string dosyaAdi);
    }
}
