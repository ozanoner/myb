using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var p = new t1.MainPage();

            // NavigationPage ile gezinme yapilabilir
            MainPage = new NavigationPage(p);

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
