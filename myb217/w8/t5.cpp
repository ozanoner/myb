
#include <iostream>
#include <string>
#include <set>
#include "json/json.hpp"

using namespace std;

using json = nlohmann::json;

class Kitap {
public:
	string adi;
	int no;
	double fiyat;
	bool stokta;
	// set icin gerekli
	bool operator< (const Kitap& k) const
		{ return this->no<k.no; };
};

// Kitap'tan json'a cevirme
void to_json(json& j, const Kitap& k);
// json'dan Kitap'a cevirme
void from_json(const json& j, Kitap& k);

int main() {
	// string'den json
	json j1 = R"( [
  { "adi": "kitap-1",
    "fiyat": 11.9,
    "no": 1,
    "stokta": true },
  { "adi": "kitap-3",
    "fiyat": 15.9,
    "no": 3,
    "stokta": false } ])"_json;

	// json'dan kitap listesi
	set<Kitap> s1 = j1;

	for(auto& el: s1) 
		cout << el.adi << ", " << el.no << endl;
}

void to_json(json& j, const Kitap& k) {
	j=json { {"adi", k.adi}, {"no", k.no},\
		{"fiyat", k.fiyat}, {"stokta", k.stokta} };
}

void from_json(const json& j, Kitap& k) {
	k.adi = j["adi"].get<string>();
	k.no = j["no"].get<int>();
	k.fiyat = j["fiyat"].get<double>();
	k.stokta = j["stokta"].get<bool>();
}

