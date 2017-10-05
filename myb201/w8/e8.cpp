
#include <iostream>
#include <typeinfo>

using namespace std;

class Sekil {
public:
	virtual void p() { };
};
class Ucgen: public Sekil {
public:
	void p() { };
};

int main() {
	Sekil* s_p = new Sekil;
	Sekil* u_p = new Ucgen;

	cout << "s_p: " << typeid(s_p).name() << endl;
	cout << "u_p: " << typeid(u_p).name() << endl;
	cout << "*s_p: " << typeid(*s_p).name() << endl;
	cout << "*u_p: " << typeid(*u_p).name() << endl;

	return 0;
}
