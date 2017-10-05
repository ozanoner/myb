
#include <iostream>
#include <exception>

using namespace std;

// yeni bir istisna sinifi
class yeni_istisna: public exception {
protected:
	int hata_kodu;
public:
	// kurucu
	yeni_istisna(int i): hata_kodu(i), exception() { }
	// tanim fonksiyonu yukleme
	const char* what() const throw() {
		return "yeni_istisna";
	}
	// hata kodu
	int hata_degeri() { return this->hata_kodu; }
};

int foo(int i) {
	if(i<5)
		throw yeni_istisna(3);
}

int main() {
	try {
		foo(2);
	}
	catch(yeni_istisna& e) {
		cerr << "HATA: " << e.what() << ":" << e.hata_degeri() << endl;
	}
}
