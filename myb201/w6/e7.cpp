
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

template <>
class Cift<char> {
private:
	char deger[3];
public:
	Cift(char t1, char t2) { deger[0]=t1; deger[1]=t2; deger[2]=0; };
	string topla() { return string(deger); };
};

int main() {
	Cift<int> c1(1,2);
	cout << c1.topla() << endl;

	Cift<char> c4('a', 'b');
	cout << c4.topla() << endl;

	return 0;
}
