
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
	int alan();
};


// kurucu
Dikdortgen::Dikdortgen(int e, int b) {
	en = e;
	boy = b;
}

int Dikdortgen::alan() {
	return en*boy;
}


using namespace std;

int main() {
	// kurucu cagirilarak d1 nesnesi
	Dikdortgen d1(2,3); 
	cout << "alan: " << d1.alan() << endl;

	// tektip ilkdeger atama
	Dikdortgen d2 {2, 4};
	cout << "alan: " << d2.alan() << endl;

	return 0;
}
