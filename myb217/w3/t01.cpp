
#include <iostream>

using namespace std;

template <typename T>
void print(const T& deger) {
	cout << deger << endl;
}

template <typename T, typename... Tipler>
void print(const T& deger, const Tipler&... digerleri) {
	cout << deger << endl;
	print(digerleri...);
}

int main() {
	print(1, "aa", 3.4, 'a', 5);
}
