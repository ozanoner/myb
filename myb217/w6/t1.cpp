/*
	 Functor ornegi olarak Yazici sinifi 
*/

#include <iostream>
#include <set>
#include <memory> // unique_ptr
#include "ornek1/Ogrenci.h"
#include "ornek1/Ogretmen.h"
#include "ornek1/Yazici.h"

using namespace std;

using KisiU = unique_ptr<KisiTemel>;

int main() {
	set<KisiU> sinif;
	sinif.insert(KisiU(new Ogretmen("ayse", "fatma")));
	sinif.insert(KisiU(new Ogrenci(1, "ali", "veli")));
	sinif.insert(KisiU(new Ogrenci(2, "osman", "veli")));
	sinif.insert(KisiU(new Ogrenci(3, "lale", "veli")));

	Yazici<KisiTemel> yazdir;

	// sinif listesini yaziciya gonder
	for(auto& kisiel: sinif) {
		yazdir(*kisiel);
	}

	cout << "toplam cikti: " << yazdir.get_sayi() << endl;
}


