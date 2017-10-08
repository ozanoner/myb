/*
 * bind ornek-4:  callback kullanimi
 */

#include <iostream>
#include <functional>
#include "ornek4/Klavye.h"
#include "ornek4/KlavyeIzleyici.h"

using namespace std;
using namespace std::placeholders;


int main() {
	Klavye klavye;
	klavye.callbackEkle([](char c) { cout << "[lambda callback]"; });

	KlavyeIzleyici iz;
	klavye.callbackEkle(bind(&KlavyeIzleyici::kaydet, &iz,_1));

	klavye.tusBas('a');
	klavye.tusBas('b');
	klavye.tusBas('\n');
	klavye.tusBas('c');

}
