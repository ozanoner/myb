
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
	vector<int> v1 = {3,4,1,5,12,4,4};

	cout << "4'lerin sayisi: ";
	// 4 ile karsilastirma
	cout << count(v1.begin(), v1.end(), 4) << endl;

	cout << "ciftlerin sayisi: ";
	// secme fonksiyonu
	auto sec=[](int el) { return el%2==0; };
	cout << count_if(v1.begin(), v1.end(), sec) << endl;

}
