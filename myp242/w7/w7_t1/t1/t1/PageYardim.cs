using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t1
{
    public class PageYardim : ContentPage
    {
        public PageYardim()
        {
            this.Title = "Yardim";
            this.Content = new StackLayout()
            {
                Padding = 10,
                Children =
                {
                   new Label()
                   {
                       Text = "Yardim konulari: ",
                       FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                   }
                }
            };
        }
    }
}