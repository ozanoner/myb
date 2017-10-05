
/*
Vedat Ozan Oner
Konu: siniflar
*/

#include <iostream>

class Dikdortgen {
private:
	int en, boy;
public:
	// siraici (inline) kurucu ve uye ilkdeger
	Dikdortgen(int e, int b): en(e), boy(b) { };

	// siraici (inline) fonksiyon
	int alan() { return en*boy; };
};


using namespace std;

int main() {
	// kurucu cagirilarak d1 nesnesi
	Dikdortgen d1(2,3); 
	cout << "alan: " << d1.alan() << endl;

	return 0;
}
