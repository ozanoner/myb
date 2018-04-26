using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace e1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            Profil profil = new Profil() {
                KullaniciAdi = "ayse",
                Isim = "Ayse Fatma",
                Soyisim = "Korkmaz",
                Yas = 20
            };

            var page = new e1.MainPage();
            // Sayfanin veri kaynagi
            page.BindingContext = profil;

            this.MainPage = page;

            // Versiyon1: Asagidaki degisiklik, ekranda GORUNMEZ!
            // Versiyon2: Asagidaki degisiklik, ekranda gorunur
            profil.KullaniciAdi = "ayse_f";
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
