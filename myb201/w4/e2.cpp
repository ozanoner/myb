/*
Konu: referansla / degerle cagirma
*/

#include <iostream>
#include <string>

namespace ns1 {

int artir_ekle(int a, int b) {
	return ++a+b;
}

// artir_ekle yukleme (overload)
int artir_ekle(int* a, int* b) {
	return ++(*a)+(*b);
}

int artir_ekle(int& a, int& b) {
	return ++a+b;
}

}

using namespace std;
using namespace ns1;

int main() {
	int i=1, j=2;
	
	// degerle cagirma - call by value
	cout << artir_ekle(i, j) << endl;
	cout << i << ' ' << j << endl;
	
	// referansla cagirma - call by reference
	cout << artir_ekle(&i, &j) << endl;
	cout << i << ' ' << j << endl;

	return 0;
}