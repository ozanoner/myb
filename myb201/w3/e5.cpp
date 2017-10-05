/*
Konu: auto ve decltype
*/

#include <iostream>
using namespace std;

int main() {
	
	int i=1;
	
	auto j=i; // i degerinin tipi ile ayni
	
	decltype(i) k=i;  // i nin tipi ile ayni
	
	cout << i << endl;
	cout << j << endl;
	cout << k << endl;
	
	return 0;	
}