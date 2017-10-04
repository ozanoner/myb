
#include <iostream>
#include <utility>

int main() {
	int i=10;
	int&& ir = std::move(i);
	i=11;

	std::cout << i << std::endl;
	std::cout << &i << std::endl;
	std::cout << &ir << std::endl;

	int aa=1;
	int& bb=aa;
	std::cout << &aa << std::endl;
	std::cout << &bb << std::endl;
}
