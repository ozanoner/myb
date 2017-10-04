
#include <iostream>
#include <array>

using namespace std;

template <typename T, size_t SIZE>
void print_arr(array<T, SIZE> arr) {
	// cout << arr.size() << endl;
	for(auto& r: arr) 
		cout << r << " ";
	cout << endl;
}

int main() {
	array<int, 5> a1 {2,4,6,8,9};
	array<int, 5> a2 (a1); // copy constructor
	cout << "a2(a1)\n";
	print_arr(a2);

	for(auto& val: a1)
		val*=2;

	cout << "a2=a1\n";
	a2=a1; // copy 
	print_arr(a2);
	
	cout << "move\n";
	// a1'in degerleri a2'ye tasiniyor
	// a1 kullanilamaz hale gelir
	a2 = std::move(a1); 
	print_arr(a2);

	cout << "fill:\n";
	// a1'i kullanabilmek icin yeni deger atamasi gerekir
	a1.fill(1);
	print_arr(a1);
	print_arr(a2);

}
