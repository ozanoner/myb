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
    public partial class NavPage1 : ContentPage
    {
        public NavPage1()
        {
            InitializeComponent();
            this.Title = "Tam isminizi yaziniz";
            
            // navpage2 yonlendirme icin Command
            Command navCmd = new Command(
                async () => await Navigation.PushAsync(new NavPage2()));

            this.Content = new StackLayout()
            {
                Children =
                {
                    new Entry() { Placeholder = "Isim" },
                    new Button()
                    {
                        Text = "Sonraki adim",
                        Command =navCmd
                    }
                }
            };
        }
    }
}