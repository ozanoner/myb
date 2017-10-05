/*
Konu: ilk deger atama
*/

#include <iostream>
using namespace std;

int main() {
	// c-benzeri
	int i=1;
	
	// yapici ilk deger atama -- constructor initialization
	int i2(2);
	
	// tektip deger atama -- uniform initialization c++11
	int i3 {3};
	
	cout << i << endl;
	cout << i2 << endl;
	cout << i3 << endl;

	return 0;
}