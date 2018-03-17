using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t2
{
    public class Adim3YasPage : ContentPage
    {
        public Adim3YasPage(Profil profil)
        {
            this.Title = "Yasinizi yaziniz";
            this.Padding = 10;
            this.BindingContext = profil;


            Entry e = new Entry()
            {
                Placeholder = "Yasiniz",
                Keyboard = Keyboard.Numeric
            };
            e.SetBinding(Entry.TextProperty, "Yas");

            Command navCmd = new Command(
                async () => await Navigation.PushAsync(
                    new Adim4SonPage(profil)));

            Button b = new Button()
            {
                Text = "Sonraki sayfa",
                Command = navCmd
            };

            Content = new StackLayout
            {
                Children = { e, b }
            };



            Label sehirLabel = new Label();
            // ActionSheet icin buton
            Button yerBtn = new Button()
            {
                Text = "Yasadiginiz yer"
            };
            // Clicked ile DisplayActionSheet
            yerBtn.Clicked += async (sender, arg) =>
            {
                sehirLabel.Text = await DisplayActionSheet(
                    "Sehir", "Iptal", null,
                    "Ankara", "Istanbul", "Diger");
            };
            
            // label ve buton, layout a eklenir
            var l = this.Content as StackLayout;
            l.Children.Add(sehirLabel);
            l.Children.Add(yerBtn);
        }
    }
}