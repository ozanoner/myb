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

	// Tip cevirme (type cast)
	// Ucgen -> Dikdortgen
	operator Dikdortgen();
};

class Dikdortgen: public Sekil {
public:
	Dikdortgen(int e, int b): Sekil(e, b) {
		cout << "dikdortgen yapici\n";
	}
	int alan() { return this->en * this->boy; }

	// DURUM 2
	// Ucgen -> Dikdortgen
	/* Dikdortgen(const Ucgen& u): Sekil(u.en, u.boy) {
		cout << "tip cevirme -> yapici ile\n";
	} */
	// Ucgen -> Dikdortgen
	Dikdortgen& operator= (const Ucgen& u) {
		cout << "tip cevirme -> operator= ile\n";
		this->en = u.en;
		this->boy = u.boy;
		return *this;
	}
};

// implicit cast -> dogal cevirme
Ucgen::operator Dikdortgen() {
	cout << "tip cevirme -> operator() ile\n";
	return Dikdortgen(this->en, this->boy);
}

int main() {
	// Dikdortgen dd; // HATA

	Ucgen u(1,4);

	// () cast operatoru
	cout << u.en << " ";
	Dikdortgen d(u);

	// () cast operatoru
	u.en =2;
	cout << u.en << " ";
	Dikdortgen d1=u;

	// = operator
	u.en =3;
	cout << u.en << " ";
	d1=u;

	// () cast operatoru
	u.en =4;
	cout << u.en << " ";
	d1 = Dikdortgen(u);

	return 0;
}
