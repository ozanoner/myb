
//#define _VERSIYON1
#define _VERSIYON2


using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace e1
{
#if _VERSIYON1
    class Profil
    {
        public string KullaniciAdi { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
    }
#elif _VERSIYON2
    class Profil : INotifyPropertyChanged
    {
        // INotifyPropertyChanged interface den gelen event
        public event PropertyChangedEventHandler PropertyChanged;

        protected string kullaniciAdi;
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set
            {
                if (value != this.kullaniciAdi)
                {
                    this.kullaniciAdi = value;
                    OnPropertyChanged();
                }
            }
        }

        string isim;
        public string Isim
        {
            get { return this.isim; }
            set
            {
                if (value != this.isim)
                {
                    this.isim = value;
                    OnPropertyChanged();
                }
            }
        }

        string soyisim;
        public string Soyisim
        {
            get { return this.soyisim; }
            set
            {
                if (value != this.soyisim)
                {
                    this.soyisim = value;
                    OnPropertyChanged();
                }
            }
        }

        public int yas;
        public int Yas
        {
            get { return this.yas; }
            set
            {
                if (value != this.yas)
                {
                    this.yas = value;
                    OnPropertyChanged();
                }
            }
        }

        // ozellik degistiginde cagrilir, ve event olusturur
        protected void OnPropertyChanged(
            [CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
#endif

}
