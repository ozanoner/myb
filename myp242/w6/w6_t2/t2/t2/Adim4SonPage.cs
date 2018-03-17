using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t2
{
    public class Adim4SonPage : ContentPage
    {
        public Adim4SonPage(Profil profil)
        {
            this.Title = "Kaydiniz tamamlandi";
            this.Padding = 10;
            NavigationPage.SetHasBackButton(this, false);

            Command navCmd = new Command(
                async () => await Navigation.PopToRootAsync());

            Content = new StackLayout
            {
                Children = {
                    new Label()
                    {
                        Text = $"Yeni profil:\nIsim:{profil.Isim}\nYas:{profil.Yas}",
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                    },
                    new Button()
                    {
                        Text = "Ana sayfa",
                        Command = navCmd
                    }
                }
            };
        }

        // sayfa ekrana gelirken calisan method
        // override ile yeniden tanimlama
        protected override void OnAppearing()
        {
            // DisplayAlert
            Action alert = async ()=>
                await DisplayAlert("Durum", 
                "Yeni profil olusturuldu", "Tamam");
            alert.Invoke();

            base.OnAppearing();
        }
    }
}