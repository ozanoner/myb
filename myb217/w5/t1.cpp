
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

void print(int i) {
	cout << i << " ";
}

int main() {
	vector<int> v1={3,4,5,1};
	// elemanlari yazdir
	for_each(v1.begin(), v1.end(), print);
	cout << endl;

	for(auto el: v1)
		cout << el << " ";
	cout << endl;

	// elemanlari artir
	for_each(v1.begin(), v1.end(), [](int& el) { ++el; });
	for_each(v1.begin(), v1.end(), print);
	cout << endl;
	
	// elemanlari artir
	auto f=[](int el) { return ++el; };
	transform(v1.begin(), v1.end(), v1.begin(), f);
	for_each(v1.begin(), v1.end(), print);
	cout << endl;
}
