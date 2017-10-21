
#include <iostream>
#include <string>
#include "json/json.hpp"

using namespace std;

using json = nlohmann::json;

class Kitap {
public:
	string adi;
	int no;
	double fiyat;
	bool stokta;
};

// Kitap'tan json'a cevirme
void to_json(json& j, const Kitap& k);
// json'dan Kitap'a cevirme
void from_json(const json& j, Kitap& k);

int main() {
	// kitap nesnesi 
	Kitap k1 = { "kitap-2", 2, 12.30, false };
	// json degisken
	json j1 =k1;

	cout << j1;
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

