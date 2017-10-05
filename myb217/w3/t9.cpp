
#include <iostream>
#include <set>

using namespace std;

template <typename T>
void print_set(T s1) {
	cout << "set size: " << s1.size() << endl;
	for(const auto& el: s1)
		cout << el << " ";
	cout << endl;
}

int main() {
	std::set<int> s1 = {1,3,8,2,1 };
	print_set(s1);
	s1.insert(5);
	print_set(s1);

	cout << "--\n";
	std::multiset<int> s2 = {1,3,8,2,1 };
	print_set(s2);
	s2.insert(5);
	print_set(s2);
}
