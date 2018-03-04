using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace t3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Debug.WriteLine("MainPage constructor");
            StackLayout sl = new StackLayout();
            this.Content = sl;

            Label lbl1 = new Label() { Text = "Merhaba Dunya" };
            sl.Children.Add(lbl1);

            InitializeComponent();
        }
    }
}
