using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace t1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            // this.BackgroundColor = Color.Black;
            Label l1 = new Label()
            {
                Text = "Caption",
                // TextColor = Color.White,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                FontSize = 40,
                HorizontalOptions = LayoutOptions.Center,
            };
            Label l2 = new Label()
            {
                Text = "Lorem ipsum dolor sit amet, consectetur " +
                "adipiscing elit, sed do eiusmod tempor incididunt ut " +
                "labore et dolore magna aliqua. Ut enim ad minim veniam,",
                // TextColor = Color.Wheat,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
            Button btn = new Button()
            {
                Text = "Click on me",
                // FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                HorizontalOptions = LayoutOptions.Fill,
            };
            Entry name = new Entry()
            {
                Placeholder = "adiniz",
                Keyboard = Keyboard.Text
            };
            Entry url = new Entry()
            {
                Placeholder = @"http://aaa.com",
                Keyboard = Keyboard.Url
            };
            Entry password = new Entry()
            {
                IsPassword = true,
                Placeholder = "your password"
            };
            Editor notes = new Editor()
            {
                Text = "Notlar",
                HeightRequest = 100,
            };
            BoxView box = new BoxView()
            {
                HorizontalOptions = LayoutOptions.Fill,
                BackgroundColor = Color.Gray,
                HeightRequest = 200,
                VerticalOptions = LayoutOptions.Fill
            };
            Image img = new Image()
            {
                //Source = ImageSource.FromUri(new Uri(@"https://cdn57.androidauthority.net/wp-content/uploads/2017/03/NB_Icon_Mask_Shapes_Ext_02.gif")),
                Source = "monkey.jpg",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Fill
            };
            TapGestureRecognizer imgTap = new TapGestureRecognizer();
            imgTap.Tapped += async (sender, e) => {
                img.Opacity = .5;
                await Task.Delay(200);
                img.Opacity = 1;
            };
            img.GestureRecognizers.Add(imgTap);

            StackLayout l = new StackLayout();
            l.Children.Add(l1);
            l.Children.Add(img);
            l.Children.Add(l2);
            l.Children.Add(btn);
            l.Children.Add(name);
            l.Children.Add(url);
            l.Children.Add(password);
            l.Children.Add(notes);
            l.Children.Add(box);

            l.MinimumHeightRequest = 1500;

            ScrollView scroll = new ScrollView()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = l
            };

            this.Title = "first page";
            this.Padding = new Thickness(10, 0, 10, 5);
            this.Content = scroll;

            InitializeComponent();
        }
    }
}
