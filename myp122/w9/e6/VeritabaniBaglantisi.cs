using System;

namespace e6.Veri
{
    public class VeritabaniBaglantisi
    {
        public bool BaglantiAcik { get; private set; } = false;
        public void Ac()
        {
            this.BaglantiAcik = true;
        }
        public void Kapat()
        {
            this.BaglantiAcik = false;
        }
        public void KayitEkle(int kayit)
        {
            // Baglanti acik degilse standart exception
            if (!this.BaglantiAcik)
                throw new InvalidOperationException("baglanti kapali");
            // Gecersiz kayitta yeni tanimli exception
            if (kayit < -5)
                throw new GecersizKayitException("-5'ten kucuk kayit");
        }
    }

    public class GecersizKayitException : Exception
    {
        public GecersizKayitException()
        {
        }

        public GecersizKayitException(string mesaj) : base(mesaj)
        {
        }
    }
}
