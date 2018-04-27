using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace e1
{
    public partial class MainPage : ContentPage
    {
        Proje_DAL veri;
        public MainPage()
        {
            InitializeComponent();

            IEnumerable<Profil> profiller = new List<Profil>();

            try
            {
                veri = new Proje_DAL();
                veri.Baglan();

                profiller = veri.ProfilleriGetir();
                if (profiller.Count() == 0)
                {
                    veri.ProfilKaydet(new Profil() { KullaniciAdi = "aa", Isim = "ahmet", Soyisim = "durmaz" });
                    veri.ProfilKaydet(new Profil() { KullaniciAdi = "bb", Isim = "burhan", Soyisim = "kacmaz" });
                    veri.ProfilKaydet(new Profil() { KullaniciAdi = "cc", Isim = "ceylin", Soyisim = "meral" });
                    profiller = veri.ProfilleriGetir();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            System.Diagnostics.Debug.WriteLine("[w9_e1-app] Profiller");
            foreach (var item in profiller)
            {
                System.Diagnostics.Debug.WriteLine(item);
            }

            ListView l = new ListView()
            {
                ItemsSource = profiller,
                ItemTemplate = new DataTemplate(typeof(TextCell))
            };
            l.ItemTemplate.SetBinding(TextCell.TextProperty, "KullaniciAdi");
            l.ItemTemplate.SetBinding(TextCell.DetailProperty, "TumIsim");


            this.Content = new StackLayout()
            {
                Children = { l }
            };
        }
    }
}
