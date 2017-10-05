
/*
Vedat Ozan Oner
Konu: siniflar
*/

#include <iostream>

class Dikdortgen {
private:
	int en, boy;
public:
	Dikdortgen(int, int); // kurucu
	Dikdortgen(); // kurucu yukleme
	int alan();
};


// kurucu
Dikdortgen::Dikdortgen(int e, int b) {
	en = e;
	boy = b;
}

// kurucu yukleme
Dikdortgen::Dikdortgen() {
	en = 6;
	boy = 7;
}

int Dikdortgen::alan() {
	return en*boy;
}


using namespace std;

int main() {
	// dizi1 pointer, new => yeni hafiza alani
	Dikdortgen* dizi1 = new Dikdortgen[2] { {4, 3}, {4, 4} };
	for(int i=0; i<2; i++) {
		cout << "alan(" << i << "): " << dizi1[i].alan() << endl;
	}

	delete[] dizi1;

	return 0;
}
