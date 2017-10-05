
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

	// siraici (inline) fonksiyon
	int alan() { return en*boy; };
};

// kurucu
Dikdortgen::Dikdortgen(int e, int b) {
	en = e;
	boy = b;
}


using namespace std;

int main() {
	// kurucu cagirilarak d1 nesnesi
	Dikdortgen d1(2,3); 
	cout << "alan: " << d1.alan() << endl;

	return 0;
}
