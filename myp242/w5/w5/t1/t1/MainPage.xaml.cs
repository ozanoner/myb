using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace t1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Content = new StackLayout
            {
                Padding = new Thickness(10, 0, 10, 0),
                Spacing = 5,
                Children = {
                    new Label() {
                        Text = "Yatay Center",
                        HorizontalOptions = LayoutOptions.Center,
                        BackgroundColor = Color.Wheat,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                    },
                    new Label() {
                        Text = "Yatay Start",
                        HorizontalOptions = LayoutOptions.Start,
                        BackgroundColor = Color.Wheat,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                    },
                    new Label() {
                        Text = "Yatay End",
                        HorizontalOptions = LayoutOptions.End,
                        BackgroundColor = Color.Wheat,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                    },
                    new Label() {
                        Text = "Yatay Fill",
                        HorizontalOptions = LayoutOptions.Fill,
                        BackgroundColor = Color.Wheat,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                    },
                    new Label() {
                        Text = "Yatay Fill + Dikey FillAndExpand",
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        BackgroundColor = Color.Wheat,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                    },
                    new Label() {
                        Text = "Horizontal Start + Dikey StartAndExpand",
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        BackgroundColor = Color.Wheat,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                    }

                }
            };
        }
    }
}
