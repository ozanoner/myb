
#include <iostream>
#include <set>
#include <vector>
#include <algorithm>
#include "kutu_fonk.h" // yardimci fonksiyonlar
using namespace std;

int main() {
	initializer_list<int> l1 = {3,4,3,1,9,2,4,-1};

	set<int> s1(l1);
	vector<int> v1(l1);

	cout << (is_sorted(s1.begin(), s1.end())?\
		"s1 sirali": "s1 sirali degil") << endl;
	kutu_yazdir(s1);

	cout << (is_sorted(v1.begin(), v1.end())?\
		"v1 sirali": "v1 sirali degil") << endl;
	kutu_yazdir(v1);

}
