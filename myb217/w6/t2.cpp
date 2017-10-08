
#include <iostream>
#include <set>
#include "ornek2/Kisi.h"
#include "ornek2/KisiSirala.h"
#include "ornek2/KisiFonk.h"

using namespace std;

int main() {
	initializer_list<Kisi> liste {
		{"osman", "sonmez", 1988},
		{"ali", "sonmez", 1997},
		{"osman", "erdem", 1989}
	};

	set<Kisi, KisiAdiSirala> s1 (liste);
	print(s1, "adina gore siralama: ");

	set<Kisi, KisiSoyadiSirala> s2 (liste);
	print(s2, "soyadina gore siralama: ");
}
