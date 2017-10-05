
#include <iostream>
using namespace std;


class Hayvan { 
// arkadas sinif tanimi
friend class HayvanDostu;
private:
	int hiz_artir() { this->max_hiz++; }
protected:
	int ayak_sayisi=4;
public:
	int max_hiz;
};

class HayvanDostu {
public:
	void hizlandir(Hayvan& h) { h.hiz_artir(); }
	void yazdir(const Hayvan& h) { 
		cout << "hiz:" << h.max_hiz << " ayak:" << h.ayak_sayisi << endl;
	}
};

int main() {
	Hayvan h;
	h.max_hiz=10;

	HayvanDostu d;
	d.hizlandir(h);
	d.yazdir(h);

	return 0;
}
