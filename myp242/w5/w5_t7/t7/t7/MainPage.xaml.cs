using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace t7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Padding = 10;

            StackLayout l = new StackLayout()
            {
                HeightRequest = 1000,
                BackgroundColor = Color.Gray,
                Children = {
                    new Button()
                    {
                        Text = "Anladim",
                        HorizontalOptions = LayoutOptions.Fill
                    },
                    new Label()
                    {
                        Text = "Bilgilendirme:\nUzun bir etiket olabilir",
                        BackgroundColor = Color.AntiqueWhite,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    }
                }
            };
            this.Content = new ScrollView()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                //HorizontalOptions = LayoutOptions.FillAndExpand,
                Content = l
            };
        }
    }
}
