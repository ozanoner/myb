
#include <iostream>
#include <set>
using namespace std;

int main() {
	set<int> s1 = {6,2,4,0,-1};

	auto ret = s1.insert(5); // ret: pair<iterator,bool>
	// auto ret = s1.insert(2); basarili => false
	cout << "basarili?:" << ret.second << endl;
	cout << "eklenen:" << *ret.first << endl;

	if(ret.second) {
		auto it = s1.erase(ret.first); 
		cout << "silinenden sonra:" << *it << endl;
	}

	// s1.clear();
	for(auto it2=s1.begin(); s1.size()>0; it2=s1.erase(it2));
	cout << "size: " << s1.size() << endl;

}
