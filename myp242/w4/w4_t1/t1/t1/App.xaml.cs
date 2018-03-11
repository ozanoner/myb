using System;
using System.Diagnostics;
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

            MainPage = new t1.MainPage();
            Debug.WriteLine("app constructor");
        }

        protected override void OnStart()
        {
            Debug.WriteLine("onstart");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Debug.WriteLine("onsleep");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Debug.WriteLine("onresume");
        }
    }
}
