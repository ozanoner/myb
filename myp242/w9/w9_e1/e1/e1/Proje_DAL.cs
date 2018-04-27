using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace e1
{
    class Proje_DAL: IDisposable
    {
        private SQLite.SQLiteConnection db;
        public void Baglan()
        {
            db = DependencyService.Get<IVeritabani>().Baglan("w9_proje.db3");
            db.CreateTable<Profil>();
        }

        public IEnumerable<Profil> ProfilleriGetir()
        {
            return db.Table<Profil>();
        }

        public Profil ProfilBul(int Id)
        {
            return db.Table<Profil>().FirstOrDefault(p => p.ID == Id);
        }

        public int ProfilKaydet(Profil p)
        {
            if (p.ID == 0)
                return db.Insert(p);
            else
                return db.Update(p);
        }
        public int ProfilSil(Profil p)
        {
            return db.Delete(p);
        }


        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
