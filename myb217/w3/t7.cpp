
#include <iostream>
#include <vector>
#include <typeinfo>

using namespace std;

int main() {

	vector<int> v1;
	v1.reserve(10);

	v1.push_back(2); // sonuna ekle
	v1.push_back(6); // sonuna ekle
	v1.push_back(8); // sonuna ekle

	// auto for
	for(const auto& el: v1) 
		cout << el << " ";
	cout << endl;
	// iterator
	for(auto pos=v1.cbegin(); pos!=v1.cend(); pos++)
		cout << *pos << " ";
	cout << endl;

	// cout << typeid(v1.begin()).name() << endl;
}

