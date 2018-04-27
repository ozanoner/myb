using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace e2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new e2.MainPage();
        }

        List<Profil> profiller;

        protected override async void OnStart()
        {
            // Handle when your app starts
            try
            {
                var veriDosyasi = DependencyService.Get<IDosya>();
                string veri = string.Empty;
                if (veriDosyasi != null)
                    veri = await veriDosyasi.Oku("profil.json");
                profiller = JsonConvert.DeserializeObject<List<Profil>>(veri);
                if (profiller == null)
                    profiller = new List<Profil>();
                if (profiller.Count() == 0)
                {
                    profiller.Add(new Profil() { KullaniciAdi = "aa", Isim = "ahmet", Soyisim = "durmaz" });
                    profiller.Add(new Profil() { KullaniciAdi = "bb", Isim = "burhan", Soyisim = "kacmaz" });
                    profiller.Add(new Profil() { KullaniciAdi = "cc", Isim = "ceylin", Soyisim = "meral" });
                }
                this.MainPage.BindingContext = profiller;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        protected override async void OnSleep()
        {
            // Handle when your app sleeps
            try
            {
                var veriDosyasi = DependencyService.Get<IDosya>();

                if (veriDosyasi == null)
                    return;
                await veriDosyasi.Yaz("profil.json", JsonConvert.SerializeObject(profiller));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
