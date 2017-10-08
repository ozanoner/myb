/*
	Kisi sinifi
*/

#include <string>
#include <sstream>

#ifndef Kisi_h_
#define Kisi_h_

using namespace std;

class Kisi {
protected:
	string adi;
	string soyadi;
	int dogum_yili;
public:
	Kisi(string&& a, string&& s, int&& d):
		adi(a), soyadi(s), dogum_yili(d) { };

	const string& get_adi() const { return this->adi; };
	const string& get_soyadi() const { return this->soyadi; };

	virtual string to_string() const {
		stringstream ss;
		ss << this->adi << " " << this->soyadi << " "\
			<< this->dogum_yili;
		return ss.str();
	};
};

#endif
