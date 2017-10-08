
#include "ornek2/Kisi.h"

#ifndef KisiSirala_h_
#define KisiSirala_h_

using namespace std;

class KisiAdiSirala {
public:
	bool operator() (const Kisi& el1, const Kisi& el2) {
		return el1.get_adi()<el2.get_adi() ||
			(el1.get_adi()==el2.get_adi() && 
			 	el1.get_soyadi()<el2.get_soyadi());
	}
};

class KisiSoyadiSirala {
public:
	bool operator() (const Kisi& el1, const Kisi& el2) {
		return el1.get_soyadi()<el2.get_soyadi() ||
			(el1.get_soyadi()==el2.get_soyadi() && 
			 	el1.get_adi()<el2.get_adi());
	}
};

#endif
