
#include <iostream>
#include <string>
#include <initializer_list>
#include <map>

using namespace std;

int main() {
	std::initializer_list<pair<int, string>> veri = {{4,"val4"},\
		{2,"val2"}, {1, "val1"}, {2, "val2-2"}};

	int anahtar=2;
	map<int, string> m1(veri.begin(), veri.end());
	cout << "map anahtar sayisi: " << m1.count(anahtar) << endl;
	for(auto it=m1.find(anahtar);\
			it!=m1.end() && it->first==anahtar;\
			it++) {
		cout << it->second << endl;
	}

	

	multimap<int, string> m2(veri.begin(), veri.end());
	cout << "mmap anahtar sayisi: " << m2.count(anahtar) << endl;
	for(auto it=m2.find(anahtar);\
			it!=m2.end() && it->first==anahtar;\
			it++) {
		cout << it->second << endl;
	}
}
