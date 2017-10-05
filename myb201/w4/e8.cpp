/*
Konu: parametre varsayilan degeri
*/

#include <iostream>

namespace ns1 {
	
int bol(int i, int j=2) {
	return i/j;
}

}

using namespace std;
using namespace ns1;
int main() {
	cout << bol(10) << endl;
	cout << bol(12, 4) << endl;
	
	return 0;
}