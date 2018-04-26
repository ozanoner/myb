using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace e2
{
	public class ProfilSayfasi : ContentPage
	{
		public ProfilSayfasi ()
		{
            Label kullaniciAdi = new Label()
            {
                BackgroundColor = Color.White,
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            // ViewModel binding
            kullaniciAdi.SetBinding(Label.TextProperty, 
                "KullaniciAdi", BindingMode.OneWay);

            Label isim = new Label()
            {
                BackgroundColor = Color.White,
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            isim.SetBinding(Label.TextProperty, 
                "TumIsim", BindingMode.OneWay);

            Button duzenle = new Button() { Text = "Duzenle" };
            duzenle.Clicked += async (sender, e) => {
                var p = new ProfilDuzenleme();
                p.BindingContext = this.BindingContext;
                await Navigation.PushAsync(p);
            };

            this.Title = "Profil Izleme";
            Content = new StackLayout {
                Padding = 10,
				Children = {
                    kullaniciAdi, isim, duzenle
				}
			};
        }
    }
}