
#include <iostream>

using FP = int(*)(void);

int test(FP f) {
	return f();
}

int main() {
	std::cout<< test([]() { return 1; });
}
