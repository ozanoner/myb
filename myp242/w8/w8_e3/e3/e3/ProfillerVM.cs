using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.ObjectModel;

namespace e3
{
    class ProfillerVM: ObservableCollection<ProfilVM>
    {
        public ProfillerVM(IEnumerable<Profil> veriKaynagi)
        {
            foreach (var item in veriKaynagi)
            {
                this.Add(new ProfilVM(item));
            }
        }
        public ProfillerVM()
        {

        }
    }
}
