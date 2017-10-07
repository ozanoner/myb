
#include <iostream>
#include <deque>
#include <algorithm>
using namespace std;

int main() {
	deque<int> d1 = {3,-4,2,1,-2,5};

	auto min_it = min_element(d1.begin(), d1.end());
	cout << "min: " << *min_it << endl;

	min_it = min_element(++min_it, d1.end());
	cout << "min: " << *min_it << endl;

	auto abs_kucuk = [](int el1, int el2) {
		return abs(el1)<abs(el2);
	};

	min_it = min_element(d1.begin(), d1.end(), abs_kucuk);
	cout << "min(abs): " << *min_it << endl;

}

