
#include <iostream>
#include <fstream>
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

	// liste kaydetme, serialize
	static bool kaydet(set<Kitap> liste, string dosya_adi); 

	// liste geri yukleme, deserialize
	static set<Kitap> yukle(string dosya_adi); 
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

	// dosyaya kaydetme
	if(Kitap::kaydet(s1, "test.json")) {
		// dosyadan geri yukleme
		set<Kitap> s2 = Kitap::yukle("test.json");
		// yuklenen listedeki kitaplari yazdirma
		for(auto& kitap: s2) 
			cout << kitap.adi << " " << kitap.no << endl;
	}
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

bool Kitap::kaydet(set<Kitap> liste, string dosya_adi) {
	ofstream o(dosya_adi);
	if(o.is_open()) {
		// set -> json
		json j1(liste);
		// dosyaya yazdir
		o << j1;
		o.close();
		cout << "kaydedildi.\n";
		return true;
	}

	cout << "HATA: dosya acilamadi\n";
	return false;
}

set<Kitap> Kitap::yukle(string dosya_adi) {
	ifstream i(dosya_adi);
	if(i.is_open()) {
		json j1;
		// dosyadan json icine oku
		i >> j1;
		// json'dan set olustur
		set<Kitap> liste = j1;
		i.close();
		cout << "liste yuklendi.\n";
		return liste;
	}

	cout << "HATA: dosya acilamadi\n";
	return set<Kitap>();
}
