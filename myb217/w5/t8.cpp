
#include <iostream>
#include <vector>
#include <algorithm>
#include "include/kutu_fonk.h"
using namespace std;

int main() {
	vector<int> v1={1, 2, 3, 4, 5};

	auto pos = remove(v1.begin(), v1.end(), 3);
	v1.erase(pos, v1.end());
	kutu_yazdir(v1);

	pos = remove_if(v1.begin(), v1.end(),\
			[](int el) { return el>3; });
	v1.erase(pos, v1.end());
	kutu_yazdir(v1);
}
