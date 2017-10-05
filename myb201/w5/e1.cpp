
/*
Vedat Ozan Oner
Konu: siniflar
*/

#include <iostream>

class Dikdortgen {
private:
	int en, boy;
public:
	void ilkdegerler(int e, int b);
	int alan();
};


void Dikdortgen::ilkdegerler(int e, int b) {
	en = e;
	boy = b;
}

int Dikdortgen::alan() {
	return en*boy;
}


using namespace std;

int main() {
	Dikdortgen d1;
	d1.ilkdegerler(2, 3);
	cout << "alan: " << d1.alan() << endl;

	return 0;
}
