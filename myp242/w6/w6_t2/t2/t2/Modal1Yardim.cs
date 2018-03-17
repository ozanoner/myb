using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t2
{
    public class Modal1Yardim : ContentPage
    {
        public Modal1Yardim()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label
                    {
                        Text = "Profil olusturma sirasinda " +
                        "isminiz ve yasiniz sorularak sizin " +
                        "profiliniz olusturulur"
                    },
                    new Button
                    {
                        Text = "tamam",
                        // Yardim sayfasi kapatilir
                        Command = new Command(async ()=>
                            await Navigation.PopModalAsync())
                    }
                }
            };
        }
    }
}