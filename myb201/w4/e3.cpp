/*
Konu: referansla / degerle cagirma
*/

#include <iostream>
#include <string>

namespace ns1 {

// referansla
int artir_ekle(int& a, int& b) {
	return ++a+b;
}

}

using namespace std;
using namespace ns1;

int main() {
	int i=1, j=2;
	
	// referansla cagirma - call by reference
	cout << artir_ekle(i, j) << endl;
	cout << i << ' ' << j << endl;
	
	return 0;
}