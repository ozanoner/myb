/*
 * bind ornek-2: kullanici functor
 */

#include <iostream>
#include <functional>

using namespace std;
using namespace std::placeholders;

template <typename T>
class ToplamYazdir {
public:
	void operator() (const T& t1, const T& t2) {
		cout << "toplam: " << t1+t2 << endl;
	}
};

int main() {
	// kullznici tanimli functor
	auto toplam2 = bind(ToplamYazdir<int>(), _1, 2);
	toplam2(5);
}
