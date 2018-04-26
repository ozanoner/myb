using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t2
{
    public class PageAyarlar : ContentPage
    {
        public PageAyarlar()
        {
            this.Title = "Ayarlar";

            // profil
            // sesli arama ayarlari
            // uyari ayarlari
            // geribildirim ayarlari

            Grid dashboard = new Grid()
            {
                // kenar boslugu
                Padding = 50,
                // yatayda doldur
                HorizontalOptions = LayoutOptions.Fill,
                // sutun arasi bosluklar
                ColumnSpacing = 20,
                // satir arasi bosluklar
                RowSpacing = 20,
                RowDefinitions =
                {
                    new RowDefinition() { Height = GridLength.Auto },
                    new RowDefinition() { Height = GridLength.Auto },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition() {Width = GridLength.Star },
                    new ColumnDefinition() {Width = GridLength.Star },
                }
            };

            Button profilBtn = new Button()
            {
                Text = "Profil",
                HorizontalOptions = LayoutOptions.Fill,
                HeightRequest = App.Current.MainPage.Width/3,
            };
            profilBtn.Clicked += async (s, e) =>
                await Navigation.PushAsync(new PageProfil());
            dashboard.Children.Add(profilBtn, 0, 0);

            Button sesliAramaBtn = new Button()
            {
                Text = "Sesli Arama Ayarlari",
                HorizontalOptions = LayoutOptions.Fill,
                HeightRequest = App.Current.MainPage.Width / 3,
            };
            dashboard.Children.Add(sesliAramaBtn, 1, 0);

            Button uyariBtn = new Button()
            {
                Text = "Uyari Ayarlari",
                HorizontalOptions = LayoutOptions.Fill,
                HeightRequest = App.Current.MainPage.Width / 3,
            };
            dashboard.Children.Add(uyariBtn, 0, 1);

            Button geribilBtn = new Button()
            {
                Text = "Geribildirim Ayarlari",
                HorizontalOptions = LayoutOptions.Fill,
                HeightRequest = App.Current.MainPage.Width / 3,
            };
            dashboard.Children.Add(geribilBtn, 1, 1);

            this.Content = dashboard;
        }
    }
}