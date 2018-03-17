using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t1
{
    public class NavPage3 : ContentPage
    {
        Command rootNavCmd;
        public NavPage3()
        {
            this.Title = "Bitti";
            NavigationPage.SetHasBackButton(this, false);
            // Kok ekrana don
            rootNavCmd = new Command(
                async () => await this.Navigation.PopToRootAsync());

            this.Content = new StackLayout
            {
                Padding = 10,
                Children = {
                    new Label { Text = "Profil olusturuldu!" },
                    new Button()
                    {
                        Text = "Kok ekrana don",
                        Command = rootNavCmd
                    }
                }
            };
        }
        // android cihazin back butonu basildiginda
        protected override bool OnBackButtonPressed()
        {
            //return base.OnBackButtonPressed();
            rootNavCmd.Execute(this);
            return true;
        }

    }
}