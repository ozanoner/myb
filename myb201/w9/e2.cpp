
#include <iostream>
#include <fstream>

using namespace std;

int main() {
	// cikis dosyasi, output file stream
	ofstream of;
	// dosya acme
	of.open("ornek.txt");
	// dosyaya yazma
	of << "bu bir ornek dosya" << endl;
	// dosyayi kapatma
	of.close();

	return 0;
}
