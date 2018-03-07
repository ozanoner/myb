using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e5
{
    // test sinifi
    class VeritabaniBaglantisi
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            VeritabaniBaglantisi baglanti = new VeritabaniBaglantisi();
            try
            {
                baglanti.Ac();
                // veritabani islemleri
            }
            catch(Exception e)
            {
                Log(e);
                throw;
            }
            finally
            {
                // finally blogu KESIN calisir
                if (baglanti.BaglantiAcik)
                    baglanti.Kapat();
            }
        }

        private static void Log(Exception e)
        {
        }
    }
}
