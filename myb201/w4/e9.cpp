/*
Konu: fonksiyon prototip
*/

#include <iostream>

namespace ns1 {
// prototipler
int carp(int, int=2);
int ekle(int, int);
double ekle(double, double);
}

using namespace std;
using namespace ns1;

int main () {
	cout << carp(3) << endl;
	cout << carp(3, 6) << endl;
	cout << ekle(3, 4) << endl;
	cout << ekle(3.1, 3.6) << endl;
	
	return 0;
}

namespace ns1 {
// fonksiyonlarin yazilmasi
int carp(int i, int j) {
	return i*j;
}

int ekle(int i, int j) {
	return i+j;
}
// ekle yukleme
double ekle(double i, double j) {
	return i+j;
}

}
