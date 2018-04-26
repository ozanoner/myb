
using Xamarin.Forms;

namespace e3
{
    public class ProfilListesi : ContentPage
    {
        public ProfilListesi()
        {
            ListView l = new ListView();
            this.BindingContextChanged += (s, e) =>
            {
                l.ItemsSource = (ProfillerVM)this.BindingContext;
                l.ItemTemplate = new DataTemplate(typeof(TextCell));
                l.ItemTemplate.SetBinding(TextCell.TextProperty, "KullaniciAdi");
                l.ItemTemplate.SetBinding(TextCell.DetailProperty, "TumIsim");
            };

            Button duzenle = new Button()
            {
                Text = "Duzenle"
            };
            duzenle.Clicked += async (s, e) =>
            {
                var profil = l.SelectedItem as ProfilVM;
                if (profil != null)
                {
                    var sayfa = new ProfilDuzenleme();
                    sayfa.BindingContext = profil;
                    await Navigation.PushAsync(sayfa);
                }
            };

            Button sil = new Button()
            {
                Text = "sil"
            };
            sil.Clicked += (s, e) =>
            {
                var profil = l.SelectedItem as ProfilVM;
                if(profil != null)
                {
                    var liste = l.ItemsSource as ProfillerVM;
                    if(liste !=null)
                    {
                        liste.Remove(profil);
                    }
                }
            };

            this.Title = "Profiller";
            this.Content = new StackLayout()
            {
                Padding = 10,
                Children = { l, duzenle, sil }
            };

            this.Appearing += (s, e) =>
            {
                l.SelectedItem = null;
            };
        }

    }
}