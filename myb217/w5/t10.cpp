
#include <iostream>
#include <vector>
#include <algorithm>
#include "include/kutu_fonk.h"
using namespace std;

int main() {
	vector<int> v1={1, 2, 3, 4, 5};

	reverse(v1.begin(), v1.end());
	kutu_yazdir(v1);
}
