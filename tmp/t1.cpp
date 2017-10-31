
#include <iostream>
#include <utility>
using namespace std;

class A {
public:
	// A(string _s): s(_s){ };
	A(string&& _s): s(_s){ };
	string s;

};

int main() {
	pair<int, A> p = make_pair(1, A("bb"));
	string s="aa";
	A a(move(s));
	p = make_pair(2, a);
	cout << p.first << p.second.s << endl;
}
