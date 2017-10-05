
#include <iostream>
using namespace std;


class Hayvan { // temel sinif
protected:
	int ayak_sayisi;
public:
	int max_hiz;
};

class Kedi: public Hayvan { // turemis sinif
public:
	int max_ziplama;
};

int main() {
	Kedi k;
	k.max_hiz=20; // Hayvandan turemis ozellik
	k.max_ziplama=2;
	k.ayak_sayisi=4; // DIKKAT, HATALI
	cout << "kedi hiz:" << k.max_hiz
		<< " ziplama:" << k.max_ziplama << endl;

	return 0;
}
