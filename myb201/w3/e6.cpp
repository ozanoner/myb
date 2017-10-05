/* 
Konu: cpp string
*/

#include <iostream>
#include <string>
using namespace std;

int main() {
	string s = "yeni string";
	string s2 ("baska biri");
	string s3 { "bu da baska" };
	
	cout << s << ' ' << s.length() << endl;
	cout << s2 << ' ' << s.size() << endl;
	cout << s3 << endl;
	cout << "------\n";
		
	return 0;
}