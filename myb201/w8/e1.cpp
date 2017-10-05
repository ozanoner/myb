/*
Konu: cok bicimlilik
*/

#include <iostream> 
using namespace std;

class Sekil {
protected:
	int en, boy;

public:
	Sekil(int a=0, int b=0): en(a), boy(b) { }

	virtual int alan() { return 0; }
};

class Dikdortgen: public Sekil {
public:
	Dikdortgen( int a = 0, int b = 0): Sekil(a, b) { }
	int alan () { return (en * boy); }
};

class Ucgen: public Sekil{
public:
	Ucgen( int a=0, int b=0): Sekil(a, b) { }
	int alan () { return (en * boy / 2); }
};

int main( ) {
	Sekil *sekil1;
	Sekil s(4,5);
	Dikdortgen d(10,7);
	Ucgen  u(10,5);

	sekil1 = &s;
	cout << "sekil: " << sekil1->alan() << endl;

	sekil1 = &d;
	cout << "dikdortgen: " << sekil1->alan() << endl;

	sekil1 = &u;
	cout << "ucgen: " << sekil1->alan() << endl;

	return 0;
}
