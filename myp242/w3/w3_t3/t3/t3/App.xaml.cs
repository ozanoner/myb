using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t3
{
    public partial class App : Application
    {
        public App()
        {
            Debug.WriteLine("App constructor");
            InitializeComponent();

            MainPage = new t3.MainPage();
            Debug.WriteLine("App constructor - bitti");
        }

        protected override void OnStart()
        {
            Debug.WriteLine("OnStart icinde");
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("OnSleep icinde");
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            Debug.WriteLine("OnResume icinde");
            // Handle when your app resumes
        }
    }
}
