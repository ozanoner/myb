/*
Konu: cok bicimlilik
*/

#include <iostream> 
using namespace std;

// soyut sinif (abstract class)
class Sekil {
protected:
	int en, boy;

public:
	Sekil(int a=0, int b=0): en(a), boy(b) { }

	// pure virtual = saf sanal
	virtual int alan() =0; 

	void alan_yazdir() {
		cout << "alani:" << this->alan() << endl;
	}
};

class Dikdortgen: public Sekil {
public:
	Dikdortgen(int a=0, int b=0): Sekil(a, b) { }
	int alan () { return (en * boy); }
};

class Ucgen: public Sekil{
public:
	Ucgen( int a=0, int b=0): Sekil(a, b) { }
	int alan () { return (en * boy / 2); }
};

int main( ) {
	Sekil *sekil1;
	// Sekil s(4,5);  // HATA
	Dikdortgen d(10,7);
	Ucgen  u(10,5);

	sekil1 = &d;
	cout << "dikdortgen ";
	sekil1->alan_yazdir();
	
	sekil1 = &u;
	cout << "ucgen ";
	sekil1->alan_yazdir();

	return 0;
}
