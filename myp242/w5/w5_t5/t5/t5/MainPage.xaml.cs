using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace t5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Grid grid = new Grid()
            {
                RowSpacing = 0,
                ColumnSpacing = 0,
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                }
            };
            this.Content = grid;

            for (int row = 0; row < grid.RowDefinitions.Count; row++)
            {
                for (int col = 0; col < grid.ColumnDefinitions.Count; col++)
                {
                    BoxView b = BoxFabrikasi.YeniBoxView();
                    grid.Children.Add(b, col, row);
                    grid.Children.Add(new Label() { Text = $"({row},{col})" }, col, row);
                }
            }
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
