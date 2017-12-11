
#include <iostream>
#include <cpr/response.h>
#include <cpr/cpr.h>
#include <cpr/cpr.cpp>

using namespace std;

int main() {
	// PUT - UPDATE komutu 
	auto r = cpr::Put(\
			cpr::Url{"http://jsonplaceholder.typicode.com/albums/3"},
			cpr::Payload{{"userId","5"},{"title","album guncelleme"}});
		
	// HTTP response status
	cout << r.status_code << endl; 

	// Content-type tipi
	cout << r.header["content-type"] << endl;

	// response string
	cout << r.text << endl;    
}
