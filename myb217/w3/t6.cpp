
#include <iostream>
#include <vector>

using namespace std;

int main() {

	vector<int> v1;
	v1.reserve(10);

	v1.push_back(2); // sonuna ekle
	v1.push_back(6); // sonuna ekle

	cout << "eleman[0]: " << v1[0] << endl;
	cout << "eleman[0]: " << v1.at(0) << endl;
	cout << "eleman(on): " << v1.front() << endl;
	cout << "eleman(arka): " << v1.back() << endl;

}

