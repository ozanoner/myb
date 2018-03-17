using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace t3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            RelativeLayout l = new RelativeLayout();

            BoxView b1 = BoxFabrikasi.YeniBoxView();
            l.Children.Add(b1,
                Constraint.Constant(0),
                Constraint.Constant(0));

            BoxView b2 = BoxFabrikasi.YeniBoxView();
            l.Children.Add(b2,
                Constraint.RelativeToParent((parent) => { return parent.Width / 2; }),
                Constraint.RelativeToParent((parent) => { return parent.Height / 2; }));

            BoxView b3 = BoxFabrikasi.YeniBoxView();
            l.Children.Add(b3,
                Constraint.RelativeToView(b2, (parent, view) => { return view.X + view.Width; }),
                Constraint.RelativeToView(b2, (parent, view) => { return view.Y + view.Height; }));

            BoxView b4 = BoxFabrikasi.YeniBoxView();
            l.Children.Add(b4,
                // X koordinat
                Constraint.RelativeToParent((parent) => { return 0; }),
                // Y koordinat
                Constraint.RelativeToParent((parent) => { return parent.Height / 2; }),
                // en
                Constraint.RelativeToParent((parent) => { return parent.Width / 2; }),
                // boy
                Constraint.RelativeToParent((parent) => { return parent.Height / 2; }));

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
