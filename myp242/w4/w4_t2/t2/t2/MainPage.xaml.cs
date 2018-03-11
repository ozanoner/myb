using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace t2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label baslik = new Label();
            baslik.Text = "Adres defteri";

            baslik.FontSize = 40;
            baslik.BackgroundColor = Color.SkyBlue;
            baslik.TextColor = Color.Black;

            baslik.HorizontalTextAlignment = TextAlignment.Start;
            baslik.HorizontalOptions = LayoutOptions.Fill;
            Label aciklama = new Label();
            aciklama.Text = "Bu uygulama Ufuk Universitesi, " +
                "Bilgisayar Programciligi bolumu, MYP242 mobil " +
                "uygulamalar dersi kapsaminda hazirlanmis olup, " +
                "ders konusu olarak UI bilesenleri islemekteyiz";
            aciklama.FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label));
            aciklama.FontAttributes = FontAttributes.Bold | FontAttributes.Italic;
            Entry kisiAdi = new Entry();
            kisiAdi.Placeholder = "Kisi adi";
            kisiAdi.Keyboard = Keyboard.Text;
            Entry email = new Entry();
            email.Placeholder = "Email adresi";
            email.Keyboard = Keyboard.Email;
            Editor notlar = new Editor();
            notlar.HeightRequest = 150;
            notlar.Text = "Kisi aciklamalarini\nburaya\ncoklu " +
                "satir\nolarak yazabilirsiniz";
            Image resim = new Image();
            resim.Source = "kisi.png";
            resim.Aspect = Aspect.AspectFit;
            resim.HorizontalOptions = LayoutOptions.Start;
            Button kaydet = new Button();
            kaydet.Text = "Kaydet";
            kaydet.HorizontalOptions = LayoutOptions.Fill;
            kaydet.Clicked += Kaydet_Clicked;
            BoxView kutu = new BoxView();
            kutu.BackgroundColor = Color.Wheat;
            kutu.HorizontalOptions = LayoutOptions.Fill;
            kutu.HeightRequest = 50;

            StackLayout layout = new StackLayout();
            layout.Children.Add(baslik);
            layout.Children.Add(aciklama);
            layout.Children.Add(kisiAdi);
            layout.Children.Add(email);
            layout.Children.Add(notlar);
            layout.Children.Add(resim);
            layout.Children.Add(kaydet);
            layout.Children.Add(kutu);

            //this.Content = layout;
            ScrollView scroll = new ScrollView();
            scroll.Content = layout;

            this.Content = scroll;
            this.Padding = new Thickness(10, 0, 10, 5);
        }

        private void Kaydet_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Kaydet butonu basildi");
        }
    }
}
