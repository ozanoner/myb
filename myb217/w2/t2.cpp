
#include <iostream>

using namespace std;

void foo(int& a) { std::cout << "foo(&)\n"; };
void foo(int&& a) { std::cout << "foo(&&)\n";  };

class A { };
void foo(A&& a) { std::cout << "foo(&&) - class A\n";  };

int main() {
	int x;
	foo(x);
	foo(4);

	A a1;
	// foo(a1); // HATA, a1 deger degil degisken
	foo(A());

	return 0;
}
