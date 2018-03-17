using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace t2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label baslik = new Label()
            {
                Text = "Soru 10",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Label soru = new Label()
            {
                Text = "Asagidaki verilen kosulun sonucu dogru mudur, yoksa yanlis midir?",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Image soruResim = new Image()
            {
                Source = "soru1.png",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Fill,
                HeightRequest = 100
            };

            Button trueBtn = new Button()
            {
                Text = "Dogru",
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            trueBtn.Clicked += (s, e) => { trueBtn.Text = "Tebrikler"; };

            Button falseBtn = new Button()
            {
                Text = "Yanlis",
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            falseBtn.Clicked += (s, e) => { falseBtn.Text = "Tekrar deneyiniz"; };

            this.Content = new StackLayout()
            {
                Padding = new Thickness(10, 0, 10, 0),
                Spacing = 5,
                Children =
                {
                   baslik, soru, soruResim, trueBtn, falseBtn
                }
            };
        }


    }
}
