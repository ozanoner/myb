
#include <iostream>

using namespace std;

void f(int x) { cout << "f(int)\n"; }
void f(bool b) { cout << "f(bool)\n"; }
void f(void* p) { cout << "f(void*)\n"; }


int main() {
	f(0);
	f(NULL);
	f(nullptr);
}
