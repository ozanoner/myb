
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
	// kurucu cagirilarak d1 nesnesi
	Dikdortgen d1(2,3); 
	cout << "alan: " << d1.alan() << endl;

	Dikdortgen d2;
	cout << "alan: " << d2.alan() << endl;

	return 0;
}
