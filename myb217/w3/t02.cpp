
#include <iostream>
#include <utility>

using namespace std;

template <typename T1, typename T2>
ostream& operator<< (ostream& os, pair<T1,T2> p) {
	os<< "pair:["<< p.first <<","<<p.second<<"]";
}

int main() {
	pair<int, float> p {1, 3.4};
	cout << "p:" << p << endl;

	pair<int, float> p2 = make_pair(1,2.2);
	cout << "p2:" << p2 << endl;

	swap(p, p2);
	cout << "swap:\np:" << p << endl;
	cout << "p2:" << p2 << endl;

}

