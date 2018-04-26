using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace e2
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            // VERI KAYNAGI. HERHANGI BIR KAYNAK OLABILIR
            Profil profil = new Profil()
            {
                KullaniciAdi = "ayse",
                Isim = "Ayse Fatma",
                Soyisim = "Korkmaz",
                Yas = 20,
                Sehir = "Ankara"
            };

            var sayfa = new NavigationPage(new ProfilSayfasi());
            // sayfanin BindingContext alani bir ViewModel
            sayfa.BindingContext = new ProfilVM(profil);
            this.MainPage = sayfa;
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
