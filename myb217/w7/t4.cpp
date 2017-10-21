
#include <iostream>
#include <regex>
#include <string>

using namespace std;

int main() {
	// telefon no kalibi
	// 2 alt-kalip: alan-no ve tel-no
	string kalip {"0?([2-5][0-9]{2})-([0-9]{7})"};
	// regex tanimi
	regex reg1(kalip);
	// test edilecek telefon no
	string veri = {"Ali Sonmez, 0531-5314321, Edirne"};

	cout << "regex kalibi (pattern): " << kalip << endl;
	cout << "veri: " << veri << endl;

	// alankodu parantez icine alinacak
	// m[0] => tum tel no
	// m[1] => alan kodu
	// m[2] => tel no
	string yeni = regex_replace(veri, reg1, "0($1)$2");
	cout << yeni << endl;
}
