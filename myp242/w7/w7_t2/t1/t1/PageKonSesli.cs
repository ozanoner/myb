using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t2
{
    public class PageKonSesli : ContentPage
    {
        public PageKonSesli()
        {
            this.Title = "Sesli";
            Content = new StackLayout
            {
                Padding = 10,
                Children = {
                    new Label { Text = "Sesli Konusma 1" },
                    new Label { Text = "Sesli Konusma 2" },
                }
            };
        }
    }
}