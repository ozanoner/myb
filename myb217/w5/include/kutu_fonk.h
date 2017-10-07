#include <iostream>

#ifndef kutu_fonk_
#define kutu_fonk_

using namespace std;

template <typename T>
void kutu_yazdir(T kutu) {
	for(auto el: kutu)
		cout << el << " ";
	cout << endl;
}

#endif
