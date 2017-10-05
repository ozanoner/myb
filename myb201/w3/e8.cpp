/*
Konu: for dongusu
*/

#include <iostream>
#include <string>
using namespace std;

int main() {

    string str("deneme 123");
    
    for(auto c: str) {
        if(c=='e')
            continue;
        if(c==' ')
            break;
        cout << c;
    }
    cout << endl;
    
    int ia[] = {1, 2, 3, 4};
    
    for(auto i: ia) {
        cout << i;
    }

	return 0;
}

