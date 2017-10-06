
#include <iostream>
#include <map>
using namespace std;

int main() {
	map<string, float> m1 { {"val1", 2.2} };

	auto ret = m1.insert({"val2", 3.3}); // <it, bool>
	cout << (ret.second? "eklendi": "eklenemedi") << endl;
	if(ret.second) {
		auto it=ret.first; // <key, value>
		cout << "anahtar siliniyor.. " << it->first << endl;
		m1.erase(ret.first);
		cout << "anahtar silindi.\n";
	}

}
