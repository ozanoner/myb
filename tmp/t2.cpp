
#include <iostream>
#include <algorithm>
#include <vector>

using namespace std;

class A {
public:
	void operator() (int i) { }
	string str() { return "class A"; }
};

ostream& operator<< (ostream& os, A& a) {
	return os << a.str();
}

int f(int i) { return i; }

int main() {
	vector<int> v={1,2,2,3,5};
	A a2;
	auto ret = for_each(v.begin(), v.end(), a2);
	cout << ret << endl;

	auto ret2 = for_each(v.begin(), v.end(), f);
	cout << ret2(30) << endl;
}
