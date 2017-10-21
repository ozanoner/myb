
#include <iostream>
#include <regex>
#include <string>
#include <vector>

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

	// arama sonucu
	smatch m1;

	// arama islemi
	if(regex_search(veri, m1, reg1)) {
		cout << "kalip bulundu. Bilgiler:\n";
		cout << "uyum: " << m1.str() << endl;
		cout << "uyum buyuklugu: " << m1.length() << endl;
		cout << "uyum yeri: " << m1.position() << endl;
		cout << "oncesi: " << m1.prefix().str() << endl;
		cout << "sonrasi: " << m1.suffix().str() << endl;
	}
}
