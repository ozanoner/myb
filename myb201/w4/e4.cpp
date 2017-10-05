/*
Konu: etkin hafiza kullanimi
*/

#include <iostream>
#include <string>

using namespace std;
namespace ns1 {
string birlestir(string s1, string s2) {
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