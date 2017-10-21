
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
	// kitap listesi
	set<Kitap> s1 = {
		{"kitap-1", 1, 11.90, true},
		{"kitap-2", 2, 13.90, true},
		{"kitap-3", 3, 15.90, false}
	};

	// kitap listesinden json dizisi
	json j1(s1);
	cout << j1.dump(2);
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

