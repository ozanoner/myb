
#include <iostream>
#include <exception>

using namespace std;

int main() {
	try {
		// c++ tanimli istisna sinifi
		throw exception();
	}
	catch(const exception& e) {
		cerr << "HATA: istisna olustu:" << e.what() << endl;
	}
	return 0;
}
