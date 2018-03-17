using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t2
{
    public class Adim2IsimPage : ContentPage
    {
        // yapici fonksiyon profili parametre olarak
        // aliyor
        public Adim2IsimPage(Profil profil)
        {
            this.Title = "Tam isminizi yaziniz";
            this.Padding = 10;

            // Baglanan icerik: profil
            this.BindingContext = profil;

            Entry e = new Entry()
            {
                Placeholder = "Isminiz"
            };
            // entry nin text ozelligi, 
            // profil isim alanina baglaniyor
            e.SetBinding(Entry.TextProperty, "Isim");

            // Yas sayfasina da ayni profil gonderiliyor
            Command navCmd = new Command(
                async () => await Navigation.PushAsync(
                    new Adim3YasPage(profil)));

            Button b = new Button()
            {
                Text = "Sonraki adim",
                Command = navCmd
            };

            this.Content = new StackLayout
            {
                Children = { e, b }
            };

            Button iptalBtn = new Button()
            {
                Text = "Iptal et"
            };
            iptalBtn.Clicked += async (sender, ev) =>
            {
                bool iptal = await DisplayAlert("Iptal", 
                    "Profil iptal edilecek", "evet", "hayir");
                if (iptal)
                    await this.Navigation.PopToRootAsync();
            };

            var l = this.Content as StackLayout;
            l.Children.Add(iptalBtn);
        }

    }
}