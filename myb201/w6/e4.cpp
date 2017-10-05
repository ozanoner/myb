
/*
konu: operator= yukleme
*/

#include <iostream>
#include <string>

using namespace std;

class Vektor {
private:
public:
	int x,y;
	Vektor(): x(0), y(0) { };
	Vektor(int a, int b): x(a), y(b) { };
	Vektor operator= (const Vektor&);
	void yazdir();
};

Vektor Vektor::operator= (const Vektor& v1) {
	this->x = v1.x;
	this->y = v1.y;
	return *this;
}

void Vektor::yazdir() {
	cout << "(x,y)=(" \
		<< this->x << "," << this->y << ")" << endl;
}

int main() {
	Vektor vektor1, vektor2(3,4);

	vektor1.yazdir();
	vektor1=vektor2;
	vektor1.yazdir();

	return 0;
}
