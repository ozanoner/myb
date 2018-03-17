using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace t1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavPage2 : ContentPage
    {
        public NavPage2()
        {
            InitializeComponent();
            this.Title = "Yasinizi giriniz";

            // navpage3 yonlendirme icin Command
            Command navCmd = new Command(
                async () => await Navigation.PushAsync(new NavPage3()));

            this.Content = new StackLayout()
            {
                Children =
                {
                    new Entry()
                    {
                        Placeholder = "Yasiniz",
                        Keyboard = Keyboard.Numeric
                    },
                    new Button()
                    {
                        Text = "Sonraki adim",
                        Command = navCmd
                    }
                }
            };
        }
    }
}