
#include <iostream>
#include <set>

using namespace std;

int main() {
	std::set<int> s1 = {1,3,8,2,1 };
	// 1 degeri sadece bir kez eklendi
	for(auto it=s1.find(1); it!=s1.end() && *it==1; it++)
		cout << "bulundu\n";

	cout << "--\n";
	std::multiset<int> s2 = {1,3,8,2,1 };
	// 1 degeri 2 kez eklendi
	for(auto it=s2.find(1); it!=s2.end() && *it==1; it++)
		cout << "bulundu\n";
}
