
#include <iostream>
#include <vector>

using namespace std;

int main() {

	vector<int> v1;
	v1.reserve(10);

	v1.push_back(2); // sonuna ekle
	v1.push_back(6); // sonuna ekle

	// eleman sayisi
	cout << "sayi: " << v1.size() << endl; 
	// max eleman sayisi
	cout << "kapasite: " << v1.capacity() << endl;

	// buyuklugu, eleman sayisina indir
	v1.shrink_to_fit();
	// eleman sayisi
	cout << "sayi(shrink) : " << v1.size() << endl; 

	v1.pop_back(); // sondakini sil
	// eleman sayisi
	cout << "sayi(pop) : " << v1.size() << endl; 
	cout << "bitti\n";
}

