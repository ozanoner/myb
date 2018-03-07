using System;

namespace e8
{
    abstract class Sekil
    {
        public int KenarSayisi { get; set; }
        public override string ToString()
        {
            return $"KS={KenarSayisi}";
        }
        // Tum tureyen siniflar Alan methodunu tanimlamak zorunda
        public abstract double Alan();
    }
    
    // Baska yerde de Kare nin kodu var
    partial class Kare : Sekil
    {
        public int KenarUzunlugu { get; set; }
        public override string ToString()
        {
            return $"KU={KenarUzunlugu}, {base.ToString()}";
        }
        // Temel siniftan gelen Alan methodunun tanimi
        public override double Alan()
        {
            return (double)Math.Pow(this.KenarUzunlugu, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Kare kare = new Kare() { KenarSayisi = 4, KenarUzunlugu = 3 };
            // Cevre property baska bir dosyada
            Console.WriteLine($"Kare bilgi: {kare}, Alan={kare.Alan()}, Cevre={kare.Cevre}");
        }
    }
}
