
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(e2.Droid.Android_Dosya))]
namespace e2.Droid
{
    class Android_Dosya : e2.IDosya
    {
        Task IDosya.Yaz(string dosyaAdi, string veri)
        {
            return Task.Run(() => {
                var docs = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                var dosya = System.IO.Path.Combine(docs, dosyaAdi);
                File.WriteAllText(dosya, veri);
            });
        }
        Task<string> IDosya.Oku(string dosyaAdi)
        {
            return Task<string>.Run(() =>
            {
                var docs = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                var dosya = System.IO.Path.Combine(docs, dosyaAdi);
                if(!File.Exists(dosya))
                    return string.Empty;

                return File.ReadAllText(dosya);
            });
        }
    }
}