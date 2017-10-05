
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main() {
	string satir;
	// cikis dosyasi, output file stream
	ifstream ifs;
	// dosya acma
	ifs.open("ornek.txt");
	// dosya acik mi kontrolu
	if(ifs.is_open()) {
		cout << "-- dosya acma basarili" << endl;
		while(getline(ifs, satir)) {
			cout << satir << endl;
		}
		// dosyayi kapatma
		ifs.close();
		return 0;
	}
	else {
		cout << "-- dosya acilamadi\n";
		return 1;
	}
}
