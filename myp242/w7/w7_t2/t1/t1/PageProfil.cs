using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t2
{
    public class PageProfil : ContentPage
    {
        public PageProfil()
        {
            this.Title = "Profil";
            Content = new StackLayout
            {
                Children =
                {
                    new Entry() { Placeholder = "Adiniz" },
                    new Entry() { Placeholder = "Yasiniz" },
                    new Button() { Text = "Kaydet" }
                }
            };
        }
    }
}