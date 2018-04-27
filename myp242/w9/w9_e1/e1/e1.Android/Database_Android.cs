using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using SQLite;
using System.IO;

[assembly: Dependency(typeof(e1.Database_Android))]
namespace e1
{
    public class Database_Android : e1.IVeritabani
    {
        public Database_Android() { }
        public SQLiteConnection Baglan(string dosyaAdi)
        {
            string folder =
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, dosyaAdi);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}
