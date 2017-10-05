
#include <iostream>
using namespace std;


class Hayvan { // temel sinif
public:
	int max_hiz;
	Hayvan(int h): max_hiz(h) { }
};

class Kedi: public Hayvan { // turemis sinif
public:
	int max_ziplama;
	// dikkat: temel sinif yapici cagriliyor
	Kedi(int z): max_ziplama(z), Hayvan(10) { }
};

int main() {
	Hayvan h(5);
	cout << "hayvan hiz:" << h.max_hiz << endl;
	cout << "---------" << endl;

	Kedi k(2);
	cout << "kedi hiz:" << k.max_hiz << " ziplama:" << k.max_ziplama << endl;

	return 0;
}
