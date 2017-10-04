
#include <iostream>

using namespace std;

constexpr int foo(int i) {
	return i;
}

int main() {
	int i;
	cin >> i;
	foo(i);

	constexpr auto j=2;
	foo(j);

	int k;
	k=2;
	foo(k);

}
