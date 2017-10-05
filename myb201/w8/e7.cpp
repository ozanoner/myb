
#include <iostream>
using namespace std;

void yazdir(char* str) {
	cout << str << endl;
}

int main() {
	const char* s1 = "deneme";
	// yazdir(s1); // HATA
	yazdir(const_cast<char*>(s1));

	return 0;
}
