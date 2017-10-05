
#include <iostream>
using namespace std;


class Hayvan { // temel sinif
public:
	int max_hiz;
};

class Bilgi { // temel sinif
public:
	void yazdir(string sinif_adi) {
		cout << sinif_adi << " bilgileri asagidadir" << endl;
	}
};

// coklu kalitim
class Kedi: public Hayvan, public Bilgi {
public:
	int max_ziplama;
	void kedi_yazdir() {
		cout << "kedi hiz:" << this->max_hiz
			<< " ziplama:" << this->max_ziplama << endl;
	}
};

int main() {
	Kedi k;
	k.max_hiz=20; 
	k.max_ziplama=2;

	k.yazdir("kedi");
	k.kedi_yazdir();

	return 0;
}
