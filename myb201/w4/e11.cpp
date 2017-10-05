
/* 
Konu: sablonlar
*/

#include <iostream>
#include <string>

namespace ns1 {
	template <class T1> 
	T1 ekle(T1 p1, T1 p2) {
		return p1+p2;
	}
}

using namespace std;
using namespace ns1;
int main() {
	cout << ekle<int>(1,2) << endl;
	cout << ekle<string>("str1"," str2") << endl;

	return 0;
}
