using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace e1
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Label kullaniciAdi = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Fill,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                TextColor = Color.Red
            };
            kullaniciAdi.SetBinding(Label.TextProperty, "KullaniciAdi");

            Entry isim = new Entry();
            isim.SetBinding(Entry.TextProperty, "Isim");

            Entry soyisim = new Entry();
            soyisim.SetBinding(Entry.TextProperty, "Soyisim");

            Entry yas = new Entry() { Keyboard = Keyboard.Numeric };
            // BindingMode -> cift yonlu/tek yonlu veri aktarimi
            // IValueConverter -> farkli tipler icin deger cevrimi
            yas.SetBinding(Entry.TextProperty, "Yas", 
                BindingMode.TwoWay, new YasCevirici());

            Content = new StackLayout
            {
                Padding = 10,
                Children = {
                    kullaniciAdi, isim, soyisim, yas
                }
            };
        }
    }
}