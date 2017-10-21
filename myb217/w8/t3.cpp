
#include <iostream>
#include <string>
#include <set>
#include <map>
#include "json/json.hpp"

using namespace std;

using json = nlohmann::json;

int main() {
	set<string> s1 = { "bir", "iki", "uc" };
	json j1 (s1); // set => array
	cout << j1 << endl;;
	// array elemanlarini print
	for(auto it=j1.cbegin(); it!=j1.cend(); it++)
		cout << *it << endl;
	cout << endl;

	map<string, int> m1 = { {"bir",1}, {"iki",2}, {"uc",3} };
	j1.clear();
	j1 = m1; // map => object
	cout << j1 << endl;;
}
