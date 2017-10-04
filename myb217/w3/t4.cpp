
#include <iostream>
#include <vector>

using namespace std;

class A {
public:
	A() { cout << "A yapici\n"; }
};

int main() {

	cout << "v1 olustur: \n";
	vector<A> v1;
	v1.reserve(10); // sadece yer ayirir
	cout << endl;

	cout << "v2 olustur: \n";
	vector<A> v2(5); // yer ayirir ve yapici fonk calisir
	cout << endl;
}
