using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace e3
{
    class ProfilVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string pname = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pname));
        }

        public ProfilVM(Profil p)
        {
            this.profil = p;
            this.kaydetKomutu = new Command(Kaydet);
        }

        // Arka taraftaki gercek veri
        Profil profil;

        public string KullaniciAdi
        {
            get { return profil.KullaniciAdi; }
            set
            {
                if (value == profil.KullaniciAdi)
                    return;
                profil.KullaniciAdi = value;
                this.OnPropertyChanged();
            }
        }

        public string Isim
        {
            get { return profil.Isim; }
            set
            {
                if (value == profil.Isim)
                    return;
                profil.Isim = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged("TumIsim");
            }
        }

        public string Soyisim
        {
            get { return profil.Soyisim; }
            set
            {
                if (value == profil.Soyisim)
                    return;
                profil.Soyisim = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged("TumIsim");
            }
        }

        public string TumIsim
        {
            get { return $"{profil.Soyisim}, {profil.Isim}"; }
        }

        public string Sehir
        {
            get { return profil.Sehir; }
            set
            {
                if (value == profil.Sehir)
                    return;
                profil.Sehir = value;
                this.OnPropertyChanged();
            }
        }

        public int Yas
        {
            get { return profil.Yas; }
            set
            {
                if (value == profil.Yas)
                    return;
                profil.Yas = value;
                this.OnPropertyChanged();
            }
        }

        protected Command kaydetKomutu;
        public Command KaydetKomutu
        {
            get { return this.kaydetKomutu; }
        }

        public void Kaydet()
        {
            System.Diagnostics.Debug.WriteLine("[ProfilDuzenlemeVM] kaydedildi");
            // profil kaydetme islemleri
        }

        
    }
}
