
#include <string>
#include "KisiTemel.h"

#ifndef Ogrenci_h_
#define Ogrenci_h_

using namespace std;

class Ogrenci: public KisiTemel {
protected:
	int no;
public:
	Ogrenci(int n, string&& a, string&& s):
		KisiTemel(forward<string>(a),forward<string>(s)), no(n) { };

	int get_no() const { return this->no; };

	string to_string() const override {
		std::stringstream ss;
		ss << "ogrenci: " \
			<< this->no << " "\
			<< this->adi << " "\
			<< this->soyadi;

		return ss.str();
	};
};
#endif
