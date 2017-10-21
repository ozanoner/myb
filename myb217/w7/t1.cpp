
#include <iostream>
#include <regex>
#include <string>
#include <vector>

using namespace std;

int main() {
	// telefon no kalibi
	string kalip {"0?[2-5][0-9]{2}-[0-9]{7}"};
	// regex tanimi
	regex reg1(kalip);
	// test edilecek telefon listesi
	vector<string> tel_liste {{"0531-5314321" },
		{"231-5314321" },
		{"023-1123123" },
		{"511-1210" }};

	cout << "regex kalibi (pattern): " << kalip << endl;
	for(auto& tel: tel_liste) {
		// kaliba uyma testi
		if(regex_match(tel, reg1))
			cout << "gecerli telno: " << tel << endl;
		else
			cout << "gecersiz telno: " << tel << endl;
	}
}
