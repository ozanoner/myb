
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
	vector<int> v1 {-3,4,1,-2,5,4};

	// ilk 4'u bul
	auto it = find(v1.begin(), v1.end(), 4);
	if(it!=v1.end())
		cout << "4 bulundu\n";

	// 4'ten sonraki ilk negatif deger
	it = find_if(it, v1.end(), [](int el) { return el<0; });
	if(it!=v1.end())
		cout << "4ten sonraki ilk negatif: " << *it << endl;

}
