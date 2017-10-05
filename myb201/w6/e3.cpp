
/*
konu: this pointer
*/

#include <iostream>
#include <string>

using namespace std;

class Vektor {
private:
	int x,y;
public:
	Vektor(int, int);
	void yazdir();
};

Vektor::Vektor(int x, int y) {
	this->x = x;
	this->y = y;
}

void Vektor::yazdir() {
	cout << "(x,y)=(" << this->x << ":" << this->y << ")" << endl;
}

int main() {
	Vektor v1 {1,2};
	v1.yazdir();

	return 0;
}
