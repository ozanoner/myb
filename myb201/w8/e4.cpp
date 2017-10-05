/* 
Konu: dynamic cast => dinamik cevirme 
*/

#include <iostream>
#include <string>
using namespace std;

class Sekil {
public:
	int en, boy;
	Sekil(int e=0, int b=0): en(e), boy(b) { }
	virtual int alan() { return 0; }
};

class Ucgen: public Sekil {
protected:
	bool dik_acili;
public:
	Ucgen(int e, int b): Sekil(e,b) { }
	int alan() { return this->en*this->boy/2; }
};

void alan_yazdir(string baslik, Sekil* s) {
	cout << baslik << ":";
	if(s)
		cout << s->alan() << endl;
	else
		cout << "null\n";
}

int main() {
	Sekil* p1 = new Sekil(1,2);
	alan_yazdir("p1", p1);
	Sekil* p2 = new Ucgen(3,4);
	alan_yazdir("p2", p2);

	// p1 ucgen mi? degilse NULL
	Ucgen* test = dynamic_cast<Ucgen*>(p1);
	alan_yazdir("p1 dinamik", test);

	// p2 ucgen mi? degilse NULL
	test = dynamic_cast<Ucgen*>(p2);
	alan_yazdir("p2 dinamik", test);

	return 0;
}
