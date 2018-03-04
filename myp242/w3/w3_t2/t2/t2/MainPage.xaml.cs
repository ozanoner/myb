using Xamarin.Forms;
using System.Diagnostics;

namespace t2
{
    // PAGE (sayfa) -> ContentPage
    public partial class MainPage : ContentPage
    {
        // Yapici fonksiyon
        public MainPage()
        {
            // LAYOUT (yerlesim)
            StackLayout sl = new StackLayout();

            // VIEW (gorunum)
            Button btn1 = new Button() { Text = "TAMAM" };
            
            // VIEW (gorunum)
            Label lbl1 = new Label() { Text = "--Selam Xamarin--" };

            // Layout icine View leri ekle
            sl.Children.Add(btn1);
            sl.Children.Add(lbl1);

            // Sayfanin icine Layout ekle
            this.Content = sl;

            // otomatik kod
            InitializeComponent();
        }
    }
}
