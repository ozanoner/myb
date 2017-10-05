/* 
Konu: sablonlar
*/

#include <iostream>
#include <string>

namespace ns1 {

template<class T1>
T1 ekle(T1 deger1, T1 deger2) {
	return deger1+deger2;
}

}

using namespace std;
using namespace ns1;
int main() {
	cout << ekle(1, 2) << endl;
	cout << ekle(2.3, 4.4) << endl;
	string s1="string ", s2="ekle";
	cout << ekle(s1, s2) << endl;
	
	return 0;
}