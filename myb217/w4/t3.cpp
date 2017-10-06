
#include <iostream>
#include <map>
using namespace std;

int main() {
	map<string, float> m1 { {"val1", 2.2} };

	m1.insert({"val2", 3.3});
	m1.insert(pair<string, float>("val3", 3.4));
	m1.insert(decltype(m1)::value_type("val4", 2.3));
	m1["aa"]=1.1;

	for(const auto& el: m1) 
		cout << "[" << el.first <<","<<el.second<<"], ";
	cout<<endl;

	cout << "m1[aa]:" << m1["aa"] << endl;

}
