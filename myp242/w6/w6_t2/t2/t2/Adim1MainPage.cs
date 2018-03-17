using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t2
{
    public class Adim1MainPage : ContentPage
    {
        public Adim1MainPage()
        {
            this.Title = "Chat uygulamasi";

            // bilgiler profilde toplanacak
            Profil profil = new Profil();

            // Adim2IsimPage sayfasina da profil
            // gonderiliyor
            Command navCmd = new Command(
                async () => await Navigation.PushAsync(
                    new Adim2IsimPage(profil)));

            Content = new StackLayout
            {
                Children =
                {
                    new Button()
                    {
                        Text = "Profil olustur",
                        Command = navCmd
                    },
                    new Button()
                    {
                        Text = "Yardim",
                        // Yardim icin tam-sayfa modal acar
                        Command = new Command(async ()=>
                            await Navigation.PushModalAsync(new Modal1Yardim()))
                    }
                }
            };
        }
    }
}