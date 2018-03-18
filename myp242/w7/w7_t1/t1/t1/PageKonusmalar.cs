using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t1
{
    public class PageKonusmalar : ContentPage
    {
        public PageKonusmalar()
        {
            this.Title = "Konusmalar";
            this.Content = new StackLayout()
            {
                Padding = 10,
                Children =
                {
                   new Label() { Text = "Konusma 1" },
                   new Label() { Text = "Konusma 2"},
                }
            };
        }
    }
}