
#include <iostream>
#include <vector>
#include <algorithm>
#include "include/kutu_fonk.h"
using namespace std;

int main() {
	vector<int> v1={1,2,2,3,2,4,4,4};

	v1.erase(unique(v1.begin(), v1.end()), v1.end());
	kutu_yazdir(v1);
}
