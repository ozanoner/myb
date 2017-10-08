/*
 * Klavye tusuna basildiginda kaydeder
 */


#include <fstream>

#ifndef KlavyeIzleyici_h_
#define KlavyeIzleyici_h_

using namespace std;

class KlavyeIzleyici {
private:
	ofstream kayit;
public:
	KlavyeIzleyici() {
		this->kayit.open("KlavyeIzleyici.txt", ios::app);
	}
	~KlavyeIzleyici() {
		if(this->kayit.is_open())
			this->kayit.close();
	}

	void kaydet(char ch) {
		if(this->kayit.is_open())
			this->kayit << ch;
	}
};

#endif
