
/*
konu: operator yukleme
*/

#include <iostream>
#include <sstream>
#include <string>

using namespace std;

class Vektor {
private:
	int x,y;
public:
	Vektor() { };
	Vektor(int a, int b): x(a), y(b) { };
	Vektor operator+ (const Vektor&);
	string to_string();
};

Vektor Vektor::operator+ (const Vektor& v1) {
	Vektor sonuc;
	sonuc.x = x + v1.x;
	sonuc.y = y + v1.y;
	return sonuc;
}

string Vektor::to_string() {
	stringstream stream1;
	stream1 << "(x,y)=(" << x << "," << y << ")";
	return stream1.str();
}


int main() {
	Vektor vektor1 {2, 3}, vektor2 {4, 5};
	Vektor toplam = vektor1+vektor2;

	cout << "toplam" << toplam.to_string() << endl;

	return 0;
}
