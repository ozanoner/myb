using System;
using System.Globalization;
using Xamarin.Forms;

namespace e1
{
    class YasCevirici : IValueConverter
    {
        // kaynaktan (Profil.Yas) hedefe (yas.TextProperty)
        public object Convert(object value, Type targetType, 
            object parameter, CultureInfo culture)
        {
            int i = (int)value;
            return i.ToString();
        }

        //  hedeften (yas.TextProperty) kaynaga (Profil.Yas)
        public object ConvertBack(object value, Type targetType, 
            object parameter, CultureInfo culture)
        {
            string s = (string)value;
            int i = 0;
            Int32.TryParse(s, out i);
            return i;
        }
    }
}
