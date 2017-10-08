
#include <string>
#include "KisiTemel.h"

#ifndef Ogretmen_h_
#define Ogretmen_h_

using namespace std;

class Ogretmen: public KisiTemel {
public:
	Ogretmen(string&& a, string&& s):
		KisiTemel(forward<string>(a),forward<string>(s)) { };

	string to_string() const override {
		std::stringstream ss;
		ss << "ogretmen: " \
			<< this->adi << " "\
			<< this->soyadi;

		return ss.str();
	};
};
#endif


