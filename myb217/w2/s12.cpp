
#include <iostream>

using namespace std;

int main() {
	auto g1=[]() { return 0x30; };
	cout << g1() << endl;

	auto g2=[]() ->char { return 0x30; };
	cout << g2() << endl;

	auto f=[](int i) { return i*2; };
	cout << f(3) << endl;
}
