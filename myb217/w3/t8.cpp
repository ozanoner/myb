
#include <iostream>
#include <deque>

using namespace std;

template <typename T>
void print_el(const T& coll,
		const std::string& optstr="")
{
	cout << "sayi: " << coll.size() << endl;
	std::cout << optstr;
	for (const auto& elem : coll) 
		std::cout << elem << " ";
	std::cout << std::endl;
}

int main() {
	deque<string> d1 { "str1", "str2", "str3" };
	print_el(d1);
	
	// one eleman ekle
	d1.push_front("str0");
	d1.push_back("str4");
	print_el(d1, "push fonksiyonu: ");

	// arkadan eleman cikar
	d1.pop_back();
	print_el(d1, "pop_back fonksiyonu: ");

}
