
#include <iostream>
using namespace std;

class Vektor {
private:
	int x,y;
public:
	Vektor(int i, int j): x(i), y(j) { }
	void vektor_yazdir() {
		cout << "x:" << x << " y:" << y << endl;
	}
};

class Sekil {
private:
	int en, boy;
public:
	Sekil(int i, int j): en(i), boy(j) { }
	void sekil_yazdir() {
		cout << "en:" << en << " boy:" << boy << endl;
	}
};

int main() {
	Vektor* vp = new Vektor(1,2);
	Sekil* sp = reinterpret_cast<Sekil*>(vp);

	sp->sekil_yazdir();

	return 0;
}
