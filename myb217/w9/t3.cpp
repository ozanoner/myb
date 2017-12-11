
#include <iostream>
#include <cpr/response.h>
#include <cpr/cpr.h>
#include <cpr/cpr.cpp>

using namespace std;

int main(int argc, char** argv) {
	/*
    auto r = cpr::Get(cpr::Url{"https://api.github.com/repos/whoshuu/cpr/contributors"},
                      cpr::Authentication{"user", "pass"},
                      cpr::Parameters{{"anon", "true"}, {"key", "value"}});
    cout << r.status_code;                  // 200
    cout << r.header["content-type"];       // application/json; charset=utf-8
    cout << r.text;                         // JSON text string
		*/

    auto r = cpr::Get(cpr::Url{"http://www.httpbin.org/get"});
    cout << r.status_code << endl;                  // 200
    cout << r.header["content-type"] << endl;       // application/json; charset=utf-8
    cout << r.text << endl;                         // JSON text string
}
