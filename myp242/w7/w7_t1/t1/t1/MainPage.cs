using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t1
{
    public class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            ListView lw = new ListView()
            {
                Header = new StackLayout()
                {
                    Children =
                    {
                        new Label()
                        {
                            Text = "Secenekler",
                            FontAttributes = FontAttributes.Bold
                        },
                        new BoxView()
                        {
                            HeightRequest = 5,
                            HorizontalOptions = LayoutOptions.Fill,
                            Color = Color.Black
                        }
                    }
                },
                ItemsSource = new string[]
                    { "Konusmalar", "Ayarlar", "Yardim" },
            };
            lw.ItemTapped += Lw_ItemTapped;

            this.Master = new ContentPage()
            {
                Title = "Chat uygulamasi",
                Content = lw,
                Icon = "hamburger.png"
            };
            this.Detail = new NavigationPage(new PageKonusmalar());
        }

        private void Lw_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ContentPage p = null;
            switch (e.Item.ToString())
            {
                case "Konusmalar":
                    p = new PageKonusmalar();
                    break;
                case "Ayarlar":
                    p = new PageAyarlar();
                    break;
                case "Yardim":
                    p = new PageYardim();
                    break;
                default:
                    p = new PageKonusmalar();
                    break;
            }
            this.Detail = new NavigationPage(p);

            // Master i kapat
            ((ListView)sender).SelectedItem = null;
            this.IsPresented = false;
        }
    }
}