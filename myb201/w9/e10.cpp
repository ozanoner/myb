
#include <iostream>
using namespace std;


int main() {
	// kod blogu -> try
	try {
		// istisna olusturma
		// throw 1;
		throw 1.1;
	}
	// integer yakalama blogu -> catch
	catch(int i) {
		cerr << "HATA: int istisna olustu" << endl;
	}
	// char yakalama blogu -> catch
	catch(char c) {
		cerr << "HATA: char istisna olustu" << endl;
	}

	return 0;
}
