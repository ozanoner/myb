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

            // page properties
            this.Title = "Chat uygulamasi";

            // navpage1 yonlendirme icin Command
            Command navCmd = new Command(
                async () => await Navigation.PushAsync(new NavPage1()));

            this.Content = new StackLayout()
            {
                Children = {
                    // navCmd ile NavPage1 yonlendirmesi yapar
                    new Button()
                    {
                        Text = "Profil olustur",
                        Command = navCmd
                    }
                }
            };
        }
    }
}
