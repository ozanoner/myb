
#include <iostream>
#include <vector>
#include <algorithm>
#include "include/kutu_fonk.h"
using namespace std;

int main() {
	vector<int> v1={1, 2, 3, 4, 5};
	vector<int> v2(v1.size()); // v1.size kadar yer

	copy(v1.cbegin(), v1.cend(), v2.begin());
	kutu_yazdir(v2);

	copy_if(v1.cbegin(), v1.cend(),\
			v2.begin(),
			[](int el) { return el>=3; });
	kutu_yazdir(v2);

	copy_n(v1.cbegin(), 3, v2.begin());
	kutu_yazdir(v2);
}
