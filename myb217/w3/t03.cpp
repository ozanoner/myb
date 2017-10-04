
#include <iostream>
#include <utility>
// #include <tuple>
#include <string>

using namespace std;

int main() {
	using TP1 = std::tuple<int,float,string>;

	auto print =[](TP1 t) { 
		int i; float f; string s;
		std::tie(i,f,s)=t;
		cout << "tuple: [";
		cout << i << "," <<f << "," << s << "]";
	};

	TP1 t {1,2.2,"test"};
	cout << "tuple size: ";
	cout << std::tuple_size<TP1>::value << endl;
	print(t);
}
