/*
Konu: etkin hafiza kullanimi
*/

#include <iostream>
#include <string>

using namespace std;
namespace ns1 {
string birlestir(const string& s1, const string& s2) {
	// s1 = "a"; // hata
	return s1+s2;
}
}


using namespace ns1;
int main() {
	string a1 = "bu bir";
	string a2 = " string";
	
	cout << birlestir(a1, a2) << endl;
	
	return 0;
}