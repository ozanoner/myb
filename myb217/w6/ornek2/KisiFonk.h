
#include <iostream>

#ifndef KisiFonk_h_
#define KisiFonk_h_

using namespace std;

template <typename T>
void print(const T& set, string&& baslik) {
	cout << baslik << endl;
	for(auto& el: set) {
		cout << el.to_string() << endl;
	}
	cout << "----------\n";
};

#endif
