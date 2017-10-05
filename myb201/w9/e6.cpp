
#include <iostream>
#include <fstream>

using namespace std;

int main() {
	fstream f;
	// yazma modunda
	f.open("ornek-2.txt", ios::out | ios::trunc);
	// satir yaz
	if(f.is_open()) {
		f << "dosya satiri - 1" << endl;
		f.close();
	}
	else {
		cout << "HATA: yazma icin acilamadi\n"; 
		return 1;
	}

	char c;
	// yazma modunda
	f.open("ornek-2.txt", ios::in);
	if(f.is_open()) {
		while(f.get(c)) {
			cout << c;
		}
	}
	else {
		cout << "HATA: okuma icin acilamadi\n"; 
		return 2;
	}

	return 0;
}
