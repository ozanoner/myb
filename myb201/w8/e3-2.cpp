/*
konu: type cast = tip cevirme
*/

#include <iostream>
using namespace std;

class Sekil {
public:
	int en, boy;
	Sekil(int e=0, int b=0): en(e), boy(b) { }
	virtual int alan()=0;
};

class Dikdortgen;

class Ucgen: public Sekil {
public:
	Ucgen(int e, int b): Sekil(e, b) { }
	int alan() { return this->en * this->boy/2; }

	operator Dikdortgen();
};

class Dikdortgen: public Sekil {
public:
	Dikdortgen(int e, int b): Sekil(e, b) {
		cout << "dikdortgen yapici\n";
	}
	int alan() { return this->en * this->boy; }

	Dikdortgen& operator= (const Ucgen& u) {
		cout << "tip cevirme -> operator= ile\n";
		this->en = u.en;
		this->boy = u.boy;
		return *this;
	}
};

Ucgen::operator Dikdortgen() {
	cout << "tip cevirme -> operator() ile\n";
	return Dikdortgen(this->en, this->boy);
}

int main() {
	// Dikdortgen dd; // HATA

	Ucgen u(1,4);

	Dikdortgen d(2,3);
	d= (Dikdortgen)u;
	d= u;

	Dikdortgen d1=Ucgen(2,4);

	return 0;
}
