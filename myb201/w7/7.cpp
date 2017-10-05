
#include <iostream>
using namespace std;


class Hayvan { // temel sinif
protected:
	int ayak_sayisi=4;
public:
	int max_hiz;
};

class Kedi: public Hayvan { // turemis sinif
public:
	int max_ziplama;
	void yazdir() {
	cout << "kedi hiz:" << this->max_hiz
		<< " ziplama:" << this->max_ziplama
		<< " ayak sayisi:" << this->ayak_sayisi << endl;
	}
};

int main() {
	Kedi k;
	k.max_hiz=20; // Hayvandan turemis ozellik
	k.max_ziplama=2;
	k.yazdir();

	return 0;
}
