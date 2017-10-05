
/*
Konu: sablonlar
*/

#include <iostream>

namespace ns1 {
	template<class T1, class T2>
	bool esitmi(T1 deger1, T2 deger2) {
		return deger1==deger2;
	}
}

using namespace std;
using namespace ns1;

int main() {
	cout << (esitmi<int, double>(1, 1.0) ? "evet":"hayir") << endl;
	cout << (esitmi(1.1, 2) ? "evet":"hayir") << endl;
	return 0;
}
