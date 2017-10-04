
#include <iostream>
#include <functional>
#include <cmath>

using namespace std;
using namespace std::placeholders;

int topla(int v1, int v2, int v3)
{
	return v1+v2+v3;
}

int main() {
	cout << topla(1,2,3) << endl;

	auto f = std::bind<int>(topla, _1, _2, 10);
	cout << f(1,2) << endl;
	cout << f(7,3) << endl;
}
