/*
	Kisi siniflarinin turedigi soyut sinif
*/

#include <string>
#include <sstream>

#ifndef KisiTemel_h_
#define KisiTemel_h_

using namespace std;

class KisiTemel {
protected:
	string adi;
	string soyadi;
public:
	KisiTemel(string&& a, string&& s):
		adi(a), soyadi(s) { };

	const string& get_adi() const { return this->adi; };
	const string& get_soyadi() const { return this->soyadi; };
	// saf sanal fonksiyon
	virtual string to_string() const =0;
};

#endif
