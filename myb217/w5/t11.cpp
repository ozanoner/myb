
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

	// karistirma
	random_shuffle(v1.begin(), v1.end());
	kutu_yazdir(v1);
	// buyukten kucuge siralama
	sort(v1.begin(), v1.end(),\
			[](int el1, int el2) { return el1>el2; });
	kutu_yazdir(v1);
}
