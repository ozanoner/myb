/*
 * bind ornek-3: uye fonksiyon ile baglama
 */

#include <iostream>
#include <functional>

using namespace std;
using namespace std::placeholders;

template <typename T>
class Carpim {
private:
	T val;
public:
	Carpim(T&& v): val(v){ };
	void yazdir(T v2) {
		cout << "carpim: " << this->val * v2 << endl;
	}
};

int main() {
	// kullznici tanimli uye fonksiyon
	// _1 -> nesneye karsilik gelir. gerisi fonksiyon parametre
	bind(&Carpim<int>::yazdir, _1, 2)(Carpim<int>(5));

	// veya
	auto carpim3 = bind(&Carpim<int>::yazdir, _1, 3);
	carpim3(Carpim<int>(10));
	carpim3(Carpim<int>(5));
}
