using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace e3
{
    public class ProfilDuzenleme : ContentPage
    {
        public ProfilDuzenleme()
        {
            Label kullaniciAdi = new Label()
            {
                BackgroundColor = Color.White,
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            kullaniciAdi.SetBinding(Label.TextProperty, "KullaniciAdi");

            Entry isim = new Entry();
            isim.SetBinding(Entry.TextProperty, "Isim");

            Entry soyisim = new Entry();
            soyisim.SetBinding(Entry.TextProperty, "Soyisim");

            Entry yas = new Entry() { Keyboard = Keyboard.Numeric };
            yas.SetBinding(Entry.TextProperty, "Yas");

            Entry sehir = new Entry();
            sehir.SetBinding(Entry.TextProperty, "Sehir");

            Button kaydet = new Button() { Text = "Kaydet" };
            kaydet.Clicked += async (sender, e) =>
            {
                ProfilVM vm = this.BindingContext as ProfilVM;
                if(vm!=null)
                {
                    vm.KaydetKomutu.Execute(null);
                }
                await Navigation.PopAsync();
            };

            this.Title = "Profil Duzenleme";
            Content = new StackLayout
            {
                Padding = 10,
                Children = {
                    kullaniciAdi, isim, soyisim, sehir, kaydet
                }
            };
        }
    }
}