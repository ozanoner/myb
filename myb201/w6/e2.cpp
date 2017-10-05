
/*
konu: operator yukleme
*/

#include <iostream>
#include <string>

using namespace std;

class Vektor {
private:
public:
	int x,y;
	Vektor() { };
	Vektor(int a, int b): x(a), y(b) { };
	Vektor operator+ (const Vektor&);
};

Vektor Vektor::operator+ (const Vektor& v1) {
	Vektor sonuc;
	sonuc.x = x + v1.x;
	sonuc.y = y + v1.y;
	return sonuc;
}

int main() {
	Vektor vektor1 {2, 3}, vektor2 {4, 5};
	Vektor toplam = vektor1+vektor2;

	cout << "toplam" << "(x,y)=(" \
		<< toplam.x << "," << toplam.y << ")" << endl;


	return 0;
}
