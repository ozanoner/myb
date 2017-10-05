/*
Konu: standart input_iterator
*/

#include <iostream>
#include <string>
using namespace std;

int main() {
	int i;
	cout << "tam sayi giriniz: ";
	cin >> i;
	cout << "girilen deger: " << i << endl;
	
	string s;
	cout << "string giriniz: ";
	cin >> s;
	cout << "girilen string: " << s << endl;
	
	cout << "string giriniz: ";
	cin.ignore(1000, '\n');
	getline(cin, s);
	cout << "girilen string: " << s << endl;
	

	return 0;
}

