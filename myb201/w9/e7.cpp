
#include <iostream>
#include <fstream>

using namespace std;

class Vektor {
public:
	int x, y;
	Vektor(): x(0), y(0) { }
	Vektor(int xp, int yp): x(xp), y(yp) { }

	void yazdir() {
		cout << "Vektor:(" << x << "," << y << ")";
	}
};

int main() {
	fstream f;

	f.open("vektor.bin", ios::binary|ios::out|ios::trunc);
	if(!f.is_open()) {
		cout << "HATA: yazma icin acilamadi\n";
		return 1;
	}

	Vektor x {1, 1};
	// ikilik olarak yazmak icin write fonksiyonu
	f.write(reinterpret_cast<char*>(&x), sizeof(Vektor));
	f.close();

		
	f.open("vektor.bin", ios::binary|ios::in);
	if(!f.is_open()) {
		cout << "HATA: okuma icin acilamadi\n";
		return 2;
	}

	Vektor y;
	// ikilik okumak icin read fonksiyonu
	f.read(reinterpret_cast<char*>(&y), sizeof(Vektor));
	f.close();

	y.yazdir();

	return 0;
}
