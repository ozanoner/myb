
#include <iostream>

#ifndef Yazici_h_
#define Yazici_h_

using namespace std;

template <typename T>
class Yazici {
private:
	int sayi; // yazdirma sayisi
public:
	Yazici(): sayi(0) { }
	// operator() yukleme
	int operator()(const T& val) {
		cout << val.to_string() << endl;
		return ++sayi;
	}
	int get_sayi() const { return sayi; }
};

#endif
