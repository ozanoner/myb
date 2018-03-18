using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t2
{
    public class PageKonusmalar : TabbedPage
    {
        public PageKonusmalar()
        {
            this.Title = "Konusmalar";
            this.Children.Add(new PageKonYazili());
            this.Children.Add(new PageKonSesli());
            this.Children.Add(new PageKonResim());
        }
    }
}