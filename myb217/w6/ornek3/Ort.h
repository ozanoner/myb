
#ifndef Ort_h_
#define Ort_h_

class Ort {
private:
	int sayi, toplam;
public:
	Ort(): sayi(0), toplam(0) { };
	double operator() (int i) {
		sayi++; toplam+=i;
	}
	double ortalama() {
		return static_cast<double>(toplam)/static_cast<double>(sayi);
	}
};

#endif
