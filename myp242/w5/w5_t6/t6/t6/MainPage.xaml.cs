using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace t6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // safya ic kenari boslugu
            this.Padding = 10;

            Frame f = new Frame()
            {
                // cerceve rengi
                OutlineColor = Color.Black,
                // frame ic kenari boslugu
                Padding = 10
            };
            this.Content = f;

            f.Content = new StackLayout()
            {
                Children =
                {
                    new Label() { Text = "etiket -1 ", BackgroundColor = Color.Aqua },
                    new Label() { Text = "etiket -2 ", BackgroundColor = Color.Aqua },
                    new Label() { Text = "etiket -3 ", BackgroundColor = Color.Aqua },
                }
            };

        }
    }
}
