
#include <iostream>
using namespace std;

// temel sinif
class Hayvan {
public:
	int max_hiz;
};

// turemis sinif
class Kedi: public Hayvan {
public:
	int max_ziplama;
};

int main() {
	Hayvan h;
	h.max_hiz=10;
	cout << "hayvan hiz:" << h.max_hiz << endl;

	Kedi k;
	k.max_hiz=20; // Hayvandan turemis ozellik
	k.max_ziplama=2;
	cout << "kedi hiz:" << k.max_hiz
		<< " ziplama:" << k.max_ziplama << endl;

	return 0;
}
