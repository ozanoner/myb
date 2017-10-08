/*
 * bind ornek-1: hazir functor kullanilmasi
 */

#include <iostream>
#include <functional>

using namespace std;
using namespace std::placeholders;

int main() {
	// multiplies ile
	auto times2 = bind(multiplies<int>(), _1, 2);
	cout << times2(3) << endl;

	// fonksiyonel birlestirme (functional composition)
	auto times2plus10 = bind(plus<int>(),
			bind(multiplies<int>(), _1, 2),
			10);
	cout << times2plus10(3) << endl;
}
