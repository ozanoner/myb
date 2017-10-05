
#include <iostream>
#include <string>

using namespace std;

template <class T>
class Cift {
private:
	T deger[2];
public:
	Cift(T t1, T t2) { deger[0]=t1; deger[1]=t2; };
	T topla() { return deger[0]+deger[1]; };
};

int main() {
	Cift<int> c1(1,2);
	cout << c1.topla() << endl;

	Cift<double> c2(1.1,2.1);
	cout << c2.topla() << endl;

	Cift<string> c3("deneme ", "12");
	cout << c3.topla() << endl;

	return 0;
}
