using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t2
{
    public class PageKonYazili : ContentPage
    {
        public PageKonYazili()
        {
            this.Title = "Yazili";

            // verileri liste halinde gostermek icin
            ListView lw = new ListView();

            // listenin veri kaynagi
            lw.ItemsSource = new ChatBilgi[]
            {
                new ChatBilgi() { Kisi = "ayse", SonTarih = "1/1/2018"},
                new ChatBilgi() { Kisi = "fatma", SonTarih = "1/2/2018"},
                new ChatBilgi() { Kisi = "ali", SonTarih = "3/2/2018"},
            };

            // DataTemplate ile gorunum ozellikleri
            lw.ItemTemplate = new DataTemplate(typeof(TextCell));
            lw.ItemTemplate.SetBinding(TextCell.TextProperty, "Kisi");
            lw.ItemTemplate.SetBinding(TextCell.DetailProperty, "SonTarih");
            lw.ItemTemplate.SetValue(TextCell.TextColorProperty, Color.Black);

            // listeden secim yapildiginda
            lw.ItemTapped += async (s, e) =>
                await DisplayAlert("Konusma", e.Item.ToString(), "Tamam");

            // sayfa iceri olarak lw yi atama
            this.Content = lw;
        }
    }



    public class ChatBilgi
    {
        public string Kisi { get; set; }
        public string SonTarih { get; set; }
        public override string ToString()
        {
            return $"{Kisi}\n{SonTarih}\nKonusmalarin ozeti gibi";
        }
    }
}