using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kitap> liste = new List<Kitap>();
            liste.Add(new Kitap()
            {
                Adi = "Kitap-1",
                AnahtarKelimeler = new string[] {"a","b","c"},
                ID = 1,
                ISBN = "11212114243-1231",
                Konu = "Konu-1",
                Yayinevi = "Yayinevi A",
                YayinTarihi = DateTime.Now,
                Yazar = "Yazar-A"
            });
            liste.Add(new Kitap()
            {
                Adi = "Kitap-2",
                AnahtarKelimeler = new string[] { "a", "b", "c" },
                ID = 2,
                ISBN = "9912314243-1231",
                Konu = "Konu-2",
                Yayinevi = "Yayinevi Z",
                YayinTarihi = DateTime.Now,
                Yazar = "Yazar-A"
            });

            // ozet bilgi, anonim tip elemanlara sahip
            var ozetBilgi = liste.Select(k => new { k.Adi, k.Yazar});

            ozetBilgi.ToList().ForEach(o => 
                Console.WriteLine($"Kitap adi: {o.Adi}, yazar: {o.Yazar}"));
        }
    }
}
