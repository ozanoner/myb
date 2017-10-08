
/*
 * for_each ve functor
 */

#include <iostream>
#include <algorithm>
#include <vector>
#include "ornek3/Ort.h"

using namespace std;

int main() {
	vector<int> v1 = {1,2,3,4,5,6,7,8};
	// for_each kullandigi functor i doner (eger varsa)
	Ort o = for_each(v1.cbegin(), v1.cend(), Ort());
	cout << "ortalama: " << o.ortalama() << endl;
}
