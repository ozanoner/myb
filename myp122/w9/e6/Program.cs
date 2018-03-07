using System;
using e6.Veri;

namespace e6
{
    class Program
    {
        static void Main(string[] args)
        {
            VeritabaniBaglantisi b = new VeritabaniBaglantisi();
            try
            {
                b.Ac();
                b.KayitEkle(-6);
            }
            catch(GecersizKayitException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (b.BaglantiAcik)
                    b.Kapat();
            }
        }
    }
}
