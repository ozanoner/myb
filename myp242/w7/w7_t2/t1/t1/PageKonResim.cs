using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace t2
{
    public class PageKonResim : CarouselPage
    {
        public PageKonResim()
        {
            this.Title = "Resimler";
            string[] resimler =
                { "dog.jpg", "elep.jpg", "hedgehog.jpg", "lamb.jpg",
                "lion.jpg", "piglet.jpg", "tiger.jpg" };

            foreach (var sayfa in ResimKaynagi(resimler))
            {
                this.Children.Add(sayfa);
            }
        }

        IEnumerable<ContentPage> ResimKaynagi(string[] liste)
        {
            foreach (var r in liste)
            {
                yield return
                    new ContentPage()
                    {
                        Content = new StackLayout()
                        {
                            Children = {
                                new Label()
                                {
                                    Text = "Resimleri saga-sola kaydir"
                                },
                                new Image()
                                {
                                    Source = r,
                                    VerticalOptions = LayoutOptions.FillAndExpand
                                }
                            }
                        }
                    };
            }
        }
    }
}