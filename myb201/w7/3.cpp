
#include <iostream>
using namespace std;


class Hayvan { // temel sinif
public:
	int max_hiz;
	Hayvan(): max_hiz(10) {
		cout << "hayvan yapici" << endl;
	}
	~Hayvan() {
		cout << "hayvan oldu" << endl;
	}
};


class Kedi: public Hayvan { // turemis sinif
public:
	int max_ziplama;
	Kedi(): max_ziplama(2) { // once Hayvan yapici, sonra Kedi yapici
		cout << "kedi yapici" << endl;
	}
	~Kedi() {
		cout << "kedi oldu" << endl;
	}
};

int main() {
	{
		Hayvan h;
		cout << "hayvan hiz:" << h.max_hiz << endl;
	}
	cout << "---------" << endl;

	{
		Kedi k;
		cout << "kedi hiz:" << k.max_hiz
			<< " ziplama:" << k.max_ziplama << endl;
	}

	return 0;
}
