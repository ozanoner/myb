
#include <iostream>
#include <string>

using namespace std;

class Kitap {
private:
	static int yeni_no;
	int no;
	string adi;
	string yazari;
public:
	Kitap(const string&, const string&);
	void yazdir();
};

int Kitap::yeni_no=0;

Kitap::Kitap(const string& adi, const string& yazari) {
	this->adi = adi;
	this->yazari = yazari;
	this->no = ++Kitap::yeni_no;
}

void Kitap::yazdir() {
	cout << "no:" << this->no <<\
		" adi:" << this->adi <<\
		" yazari:" << this->yazari << endl;
}

int main() {
	Kitap* liste = new Kitap[3] {
		{"kitap-a", "yazar1"},
		{"kitap2", "yazar-b"},
		{"kitap3", "yazar3"}};

	for(int i=0; i<3; i++) {
		liste[i].yazdir();
	}


	return 0;
}

