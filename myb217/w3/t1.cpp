
#include <iostream>
#include <array>
#include <typeinfo>

using namespace std;

int main() {
	array<int,5> a1 {5,4,3 };

	// iterator yontemi
	for(auto pos=a1.cbegin(); pos!=a1.cend(); pos++) {
		cout << *pos << " ";
	}
	cout << endl;

	// auto ile - iterator varsa calisir
	for(const auto& el: a1) {
		cout << el << " ";
	}
	cout << endl;

	// index ile erisim
	cout << "at(1): " << a1.at(1) << endl;
	// dizinin eleman sayisi
	cout << "size: " << a1.size() << endl;
	// max eleman sayisi, size() ile ayni
	cout << "max_size: " << a1.max_size() << endl;

	array<int, 5> a2 { 1 };
	// dizileri yer degistir
	a1.swap(a2);

	auto f=[](array<int,5> aa1) {
		for(const auto& el:aa1)
			cout << el << " ";
		cout << endl;
	};
	cout << "a1: "; f(a1);
	cout << "a2: "; f(a2);

}
