
#include <iostream>
using namespace std;


int main() {
	// kod blogu -> try
	try {
		// istisna olusturma
		throw 1;
	}
	// yakalama blogu -> catch
	catch(int i) {
		cerr << "HATA: istisna olustu" << endl;
	}

	return 0;
}
