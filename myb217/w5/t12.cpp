
#include <iostream>
#include <vector>
#include <algorithm>
#include "include/kutu_fonk.h"
using namespace std;

int main() {
	vector<int> v1={4, 2, 3, 1, 5, 4};

	// kucukten buyuge siralama
	sort(v1.begin(), v1.end());
	kutu_yazdir(v1);

	if(binary_search(v1.begin(), v1.end(), 5))
		cout << "bulundu\n";
	else
		cout << "yok\n";
}
