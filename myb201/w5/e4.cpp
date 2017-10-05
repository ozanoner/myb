
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
	// d1 pointer, new => yeni hafiza alani
	Dikdortgen* d1 = new Dikdortgen(4,3);
	cout << "alan: " << d1->alan() << endl;

	delete d1;

	return 0;
}
