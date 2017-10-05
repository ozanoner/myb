/*
Konu: fonksiyon yukleme (overload)
*/

#include <iostream>
#include <string>

namespace ns1 {

int artir_ekle(int a, int b) {
	return ++a+b;
}

// artir_ekle yukleme (overload)
float artir_ekle(float a, float b) {
	return ++a+b;
}

}

using namespace std;
using namespace ns1;

int main() {
	int i=1, j=2;
	
	// integer parametre ile
	cout << artir_ekle(i, j) << endl;
	cout << i << ' ' << j << endl;
	
	float f1 = 1.1, f2 = 2.4;
	
	// integer parametre ile
	cout << artir_ekle(f1, f2) << endl;
	cout << f1 << ' ' << f2 << endl;

	return 0;
}