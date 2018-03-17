using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace t4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            AbsoluteLayout l = new AbsoluteLayout();

            BoxView b1 = BoxFabrikasi.YeniBoxView();
            AbsoluteLayout.SetLayoutBounds(b1, new Rectangle(0, 0, .5, .5));
            AbsoluteLayout.SetLayoutFlags(b1, AbsoluteLayoutFlags.All);
            l.Children.Add(b1);

            BoxView b2 = BoxFabrikasi.YeniBoxView();
            AbsoluteLayout.SetLayoutBounds(b2, new Rectangle(0, 0, .4, .4));
            AbsoluteLayout.SetLayoutFlags(b2, AbsoluteLayoutFlags.All);
            l.Children.Add(b2);

            BoxView b3 = BoxFabrikasi.YeniBoxView();
            AbsoluteLayout.SetLayoutBounds(b3, new Rectangle(0, 0, .3, .3));
            AbsoluteLayout.SetLayoutFlags(b3, AbsoluteLayoutFlags.All);
            l.Children.Add(b3);

            BoxView b4 = BoxFabrikasi.YeniBoxView();
            AbsoluteLayout.SetLayoutBounds(b4, new Rectangle(0, 0, .2, .2));
            AbsoluteLayout.SetLayoutFlags(b4, AbsoluteLayoutFlags.All);
            l.Children.Add(b4);


            BoxView b5 = BoxFabrikasi.YeniBoxView();
            AbsoluteLayout.SetLayoutBounds(b5, new Rectangle(1, 1, .5, .5));
            AbsoluteLayout.SetLayoutFlags(b5, AbsoluteLayoutFlags.All);
            l.Children.Add(b5);

            BoxView b6 = BoxFabrikasi.YeniBoxView();
            AbsoluteLayout.SetLayoutBounds(b6, new Rectangle(1, 1, .4, .4));
            AbsoluteLayout.SetLayoutFlags(b6, AbsoluteLayoutFlags.All);
            l.Children.Add(b6);

            BoxView b7 = BoxFabrikasi.YeniBoxView();
            AbsoluteLayout.SetLayoutBounds(b7, new Rectangle(1, 1, .3, .3));
            AbsoluteLayout.SetLayoutFlags(b7, AbsoluteLayoutFlags.All);
            l.Children.Add(b7);

            BoxView b8 = BoxFabrikasi.YeniBoxView();
            AbsoluteLayout.SetLayoutBounds(b8, new Rectangle(1, 1, .2, .2));
            AbsoluteLayout.SetLayoutFlags(b8, AbsoluteLayoutFlags.All);
            l.Children.Add(b8);

            Label l1 = new Label() { Text = "sag ust bolge" };
            AbsoluteLayout.SetLayoutBounds(l1, new Rectangle(.8, .2, 
                AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            AbsoluteLayout.SetLayoutFlags(l1, AbsoluteLayoutFlags.PositionProportional);
            l.Children.Add(l1);

            Label l2 = new Label() { Text = "sol alt bolge" };
            AbsoluteLayout.SetLayoutBounds(l2, new Rectangle(.2, .8,
                AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            AbsoluteLayout.SetLayoutFlags(l2, AbsoluteLayoutFlags.PositionProportional);
            l.Children.Add(l2);

            this.Content = l;

        }
    }


    public static class BoxFabrikasi
    {
        static List<Color> renklistesi;
        static int index;

        // singleton constructor
        static BoxFabrikasi()
        {
            renklistesi = new List<Color>()
            {
                Color.Wheat,
                Color.Olive,
                Color.DarkCyan,
                Color.Firebrick,
                Color.Indigo
            };
            index = 0;
        }

        public static BoxView YeniBoxView()
        {
            index %= renklistesi.Count;
            return new BoxView()
            {
                Color = renklistesi[index++],
                WidthRequest = 100,
                HeightRequest = 100
            };
        }
    }
}
