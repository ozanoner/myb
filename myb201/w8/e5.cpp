
#include <iostream>
using namespace std;

class Vektor {
public:
	int x,y;
	Vektor(): x(0), y(0) { }
};

class Sekil {
public:
	int en, boy;
	Sekil(int e=0, int b=0): en(e), boy(b) { }
	virtual int alan() { return 0; }
};

class Ucgen: public Sekil {
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
	Vektor* v_p = new Vektor;
	Sekil* s_p = new Sekil;
	Ucgen* uc_p = new Ucgen(2,3);

	// s_p Ucgenle ayni ailede mi?
	Ucgen* test = static_cast<Ucgen*>(s_p);
	alan_yazdir("s_p statik", test);

	// uc_p Ucgenle ayni ailede mi?
	test = static_cast<Ucgen*>(uc_p);
	alan_yazdir("uc_p statik", test);

	// v_p Ucgenle ayni ailede mi?
	// test = static_cast<Ucgen*>(v_p); // HATA

	return 0;
}
