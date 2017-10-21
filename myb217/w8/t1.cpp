
#include <iostream>
#include "json/json.hpp"

using namespace std;

using json = nlohmann::json;

int main() {
	json j1; // json degisken
	// object alan tanimlari
	j1["adi"]="kitap-1"; 
	j1["no"]=1;
	j1["fiyat"]=21.69;
	j1["stokta"]=true;

	// formatsiz olarak yazdirma
	cout << j1;
	cout << "\n\n";
	// formatli olarak yazdirma
	cout << j1.dump(2);
}
