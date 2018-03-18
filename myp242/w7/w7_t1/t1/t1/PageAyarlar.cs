using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t1
{
    public class PageAyarlar : ContentPage
    {
        public PageAyarlar()
        {
            this.Title = "Ayarlar";
            this.Content = new StackLayout()
            {
                Padding = 10,
                Children =
                {
                   new Label() { Text = "Profil"},
                   new Label() { Text = "Konusma ayarlari"},
                }
            };
        }
    }
}