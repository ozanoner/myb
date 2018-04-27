using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Newtonsoft.Json;

namespace e2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            ListView l = new ListView()
            {
                ItemTemplate = new DataTemplate(typeof(TextCell))
            };
            l.ItemTemplate.SetBinding(TextCell.TextProperty, "KullaniciAdi");
            l.ItemTemplate.SetBinding(TextCell.DetailProperty, "TumIsim");

            Button sil = new Button()
            {
                Text = "Sil"
            };
            sil.Clicked += (s, e) =>
            {
                var profiller = this.BindingContext as List<Profil>;
                var profil = l.SelectedItem as Profil;
                profiller?.Remove(profil);
            };

            this.BindingContextChanged += (s, e) =>
            {
                l.ItemsSource = this.BindingContext as List<Profil>;
            };


            this.Content = new StackLayout()
            {
                Children = { l, sil }
            };
        }

    }
}
