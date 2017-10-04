
#include <iostream>

using namespace std;

template <typename T>
void foo(T&& t) { cout << "foo(&&)\n"; };

template <typename T>
void foo(T& t) { cout << "foo(&)\n"; };

class A { };

int main() {
	foo(A());
	A c;
	foo(c);
	return 0;
}
