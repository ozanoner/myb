/*
 * Klavye simulatoru
 */

#include <iostream>
#include <functional>
#include <vector>

#ifndef Klavye_h_
#define Klavye_h_

using namespace std;

class Klavye {
public:
	// callback tipi
	using TusBasCB=function<void(char)>;

	void callbackEkle(TusBasCB cb) {
		this->callbacks.push_back(cb);
	}
	void tusBas(char ch) {
		cout << ch;
		// tum callback fonksiyonlari cagir
		for(auto& fn: this->callbacks)
			fn(ch);
	}
protected:
	vector<TusBasCB> callbacks;
};

#endif
