
#include <iostream>
#include <vector>
#include <algorithm>
#include "include/kutu_fonk.h"
using namespace std;

bool ciftmi(int i) {
	return i%2==0;
}

bool test(vector<int> v,  const string& baslik) {
	cout << baslik << endl;
	if(all_of(v.begin(), v.end(), ciftmi))
		cout << "tamami cift\n";
	if(any_of(v.begin(), v.end(), ciftmi))
		cout << "bazisi cift\n";
	if(none_of(v.begin(), v.end(), ciftmi))
		cout << "hicbiri cift degil\n";
}

int main() {
	vector<int> v1 ({1,2,3,4,5});

	kutu_yazdir(v1);
	test(v1, "BIRINCI DURUM");

	for(auto& el: v1)
		el *= 2;
	kutu_yazdir(v1);
	test(v1, "IKINCI DURUM");

	for(auto& el: v1)
		++el;
	kutu_yazdir(v1);
	test(v1, "UCUNCU DURUM");

}
